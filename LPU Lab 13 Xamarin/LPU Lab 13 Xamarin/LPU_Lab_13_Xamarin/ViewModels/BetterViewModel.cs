using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using LPU_Lab_13_Xamarin.Droid.Annotations;
using Xamarin.Forms;

namespace LPU_Lab_13_Xamarin
{
    public class BetterViewModel : INotifyPropertyChanged
    {
        private string _test;

        public string Test
        {
            get { return _test; }
            set
            {
                _test = value; 
                OnPropertyChanged();
            }
        }

        public ICommand ChangeTextCommand { get; set; }


        public BetterViewModel()
        {
            Test = "This is a test";
            ChangeTextCommand = new Command(ChangeText);
        }

        public void ChangeText()
        {
            Test = "I just changed the Text";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
