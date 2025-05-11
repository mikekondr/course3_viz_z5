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

namespace SplitZonesApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPrevTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tc.SelectedIndex - 1;
            if (newIndex < 0)
            {
                newIndex = tc.Items.Count - 1;
            }
            tc.SelectedIndex = newIndex;
        }

        private void btnNextTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tc.SelectedIndex + 1;
            if (newIndex >= tc.Items.Count)
            {
                newIndex = 0;
            }
            tc.SelectedIndex = newIndex;
        }

        private void btnSelectedTab_Click(object sender, RoutedEventArgs e)
        {
            if (tc.SelectedItem != null)
            {
                MessageBox.Show($"Поточна вкладка: {((TextBlock)((StackPanel)((TabItem)tc.SelectedItem).Header).Children[1]).Text}");
            }
            else
            {
                MessageBox.Show("Немає поточної вкладки!");
            }
        }
    }
}
