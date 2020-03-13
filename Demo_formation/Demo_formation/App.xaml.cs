using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Demo_formation.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Demo_formation
{
    public partial class App : Application
    {
        public static string DatabasePath;
        public App()
        {
            InitializeComponent();
            DatabasePath = string.Empty;
            MainPage = new NavigationPage(new MainPage());
            //MainPage = new MainPage();
        }
        public App(string databasepath)
        {
            InitializeComponent();
            DatabasePath = databasepath;

            MainPage = new NavigationPage(new MainPage());
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
