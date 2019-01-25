using Practica5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;
using Xamarin.Forms;

namespace Practica5.ViewModels.Base
{
	public class ViewModelLocator
	{
		/// <summary>
		/// Creamos un Unity Container al cual solo podemos acceder para leerlo
		/// </summary>
		readonly IUnityContainer _container;

		public ViewModelLocator()
		{
			///Instanciamos el container
			_container = new UnityContainer();

			//ViewModels
			_container.RegisterType<MainViewModel>();
		}

		public MainViewModel MainViewModel
		{
			get { return _container.Resolve<MainViewModel>(); }
		}
	}
}