using Microsoft.Extensions.DependencyInjection;

namespace StackLayout_20070401
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new StackLayout();
        }
    }
}