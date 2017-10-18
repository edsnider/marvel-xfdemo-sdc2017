using Xamarin.Forms;

namespace MarvelDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            var tabs = new TabbedPage { Title = "The Avengers" };

            if (Device.OS == TargetPlatform.Android || Device.OS == TargetPlatform.iOS)
            {
                tabs.Children.Add(new Views.CharactersView());
            }
            else
            {
                tabs.Children.Add(new Views.TizenTV.CharactersView());
            }

            tabs.Children.Add(new Views.AboutView());

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
