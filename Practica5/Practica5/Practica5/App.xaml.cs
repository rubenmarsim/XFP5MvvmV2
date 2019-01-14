using Practica5.ViewModels.Base;
using Practica5.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Practica5
{
    public partial class App : Application
    {

        private static ViewModelLocator _locator;
        /// <summary>
        /// Creamos una propiedad para el ViewModelLocator y en el get
        /// le decimos que coja el locator si esta relleno y sino que lo instancie
        /// </summary>
        public static ViewModelLocator Locator
        {
            get { return _locator = _locator ?? new ViewModelLocator(); }
        }
        public App()
        {
            InitializeComponent();
            //Le pasamos la MainView con un NavigationPage y
            //le pasamos null como parametro
            MainPage = new NavigationPage(new MainView(null));
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
