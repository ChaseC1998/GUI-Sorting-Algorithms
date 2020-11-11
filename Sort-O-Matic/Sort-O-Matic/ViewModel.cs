//Chase Christiansen
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_O_Matic
{
    class ViewModel : INotifyPropertyChanged
    {
        private int index0;
        private int index1;
        private int index2;
        private int index3;
        private int index4;
        private int index5;
        private int index6;
        private int index7;
        private int index8;
        private int index9;

        public int Index0
        {
            get { return index0; }
            set
            {
                index0 = value;                     
                OnPropertyChanged("Index0");
            }
        }

        public int Index1
        {
            get { return index1; }
            set
            {
                index1 = value;
                OnPropertyChanged("Index1");
            }
        }

        public int Index2
        {
            get { return index2; }
            set
            {
                index2 = value;
                OnPropertyChanged("Index2");
            }
        }

        public int Index3
        {
            get { return index3; }
            set
            {
                index3 = value;
                OnPropertyChanged("Index3");
            }
        }

        public int Index4
        {
            get { return index4; }
            set
            {
                index4 = value;
                OnPropertyChanged("Index4");
            }
        }

        public int Index5
        {
            get { return index5; }
            set
            {
                index5 = value;
                OnPropertyChanged("Index5");
            }
        }

        public int Index6
        {
            get { return index6; }
            set
            {
                index6 = value;
                OnPropertyChanged("Index6");
            }
        }

        public int Index7
        {
            get { return index7; }
            set
            {
                index7 = value;
                OnPropertyChanged("Index7");
            }
        }

        public int Index8
        {
            get { return index8; }
            set
            {
                index8 = value;
                OnPropertyChanged("Index8");
            }
        }

        public int Index9
        {
            get { return index9; }
            set
            {
                index9 = value;
                OnPropertyChanged("Index9");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
