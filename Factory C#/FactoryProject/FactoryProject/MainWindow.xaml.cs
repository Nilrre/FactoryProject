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

        string Language = "";

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
            Components.SelectedValue = String.Empty;
            Content.Text = string.Empty;
            XPos.Text = string.Empty;
            YPos.Text = string.Empty;
            WidthText.Text = string.Empty;
            HeightText.Text = string.Empty;
        }

        private void SelectLanguage(object sender, RoutedEventArgs e)
        {
            if (languageType.SelectedIndex > -1)
            {
                Language = languageType.Text;
                Stack1.Visibility = Visibility.Hidden;
                Stack2.Visibility = Visibility.Visible;
            }
        }

        private void SelectComponent(object sender, RoutedEventArgs e)
        {
            if (Components.SelectedIndex > -1)
            {
                Stack2.Visibility = Visibility.Hidden;
                Stack3.Visibility = Visibility.Visible;
            }
        }

        private void SaveComponent(object sender, RoutedEventArgs e)
        {
            ListBoxItem itm = new ListBoxItem();

            int x = 0;
            int.TryParse(XPos.Text, out x);

            int y = 0;
            int.TryParse(YPos.Text, out y);

            int width = 0;
            int.TryParse(WidthText.Text, out width);

            int height = 0;
            int.TryParse(HeightText.Text, out height);

            string content = $"Type: {Components.Text}\n     Content: {Content.Text}\n     X: {x}\n     Y: {y}\n     Width: {width}\n     Height: {height}";

            itm.Content = content;

            ComponentList.Items.Add(itm);
            Stack3.Visibility = Visibility.Hidden;
        }
    }
}
