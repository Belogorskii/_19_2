using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _19_2
{
    class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object,bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested += value;
        }
        public RelayCommand(Action<object> Execute, Func<object,bool> canExecute=null)
        {
          execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => canExecute?.Invoke(parameter) ?? true;
        public void Execute(object parameter) => execute(parameter);
    }
}
