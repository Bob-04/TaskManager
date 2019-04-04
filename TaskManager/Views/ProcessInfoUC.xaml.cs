using System.Windows.Controls;
using TaskManager.Osadchuk.Models;
using TaskManager.Osadchuk.Navigation;
using TaskManager.Osadchuk.ViewModels;

namespace TaskManager.Osadchuk.Views
{
    /// <summary>
    /// Логика взаимодействия для ProcessInfoUC.xaml
    /// </summary>
    public partial class ProcessInfoUC : UserControl, INavigatable
    {
        public ProcessInfoUC(ProcessModel processModel)
        {
            InitializeComponent();
            DataContext = new ProcessInfoViewModel(processModel);
        }
    }
}