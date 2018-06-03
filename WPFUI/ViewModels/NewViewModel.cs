using Caliburn.Micro;

namespace WPFUI.ViewModels
{
    public class NewViewModel : Screen
    {
        public void CloseApp()
        {
            TryClose();
        }
    }
}