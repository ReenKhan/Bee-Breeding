using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BeeBreeding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            vm.Reset();
        }
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            vm.Data();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            vm.addInput();
        }
    }
}
