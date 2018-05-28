using Caliburn.Micro;
using System;

namespace WPFUI.ViewModels
{
    public class UpdateTimeViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public UpdateTimeViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void UpdateTime()
        {
            string message = DateTime.Now.ToString();

            _eventAggregator.PublishOnUIThread(message);

            TryClose();
        }
    }
}
