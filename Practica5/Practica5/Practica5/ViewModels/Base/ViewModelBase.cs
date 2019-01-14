using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Xamarin.Forms;

namespace Practica5.ViewModels.Base
{
	public abstract class ViewModelBase : INotifyPropertyChanged
	{
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public virtual void OnAppearing(object navigationContext)
        {

        }
        public virtual void OnDisappearing()
        {

        }
        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
        }
	}
}