using View_Navigation.Command;
using View_Navigation.Store;
using System.Windows.Input;

namespace View_Navigation.ViewModel
{
    class HomeViewModel : ViewModelBase
    {
        public ICommand NavigateAccountCommand { get; }
        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateAccountCommand(navigationStore);
        }
    }
}
