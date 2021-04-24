using BinWin.ViewModels.Base;
using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Input;
using BinWin.Infrastructure.Commands;
using System.Windows;

namespace BinWin.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        
        /// <summary>
        /// Заголовок окна
        /// </summary>
        private string _Title = "Test BinWin";

        public string Title
        {
            get { return _Title; }
            set { Set(ref _Title, value);}
        }

        private string _Status = "Status";
        public string Status
        {
            get { return _Status; }
            set { Set(ref _Status, value); }
        }

        public ICommand CloseApplicationCommand { get; } //команда

        private void OnCloseApplicationCommandExecuted(object p) // будет выполняться когда команда выполняется
        {
            Application.Current.Shutdown();
        }
        private bool CanCloseApplicationCommandExecute(object p) => true; //эти 2 метода определют кманду
        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
        }
    }
}
