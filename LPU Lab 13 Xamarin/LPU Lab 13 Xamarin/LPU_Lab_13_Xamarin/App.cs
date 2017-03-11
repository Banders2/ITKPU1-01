using LPU_Lab_13_Xamarin.Views;
using Xamarin.Forms;

namespace LPU_Lab_13_Xamarin
{
    public class App : Application
    {
        public App()
        {
            MainPage = new TabbedPageTabbedPage();
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {

        }

    }
}
