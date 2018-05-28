using Caliburn.Micro;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<Screen>
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IWindowManager _windowManager;

        public ShellViewModel(IEventAggregator eventAggregator, IWindowManager windowManager)
        {
            _eventAggregator = eventAggregator;
            _windowManager = windowManager;

            ActivateItem(new AViewModel());
        }

        public void ShowAView()
        {
            ActivateItem(new AViewModel());
        }

        public void ShowBView()
        {
            ActivateItem(new BViewModel(_eventAggregator, _windowManager));
        }

        public void ShowCView()
        {
            ActivateItem(new CViewModel(_windowManager));
        }
    }
}
