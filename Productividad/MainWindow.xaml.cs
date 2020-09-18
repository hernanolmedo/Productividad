using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Productividad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            var window = (Window)sender;
            window.Topmost = true;
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var tiempo = int.Parse(textBox.Text.ToString());
            var progress = new Progress<int>(value => progressBar.Value = value);
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    ((IProgress<int>)progress).Report(i);
                    Thread.Sleep(tiempo*600);
                }
            });
        }
    }
}
