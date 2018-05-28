using Caliburn.Micro;
using CMTestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.ViewModels
{
    public class BViewModel : Screen, IHandle<string>
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IWindowManager _windowManager;

        private string _timeUpdated;

        public string TimeUpdated
        {
            get { return _timeUpdated; }
            set
            {
                _timeUpdated = value;
                NotifyOfPropertyChange(() => TimeUpdated);
            }
        }

        public BViewModel(IEventAggregator eventAggregator, IWindowManager windowManager)
        {
            _windowManager = windowManager;

            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);
        }

        public void OpenUpdateTime()
        {
            var updateTime = new UpdateTimeViewModel(_eventAggregator);

            _windowManager.ShowDialog(updateTime);
        }

        public void Handle(string message)
        {
            TimeUpdated = message.ToString();
        }
    }
}
