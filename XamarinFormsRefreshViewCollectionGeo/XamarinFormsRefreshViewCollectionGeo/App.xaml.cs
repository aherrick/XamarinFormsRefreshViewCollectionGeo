using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsRefreshViewCollectionGeo.Services;
using XamarinFormsRefreshViewCollectionGeo.Views;

namespace XamarinFormsRefreshViewCollectionGeo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
