using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Percuro.Views.EnterpriseViews.Analytics
{
    public partial class ReportsView : UserControl
    {
        public ReportsView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}