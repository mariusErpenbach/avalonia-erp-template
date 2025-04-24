using System;
using System.Data;
using System.Threading.Tasks;
using MySqlConnector;
using DotNetEnv; // 👉 Wichtig: Namespace für DotNetEnv
using Percuro.Models;
namespace Percuro.Services
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService()
        {
            // 🔃 Lade Umgebungsvariablen aus der .env-Datei
            Env.Load(); // Lädt automatisch aus .env im aktuellen Pfad

            // 📦 Hole Connection String aus Umgebungsvariable
            _connectionString = Environment.GetEnvironmentVariable("MYSQL_CONNECTION")
                                ?? throw new Exception("MYSQL_CONNECTION ist nicht gesetzt.");
        }

        public async Task<bool> TestConnectionAsync()
        {
            try
            {
                using var connection = new MySqlConnection(_connectionString);
                await connection.OpenAsync();
                Console.WriteLine("✅ Verbindung erfolgreich!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Verbindungsfehler: {ex.Message}");
                return false;
            }
        }

        public async Task PrintAllUsersAsync()
        {
            try
            {
                using var connection = new MySqlConnection(_connectionString);
                await connection.OpenAsync();

                string query = "SELECT id, username, role FROM auth";

                using var cmd = new MySqlCommand(query, connection);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Console.WriteLine($"ID: {reader["id"]}, Nutzername: {reader["username"]}, Rolle: {reader["role"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Fehler beim Abrufen der Daten: {ex.Message}");
            }
        }

        public async Task<User?> GetUserByUsernameAsync(string username)
{
    try
    {
        using var connection = new MySqlConnection(_connectionString);
        await connection.OpenAsync();

        string query = "SELECT id, username, password_hash, role FROM auth WHERE username = @username";
        using var cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@username", username);

        using var reader = await cmd.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return new User
            {
                Id = reader.GetInt32("id"),
                Username = reader.GetString("username"),
                PasswordHash = reader.GetString("password_hash"),
                Role = reader.GetString("role")
            };
        }

        return null; // Benutzer wurde nicht gefunden
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Fehler beim Abrufen des Benutzers: {ex.Message}");
        return null;
    }
}
public async Task<bool> CreateAccountAsync(string username, string password, string role)
        {
            try
            {
                // Passwort mit bcrypt hashen
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                using var connection = new MySqlConnection(_connectionString);
                await connection.OpenAsync();

                string query = "INSERT INTO auth (username, password_hash, role) VALUES (@username, @password_hash, @role)";

                using var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password_hash", hashedPassword);
                cmd.Parameters.AddWithValue("@role", role);

                int rowsAffected = await cmd.ExecuteNonQueryAsync();

                return rowsAffected > 0; // Gibt true zurück, wenn der Benutzer erfolgreich erstellt wurde
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Erstellen des Benutzerkontos: {ex.Message}");
                return false;
            }
        }

    }
}
