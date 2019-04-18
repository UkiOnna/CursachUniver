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
    /// <summary>
    /// Interaction logic for ItemModel.xaml
    /// </summary>
    public partial class ItemModel : UserControl
    {
        public int Id { get; private set; }

        public ItemModel()
        {
            InitializeComponent();
        }

        public ItemModel(ImageSource source,string name,string date,int id,bool isWatched)
        {
            InitializeComponent();
            Id = id;
            imageItem.Source = source;
            itemText.Text = name;
            dateText.Text = date;
            if (isWatched)
            {
                WatchedText.Text = "Просмотрено";
            }
            else
            {
                WatchedText.Text = "Не просмотрено";
            }
        }
    }
}
