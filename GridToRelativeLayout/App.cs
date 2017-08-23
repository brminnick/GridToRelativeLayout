using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridToRelativeLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class App : Application
    {
        public App()
        {
            var gridPage = new GridPage { Title = "Grid" };
            var relativeLayoutPage = new RelativeLayoutPage { Title = "Relative Layout" };

            MainPage = new TabbedPage { Children = { gridPage, relativeLayoutPage } };
        }
    }
}
