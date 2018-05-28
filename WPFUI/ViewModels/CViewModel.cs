using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.ViewModels
{
    public class CViewModel : Screen
    {
        private IWindowManager _windowManager;
        private IEventAggregator _eventAggregator;

        public CViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }

        public void ShowNewView()
        {
            NewViewModel newView = new NewViewModel();
            _windowManager.ShowWindow(newView);
        }
    }
}
