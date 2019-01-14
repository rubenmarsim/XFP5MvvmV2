using System;
using System.Collections.Generic;
using System.Text;
using Practica5.ViewModels.Base;
using System.Windows.Input;

namespace Practica5.Models
{
    public class MainViewModel:ViewModelBase
    {
        private int _clicCounter;
        private DelegateCommand _helloCommand;

        public MainViewModel()
        {
            _clicCounter = 0;
        }

        public string Message
        {
            get { return string.Format("Botón pulsado {0} veces", _clicCounter); }
        }
        public ICommand HelloCommand
        {
            get { return _helloCommand = _helloCommand ?? new DelegateCommand(HelloCommandExecute); }
        }
        private void HelloCommandExecute()
        {
            _clicCounter++;
            RaisePropertyChanged("Message");
        }
    }
}
