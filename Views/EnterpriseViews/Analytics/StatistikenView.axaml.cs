using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Percuro.Views.EnterpriseViews.Analytics
{
    public partial class StatistikenView : UserControl
    {
        public StatistikenView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}