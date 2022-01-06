using View_Navigation.Command;
using View_Navigation.Store;
using System.Windows.Input;

namespace View_Navigation.ViewModel
{
    class AccountViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }

        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateHomeCommand(navigationStore);
        }
    }
}
