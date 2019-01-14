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
		readonly IUnityContainer _container;

		public ViewModelLocator()
		{
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