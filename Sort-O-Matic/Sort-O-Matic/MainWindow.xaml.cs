//Chase Christiansen
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Sort_O_Matic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel view = new ViewModel();
        private const int NUMBER = 10;
        private int[] arr = new int[NUMBER];
        private static System.Timers.Timer _delayTimer;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = view;
            Random r = new Random();
            for (int i = 0; i < NUMBER; i++)
            {
                int t = r.Next(99);
                arr[i] = t;
            }
            view.Index0 = arr[0];       //Setting fields of view model for the window
            view.Index1 = arr[1];
            view.Index2 = arr[2];
            view.Index3 = arr[3];
            view.Index4 = arr[4];
            view.Index5 = arr[5];
            view.Index6 = arr[6];
            view.Index7 = arr[7];
            view.Index8 = arr[8];
            view.Index9 = arr[9];
        }

        void InsertionSort()                                
        {
            for (int i = 1; i < NUMBER; i++)
            {
                int j = i - 1, k = arr[i];
                for (; j > -1; j--)
                    if (k < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        //delay(1000)
                    }
                    else
                        break;
                arr[j + 1] = k;
            }
        }

        void SelectionSort()
        {
            for (int i = 0; i < NUMBER - 1; i++)
            {
                int k = i;
                for (int j = i + 1; j < NUMBER; j++)
                    if (arr[j] < arr[k])
                    {
                        k = j;
                    }
                Swap(i, k);
                //delay(1000);              Couldn't figure out how to make the time work for pauses in the sort so the user can see the switch in the array that occured each step.
            }                               //Same situation with the other lines with delay(1000). Also had the viewmodel fields set equal to the indexes of the array to update them
        }                                   //in between each step of the sort, but because I couldn't make the pause work, I just moved the field updates for the window down to the action listeners.

        void Swap(int i, int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }

        int QuickSort(int[] a, int start, int end)
        {
            int pivot = a[end];
            int i = (start - 1);
            for (int j = start; j < end; j++)
            {
                if (a[j] < pivot)
                {
                    i++;
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            int temp1 = a[i + 1];
            a[i + 1] = a[end];
            a[end] = temp1;

            return i + 1;
            //delay(1000);
        }

        void DoQuickSort(int[] a, int start, int end)
        {
            if (start < end)
            {
                int pi = QuickSort(a, start, end);
                DoQuickSort(a, start, pi - 1);
                DoQuickSort(a, pi + 1, end);
            }
        }

        private void SelectionButton_Click(object sender, RoutedEventArgs e)
        {
            SelectionSort();

            view.Index0 = arr[0];
            view.Index1 = arr[1];
            view.Index2 = arr[2];
            view.Index3 = arr[3];
            view.Index4 = arr[4];
            view.Index5 = arr[5];
            view.Index6 = arr[6];
            view.Index7 = arr[7];
            view.Index8 = arr[8];
            view.Index9 = arr[9];
        }

        private void InsertionButton_Click(object sender, RoutedEventArgs e)
        {
            InsertionSort();

            view.Index0 = arr[0];
            view.Index1 = arr[1];
            view.Index2 = arr[2];
            view.Index3 = arr[3];
            view.Index4 = arr[4];
            view.Index5 = arr[5];
            view.Index6 = arr[6];
            view.Index7 = arr[7];
            view.Index8 = arr[8];
            view.Index9 = arr[9];
        }

        private void QuickButton_Click(object sender, RoutedEventArgs e)
        {
            DoQuickSort(arr, 0, arr.Length - 1);

            view.Index0 = arr[0];
            view.Index1 = arr[1];
            view.Index2 = arr[2];
            view.Index3 = arr[3];
            view.Index4 = arr[4];
            view.Index5 = arr[5];
            view.Index6 = arr[6];
            view.Index7 = arr[7];
            view.Index8 = arr[8];
            view.Index9 = arr[9];      
        }

        private void QuickDesButton_Click(object sender, RoutedEventArgs e)
        {
            DoQuickSort(arr, 0, arr.Length - 1);

            view.Index0 = arr[9];
            view.Index1 = arr[8];
            view.Index2 = arr[7];
            view.Index3 = arr[6];
            view.Index4 = arr[5];
            view.Index5 = arr[4];
            view.Index6 = arr[3];
            view.Index7 = arr[2];
            view.Index8 = arr[1];
            view.Index9 = arr[0];
        }

        private void SelectionDesButton_Click(object sender, RoutedEventArgs e)
        {
            SelectionSort();

            view.Index0 = arr[9];
            view.Index1 = arr[8];
            view.Index2 = arr[7];
            view.Index3 = arr[6];
            view.Index4 = arr[5];
            view.Index5 = arr[4];
            view.Index6 = arr[3];
            view.Index7 = arr[2];
            view.Index8 = arr[1];
            view.Index9 = arr[0];
        }

        private void InsertionDesButton_Click(object sender, RoutedEventArgs e)
        {
            InsertionSort();

            view.Index0 = arr[9];
            view.Index1 = arr[8];
            view.Index2 = arr[7];
            view.Index3 = arr[6];
            view.Index4 = arr[5];
            view.Index5 = arr[4];
            view.Index6 = arr[3];
            view.Index7 = arr[2];
            view.Index8 = arr[1];
            view.Index9 = arr[0];
        }

        private void MakeButton_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < NUMBER; i++)
            {
                int t = r.Next(99);
                arr[i] = t;
            }
            view.Index0 = arr[0];       
            view.Index1 = arr[1];
            view.Index2 = arr[2];
            view.Index3 = arr[3];
            view.Index4 = arr[4];
            view.Index5 = arr[5];
            view.Index6 = arr[6];
            view.Index7 = arr[7];
            view.Index8 = arr[8];
            view.Index9 = arr[9];
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
        }

        private static void delay(int Time_delay)           //Got the code for the delay method from https://stackoverflow.com/questions/18372355/how-can-i-perform-a-short-delay-in-c-sharp-without-using-sleep 
        {                                                   //This is the only code that I am using I got from an outside source.
            int i = 0;
            _delayTimer = new System.Timers.Timer();
            _delayTimer.Interval = Time_delay;
            _delayTimer.AutoReset = false;
            _delayTimer.Elapsed += (s, args) => i = 1;
            _delayTimer.Start();
            while (i == 0) { };
        }
    }
}
