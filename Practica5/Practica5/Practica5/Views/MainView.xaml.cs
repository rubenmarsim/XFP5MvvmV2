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
		/// <summary>
		/// Constructor principal en el cual definimos el binding context
		/// </summary>
		/// <param name="parameter">le pasamos una propiedad de un objeto</param>
		public MainView (object parameter)
		{
			InitializeComponent ();

			Parameter = parameter;

			BindingContext = App.Locator.MainViewModel;

		}
		/// <summary>
		/// Sobreescribimos la clase para controlar el bindingcontext al iniciar
		/// </summary>
		protected override void OnAppearing()
		{
			var viewModel = BindingContext as MainViewModel;
			if (viewModel != null) viewModel.OnAppearing(Parameter);
		}
		/// <summary>
		/// Sobreescribimos la clase para controlar el bindingcontext al cerrar
		/// </summary>
		protected override void OnDisappearing()
		{
			var viewModel = BindingContext as MainViewModel;
			if (viewModel != null) viewModel.OnDisappearing();
		}
	}
}