using System.Windows.Controls;
using TaskManager.Osadchuk.Navigation;
using TaskManager.Osadchuk.ViewModels;

namespace TaskManager.Osadchuk.Views
{
    /// <summary>
    /// Логика взаимодействия для ProcessListUC.xaml
    /// </summary>
    public partial class ProcessListUC : UserControl, INavigatable
    {
        public ProcessListUC()
        {
            InitializeComponent();
            DataContext = new ProcessListViewModel();
        }
    }
}