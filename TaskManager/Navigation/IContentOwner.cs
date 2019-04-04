using System.Windows.Controls;

namespace TaskManager.Osadchuk.Navigation
{
    internal interface IContentOwner
    {
        ContentControl ContentControl { get; }
    }
}