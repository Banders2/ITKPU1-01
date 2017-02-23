using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using Microsoft.Practices.Prism.PubSubEvents;
using TestModule.Annotations;

namespace TestModule.Views
{
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView2 : UserControl, INotifyPropertyChanged
    {
        readonly IEventAggregator _aggregator;
        public string Message { get; set; } = "Test";
        public TestView2(IEventAggregator eventAggregator)
        {
            _aggregator = eventAggregator;
            DataContext = this;
            _aggregator.GetEvent<SampleStringEvent>().Subscribe(Action);
            InitializeComponent();
            OnPropertyChanged("Message");
        }

        private void Action(string s)
        {
            Message = s;
            OnPropertyChanged("Message");
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
