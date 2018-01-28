using System;
using System.ComponentModel;
using System.Windows.Input;

namespace ProMan_Simulator.Base
{
    public class RelayCommand : ICommand
    {
        private Action<object> _action;
        private Action _actionNoParam;
        private Func<bool> _func;

        public RelayCommand(Action<object> action, Func<bool> func)
        {
            _action = action;
            _func = func;
        }

        public RelayCommand(Action action, Func<bool> func)
        {
            _actionNoParam = action;
            _func = func;
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, new EventArgs());
        }

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            if (_func != null)
                _func();
            return true;
        }



        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (_action == null)
                _actionNoParam();
            else
                _action(parameter);
        }

        public void Execute()
        {
            _actionNoParam();
        }

        #endregion
    }

    
}
