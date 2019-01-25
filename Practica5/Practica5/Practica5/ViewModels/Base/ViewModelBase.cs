using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Practica5.ViewModels.Base
{
    /// <summary>
    /// Hacemos que nuestro Base herede de la interfaz INotifyPropertyChanged, 
    /// la cual va a notificar cuando una propiedad sea cambiada
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {

        public virtual void OnAppearing(object navigationContext)
        {

        }
        public virtual void OnDisappearing()
        {

        }

        /// <summary>
        /// Evento que se ejecuta cuando una propiedad es cambiada
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Metodo que captura cuando se cambia una propiedad
        /// </summary>
        /// <param name="propertyName">Nombre de la propiedad que queremos controlar</param>
        public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}