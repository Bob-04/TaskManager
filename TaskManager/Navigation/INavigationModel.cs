using TaskManager.Osadchuk.Models;

namespace TaskManager.Osadchuk.Navigation
{
    internal enum ViewType
    {
        ProcessList,
        ProcessInfo
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType, ProcessModel processModel);
    }
}