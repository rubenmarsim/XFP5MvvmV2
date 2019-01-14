using System;
using System.Collections.Generic;
using System.Text;
using Practica5.ViewModels.Base;
using System.Windows.Input;

namespace Practica5.Models
{
    public class MainViewModel:ViewModelBase
    {
        //Declaramos las variables globales, en este caso el contador
        //y la clase del DelegateCommand
        private int _clicCounter;
        private DelegateCommand _helloCommand;

        /// <summary>
        /// En el constructor principal ponemos el contador a 0
        /// </summary>
        public MainViewModel()
        {
            _clicCounter = 0;
        }
        #region Binding Properties
        public string Header
        {
            get { return string.Format("Practica 5 MVVM Rubén Martinez"); }
        }
        public string Message
        {
            get { return string.Format("Botón pulsado {0} veces", _clicCounter); }
        }
        public ICommand HelloCommand
        {
            get { return _helloCommand = _helloCommand ?? new DelegateCommand(HelloCommandExecute); }
        }
        #endregion
        #region Methods
        /// <summary>
        /// Metodo que suma uno al contador y cambia la propiedad Message
        /// </summary>
        private void HelloCommandExecute()
        {
            _clicCounter++;
            RaisePropertyChanged("Message");
        }
        #endregion
    }
}
