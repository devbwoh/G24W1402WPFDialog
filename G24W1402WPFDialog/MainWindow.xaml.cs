using System.Windows;

namespace G24W1402WPFDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GundamViewModel vm = new GundamViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = vm;
        }

        public void OnAdd(object sender, RoutedEventArgs e) {
            GundamDlg dialog = new GundamDlg();
            if (dialog.ShowDialog() != true)
                return;

            vm.Add(new GundamModel(dialog.MSName, dialog.MSModel, dialog.MSParty));
        }
    }
}