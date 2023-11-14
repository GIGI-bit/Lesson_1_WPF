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

namespace Lesson_1_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private Color color;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_1_rClick(object sender, MouseButtonEventArgs e)
        {
            this.Title = this.btn_1.Content.ToString();
            WPanel.Children.Remove(btn_1);
        }
        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            btn_1.Background = new SolidColorBrush(color);
        }

        private void btn_2_rClick(object sender, MouseButtonEventArgs e)
        {
            this.Title = this.btn_2.Content.ToString();
            WPanel.Children.Remove(btn_2);
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            btn_2.Background = new SolidColorBrush(color);
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            btn_3.Background = new SolidColorBrush(color);
        }

        private void btn_3_rClick(object sender, MouseButtonEventArgs e)
        {
            this.Title = this.btn_3.Content.ToString();
            WPanel.Children.Remove(btn_3);
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            btn_4.Background = new SolidColorBrush(color);
        }

        private void btn_4_rClick(object sender, MouseButtonEventArgs e)
        {
            this.Title = this.btn_4.Content.ToString();
            WPanel.Children.Remove(btn_4);
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            btn_5.Background = new SolidColorBrush(color);
        }

        private void btn_5_rClick(object sender, MouseButtonEventArgs e)
        {
            this.Title = this.btn_5.Content.ToString();
            WPanel.Children.Remove(btn_5);
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            btn_6.Background = new SolidColorBrush(color);
        }

        private void btn_6_rClick(object sender, MouseButtonEventArgs e)
        {
            this.Title = this.btn_6.Content.ToString();
            WPanel.Children.Remove(btn_6);
        }
    }
}
