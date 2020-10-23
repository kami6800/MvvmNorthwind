using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MvvmNorthwind.ViewModel.Commands
{
    class GridCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<string> StoredAction { get; set; }

        public GridCommand(Action<string> action)
        {
            StoredAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            StoredAction.Invoke(parameter as string);
        }
    }
}
