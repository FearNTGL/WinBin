using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BinWin.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged // этот интерефейс способен уведомлять что изменил какоето свойсво
    {

       public event PropertyChangedEventHandler PropertyChanged; // событие PB, Делегат PCEH

        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null) // [] нужно чтоб компилятор сам подставил имя метода PN
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName)); // генерация события.

        }

        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null) // Будет обновлять свойсво присваивать новые значения
            {

            if (Equals(field, value)) return false; // Если свойства равны то фолс
            field = value;                          // иначе
            OnPropertyChanged(PropertyName);        
            return true;

            }

    }
}
