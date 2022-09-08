using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using _19_2.Models;

namespace _19_2.ViewModels
{
    class MainWindowViewModels:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        void OnPropertyChanged([CallerMemberName]string PropertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        private int namber1;
        public int Namber1
        {
            get => namber1;
            set
            {
                namber1 = value;
                OnPropertyChanged();
            }
        }
        private int namber2;
        public int Namber2
        {
            get => namber2;
            set
            {
                namber2 = value;
                OnPropertyChanged();
            }
        }
        private int namber3;
        public int Namber3
        {
            get => namber3;
            set
            {
                namber3 = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p)
        {
            Namber3 = Arigh.Add(Namber1, Namber2);
        }
        private bool CanAddCommandExecute (object p)
        {
            if(Namber1 !=0 || Namber2 !=0)
                return true;
            else
                return false;
        }
        public MainWindowViewModels()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecute);
        }
    }
}
