using MvvmNorthwind.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MvvmNorthwind.ViewModel.Commands
{
    class UpdateProductCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<Products> StoredAction { get; set; }

        public UpdateProductCommand(Action<Products> action)
        {
            StoredAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            StoredAction.Invoke(parameter as Products);
        }
    }
}
