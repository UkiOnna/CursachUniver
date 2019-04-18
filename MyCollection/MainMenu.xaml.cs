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

namespace MyCollection
{
    public partial class MainMenu : Page
    {
        private Window window;
        public MainMenu(Window window)
        {
            InitializeComponent();
            this.window = window;
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            window.Content = new AddPage(window);
        }

        private void CollectionButtonClick(object sender, RoutedEventArgs e)
        {
            window.Content = new ListItemsPage(window);
        }
    }
}
