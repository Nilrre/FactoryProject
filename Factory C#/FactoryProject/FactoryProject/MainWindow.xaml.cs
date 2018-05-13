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

namespace FactoryProject
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
        

        private void SavePage(object sender, RoutedEventArgs e)
        {

        }

        private void AddComponent(object sender, RoutedEventArgs e)
        {
            Stack2.Visibility = Visibility.Visible;
            Stack3.Visibility = Visibility.Hidden;
        }

        private void SelectLanguage(object sender, RoutedEventArgs e)
        {
            if (languageType.SelectedIndex > -1)
            {
                // do something with their selected language
                Stack1.Visibility = Visibility.Hidden;
                Stack2.Visibility = Visibility.Visible;
            }
        }

        private void SelectComponent(object sender, RoutedEventArgs e)
        {
            if (Components.SelectedIndex > -1)
            {
                // do something with their selected component
                Stack2.Visibility = Visibility.Hidden;
                Stack3.Visibility = Visibility.Visible;
            }
        }

        private void SaveComponent(object sender, RoutedEventArgs e)
        {
            ListBoxItem itm = new ListBoxItem();
            //bind data from boxes to list
            itm.Content = "some text";

            ComponentList.Items.Add(itm);
            Stack3.Visibility = Visibility.Hidden;
        }
    }
}
