using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModelP
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private bool canExecute = true;
        private readonly Func<Task> func;

        private void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        public bool CanExecute(object parameter) => canExecute;

        public async void Execute(object parameter)
        {
            canExecute = false;
            RaiseCanExecuteChanged();

            await func();

            canExecute = true;
            RaiseCanExecuteChanged();
        }

        public Command(Func<Task> func)
        {
            this.func = func;
        }
    }
}
