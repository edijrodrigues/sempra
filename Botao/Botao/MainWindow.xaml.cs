using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Botao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1.Content = "Estou Sozinho";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Background = Brushes.Red;
            button1.Content = "O mouse Clicou em mim, estou feliz";
        }

        private void button1_MouseEnter(object sender, MouseEventArgs e)
        {
            button1.Background = Brushes.Blue;
            button1.Content = "Estou feliz";
        }

        private void button1_MouseLeave(object sender, MouseEventArgs e)
        {
            button1.Content = "Saudades do mouse";
        }
       
    }
}
