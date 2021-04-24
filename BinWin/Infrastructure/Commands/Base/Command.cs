using System.ComponentModel;
using System.Windows.Input;
using System;

namespace BinWin.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand
    {
       public event EventHandler CanExecuteChanged // автоматически вызываетсякогда меняется значение
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        
       public abstract bool CanExecute(object parameter); // возвратит тру или лож, можно ли вызывть команду екскут или нет 
        
       public abstract void Execute(object parameter); // точто должно быть выполнено командой
    }
}
