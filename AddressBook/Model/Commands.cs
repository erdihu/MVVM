using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AddressBook.Model
{
    class Commands : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public event Action<string> DoSomething;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var command = parameter as string;
            DoSomething?.Invoke(command);
        }
    }
}
