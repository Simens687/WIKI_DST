﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WIKI_DST.ViewModel.Helpers
{
    public class ListBoxItemSelectedCommand : ICommand
    {
        private readonly Action<object> _execute;

        public ListBoxItemSelectedCommand(Action<object> execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }

}
