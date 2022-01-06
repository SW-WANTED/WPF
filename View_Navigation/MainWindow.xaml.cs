using View_Navigation.Store;
using View_Navigation.ViewModel;
using System.Windows;

namespace View_Navigation
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        NavigationStore navigationStore = new NavigationStore();

        public MainWindow()
        {
            InitializeComponent();
            navigationStore.CurrentViewModel = new AccountViewModel(navigationStore);
            this.DataContext = new MainViewModel(navigationStore);
        }
    }
}
