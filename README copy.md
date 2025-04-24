# Projektname

## Übersicht

Ein datengetriebenes System zur Verwaltung und Organisation sensibler sowie öffentlicher Informationen. Ziel ist die Schaffung einer sicheren, benutzerfreundlichen und modularen Anwendung für Desktop, Web und mobile Geräte.

---

## 📌 Phase 1: Planung und Konzeptualisierung

### 🎯 Ziele des Systems

- **Datenmanagement und -organisation**
  - Public / Private / Secret-Datenstruktur
- **Trennung von internen und öffentlichen Daten**
- **Sicherheit und Datenschutz**
- **Benutzerfreundlichkeit**
  - Dashboard, Rollen- und Rechteverwaltung

### ⚙️ Wichtige Funktionen

- **Datenbankstruktur**
  - MongoDB, SQL oder alternative Lösung
- **Benutzerverwaltung**
  - Rollen: Admin, Führungskräfte, Mitarbeiter
- **Rechteverwaltung**
  - Zugriffskontrolle auf Datenebene
- **Mehrsprachigkeit** *(optional)*
- **Integration mit externen Systemen**
  - E-Mail-Kommunikation, Webhooks, etc.

### 🧰 Technologiestack

- **Backend:**  
  - C# (Desktop)  
  - API für Web- & Mobile-Version
- **Frontend:**  
  - Next.js (Web)  
  - React (Mobile Web)
- **Datenbank:**  
  - MongoDB oder SQL
- **Security:**  
  - JWT / OAuth  
  - Verschlüsselung sensibler Daten

### 🎨 Design und UI

- Wireframes für Web & Desktop
- Benutzerführung für Admins und Endnutzer
- Mobile-First Design *(optional)*

![Percurio drawio](https://github.com/user-attachments/assets/e89d9743-8523-4a6a-90f8-a3ae88602c3d)

---

## 🖥️ Phase 2: Entwicklung des Desktop-Systems

### 🔧 Grundgerüst

- Einrichtung der Projektstruktur in C#
- UI-Layout für Dashboard & Datenverwaltung:

Dies ist ein Grundgerüst für die EnterpriseView die als Knotenpunkt für die ERP Spezifischen Bereiche dient.
![Enterprise drawio](https://github.com/user-attachments/assets/fedf9129-2e60-4fa6-8af8-0b9b79493760)

### 🔗 Datenbankanbindung

- Verbindung zu MongoDB oder SQL
- Logik zur Trennung privater und öffentlicher Daten

### 🔐 Sicherheit

- Login-System mit Benutzerrollen
- Verschlüsselung vertraulicher Daten
- Backup- und Wiederherstellungsstrategien

### 🧩 Funktionalitäten

- E-Mail-Integration für Benachrichtigungen
- Daten-Import/-Export
- Intensive Tests und Fehlerbehebung

---

## 🌐 Phase 3: Entwicklung der Web- und Mobile-Version

### 🌍 Backend API

- RESTful API zur Kommunikation mit allen Clients
- Authentifizierte Routen je nach Benutzerrolle

### 💻 Web-Version (Next.js)

- UI für Benutzer-Dashboard und Datenanzeige
- Formulare, Buttons, Benutzerinteraktionen
- Leichtgewichtige und performante Umsetzung

### 📱 Mobile Web-Version

- Mobile-First Design
- Reduzierter Funktionsumfang (nur öffentliche Daten)

---

## 🧪 Phase 4: Tests und Qualitätssicherung

### ✅ Funktionale Tests

- Desktop, Web und Mobile-Version

### 🔒 Sicherheitstests

- Penetrationstests (z. B. gegen XSS, SQL-Injection)
- Datenintegritäts-Checks

### 👥 Benutzerakzeptanztest (UAT)

- Feedback von realen Testnutzern einholen und evaluieren


## 🚀 Phase 5: Veröffentlichung und Wartung

### 🗃️ Veröffentlichung der Desktop-App

- Erstellung eines Installationspakets
- Optionale Bereitstellung über App Stores

### 🌐 Veröffentlichung der Web-Version

- Hosting über Plattformen wie Vercel oder Netlify

### 🔄 Wartung und Updates

- Regelmäßige Funktions- und Sicherheitsupdates
- Zeitnahe Behebung von Bugs

---

## 🔮 Langfristige Perspektive

- **Modul-Erweiterung:** z. B. E-Commerce, CRM
- **Cloud-Integration:** hybride Speicherung lokal + Cloud *(zukünftig)*

---
