using System;
using System.Windows;
using System.Windows.Controls;
using TaskManager.Osadchuk.Managers;
using TaskManager.Osadchuk.Navigation;
using System.ComponentModel;

namespace TaskManager.Osadchuk
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IContentOwner
    {
        public static event Action StopThreads;
        public ContentControl ContentControl
        {
            get { return _contentControl; }
        }

        public MainWindow()
        {
            InitializeComponent();

            NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.ProcessList, null);
        }

        // Close all Threads after completion of the program.
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            StopThreads?.Invoke();
            Environment.Exit(1);
        }
    }
}