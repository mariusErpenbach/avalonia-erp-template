using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Percuro.Views.EnterpriseViews.Analytics
{
    public partial class AnalysenView : UserControl
    {
        public AnalysenView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}