using System;
using TaskManager.Osadchuk.Models;
using ProcessListView = TaskManager.Osadchuk.Views.ProcessListUC;
using ProcessInfoView = TaskManager.Osadchuk.Views.ProcessInfoUC;

namespace TaskManager.Osadchuk.Navigation
{
    internal class InitializationNavigationModel : BaseNavigationModel
    {
        public InitializationNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {
        }

        protected override void InitializeView(ViewType viewType, ProcessModel processModel)
        {
            switch (viewType)
            {
                case ViewType.ProcessList:
                    ViewsDictionary.Add(viewType, new ProcessListView());
                    break;
                case ViewType.ProcessInfo:
                    if (ViewsDictionary.ContainsKey(viewType))
                        ViewsDictionary[viewType] = new ProcessInfoView(processModel);
                    else
                        ViewsDictionary.Add(viewType, new ProcessInfoView(processModel));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}