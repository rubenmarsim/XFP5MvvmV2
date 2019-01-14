using Practica5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica5.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : ContentPage
	{
        private object Parameter { get; set; }
		public MainView (object parameter)
		{
			InitializeComponent ();

            Parameter = parameter;

            BindingContext = App.Locator.MainViewModel;

		}
        protected override void OnAppearing()
        {
            var viewModel = BindingContext as MainViewModel;
            if (viewModel != null) viewModel.OnAppearing(Parameter);
        }
        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as MainViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}