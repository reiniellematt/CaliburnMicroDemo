using Caliburn.Micro;

namespace WPFUI.ViewModels
{
    public class CViewModel : Screen
    {
        private IWindowManager _windowManager;

        public CViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
        }

        public void ShowNewView()
        {
            NewViewModel newView = new NewViewModel();
            _windowManager.ShowWindow(newView);

            Conductor<Screen> parent = (Conductor<Screen>)this.Parent;
            parent.TryClose();
        }
    }
}