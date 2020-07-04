using System.Windows;

namespace BeeBreeding
{ 
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            vm.AddInputToList();
        }
    }
}
