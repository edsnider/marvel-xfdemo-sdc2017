using MarvelDemo.Views;
using Xamarin.Forms;

namespace MarvelDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var tabs = new TabbedPage { Title = "The Avengers" };
            tabs.Children.Add(new CharactersView());
            tabs.Children.Add(new AboutView());

            MainPage = new NavigationPage(tabs);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
