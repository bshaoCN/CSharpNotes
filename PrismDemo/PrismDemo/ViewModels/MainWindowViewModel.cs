using Prism.Events;
using Prism.Mvvm;
using System;

namespace PrismDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        IEventAggregator _eventAggregator;
        public MainWindowViewModel(IEventAggregator ea)
        {
            _eventAggregator = ea;
            _eventAggregator.GetEvent<PubSubEvent<string>>().Subscribe(new Action<string>(s => Title = s));
        }
        public MainWindowViewModel()
        {

        }
    }
}
