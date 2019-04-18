using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class OneElementPage : Page
    {
        private Window window;
        public int id;
        public OneElementPage(Window window,int id)
        {
            InitializeComponent();
            this.window = window;
            this.id = id;
            using (var context = new CollectionContext())
            {
                for (int i = 0; i < context.Elements.Count(); i++)
                {
                    if (context.Elements.ToList()[i].Id == id)
                    {
                        image.Source = ImageConvert.LoadImage(context.Elements.ToList()[i].Image);
                        nameElement.Text = context.Elements.ToList()[i].Name;
                        if (context.Elements.ToList()[i].Rate != null)
                        {
                            rateText.Text = "Оценка:" + context.Elements.ToList()[i].Rate.ToString();
                        }
                        else
                        {
                            rateText.Text = "Оценка:-";
                        }
                        if (context.Elements.ToList()[i].IsWatched)
                        {
                            watchedElement.Text = "Просмотрено";
                        }
                        else
                        {
                            watchedElement.Text = "Не просмотрено";
                        }
                        typeElement.Text = context.Elements.ToList()[i].ElementType;
                        linkElement.Text = context.Elements.ToList()[i].Link;
                        try
                        {
                            Uri myUri = new Uri(context.Elements.ToList()[i].Link, UriKind.Absolute);
                            hyperLink.NavigateUri = myUri;
                        }
                        catch
                        {

                        }
                    }
                }
                context.SaveChanges();
            }
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            window.Content = new ListItemsPage(window);
        }

        private void RedactButtonClick(object sender, RoutedEventArgs e)
        {
            window.Content = new RedactPage(window, id);
        }

        private void HyperLinkRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
                e.Handled = true;
            }
            catch
            {

            }
        }
    }
}
