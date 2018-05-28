using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
