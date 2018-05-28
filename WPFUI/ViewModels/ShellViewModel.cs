using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<Screen>
    {
        private readonly IEventAggregator eventAggregator = new EventAggregator();
        private readonly IWindowManager windowManager = new WindowManager();

        public ShellViewModel()
        {
            ActivateItem(new AViewModel());
        }

        public void ShowAView()
        {
            ActivateItem(new AViewModel());
        }

        public void ShowBView()
        {
            ActivateItem(new BViewModel(eventAggregator, windowManager));
        }
    }
}
