using MvvmNorthwind.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MvvmNorthwind.ViewModel.Commands
{
    class UpdateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<Object> StoredAction { get; set; }

        public UpdateCommand(Action<Object> action)
        {
            StoredAction = action;
        }

        public bool CanExecute(Object parameter)
        {
            return true;
        }

        public void Execute(Object parameter)
        {
            StoredAction.Invoke(parameter as Object);
        }
    }
}
