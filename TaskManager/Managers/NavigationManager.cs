using System.Windows;
using TaskManager.Osadchuk.Navigation;
using TaskManager.Osadchuk.Models;

namespace TaskManager.Osadchuk.Managers
{
    internal class NavigationManager
    {
        private static readonly object Locker = new object();
        private static NavigationManager _instance;

        internal static NavigationManager Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
                lock (Locker)
                {
                    return _instance ?? (_instance = new NavigationManager());
                }
            }
        }

        private INavigationModel _navigationModel;

        private NavigationManager()
        {
        }

        internal void Initialize(INavigationModel navigationModel)
        {
            _navigationModel = navigationModel;
        }

        internal void Navigate(ViewType viewType, ProcessModel processModel)
        {
            if (processModel != null || viewType != ViewType.ProcessInfo)
                _navigationModel.Navigate(viewType, processModel);
            else
                MessageBox.Show("Please, choose a process");
        }

    }
}