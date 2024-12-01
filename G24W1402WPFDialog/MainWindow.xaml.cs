using System.Windows;

namespace G24W1402WPFDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void OnAdd(object sender, RoutedEventArgs e) {
            GundamDlg dialog = new GundamDlg();
            dialog.ShowDialog();
        }
    }
}