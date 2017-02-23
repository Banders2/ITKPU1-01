using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Practices.Prism.PubSubEvents;
using TestModule.Annotations;

namespace TestModule.Views
{
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView : UserControl, INotifyPropertyChanged
    {
        public string Test { get; set; } = "omg";
        private int count = 0;
        readonly IEventAggregator _aggregator;
        public TestView(IEventAggregator eventAggregator)
        {
            _aggregator = eventAggregator;
            DataContext = this;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Test = Test == "omg" ? "Ups" : "omg";
            OnPropertyChanged("Test");
            _aggregator.GetEvent<SampleStringEvent>().Publish(count++.ToString());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

