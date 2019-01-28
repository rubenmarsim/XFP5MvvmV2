using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica5.ViewModels.Base
{
    /// <summary>
    /// Clase para ejecutar comandos
    /// </summary>
    public class DelegateCommand : ICommand
    {
        /// <summary>
        /// Declaramos un objeto action, que determina la accion que
        /// se va a ejecutar
        /// </summary>
        private readonly Action _execute;
        /// <summary>
        /// Determina, si se puede ejecutar o no el comando
        /// </summary>
        private readonly Func<bool> _canExecute;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="execute"></param>
        public DelegateCommand(Action execute) : this(execute, null) { }        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            if (_canExecute != null) return _canExecute();

            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute();
        }
        /// <summary>
        /// 
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            var handle = CanExecuteChanged;
            if (handle != null) handle(this, new EventArgs());
        }
        /// <summary>
        /// 
        /// </summary>
        public event EventHandler CanExecuteChanged;
    }
}