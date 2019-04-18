﻿using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class ListItemsPage : Page
    {
        private Window window;
        public List<CollectionElement> elements;
        public ListItemsPage(Window window)
        {
            InitializeComponent();
            this.window = window;
            elements = new List<CollectionElement>();
            using (var context = new CollectionContext())
            {
                for(int i = 0; i < context.Elements.Count(); i++)
                {
                    ItemModel item = new ItemModel(ImageConvert.LoadImage(context.Elements.ToList()[i].Image), context.Elements.ToList()[i].Name, context.Elements.ToList()[i].CreationDate.ToShortDateString(), context.Elements.ToList()[i].Id, context.Elements.ToList()[i].IsWatched);
                    listItem.Items.Add(item);
                    CollectionElement el = new CollectionElement();
                    el.Id = context.Elements.ToList()[i].Id;
                    el.Name= context.Elements.ToList()[i].Name;
                    el.CreationDate= context.Elements.ToList()[i].CreationDate;
                    el.Image = context.Elements.ToList()[i].Image;
                    elements.Add(el);
                }
                context.SaveChanges();
            }

        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            bool iFound = false;
            for (int i = 0; i < elements.Count; i++)
            {
                if (searchName.Text.ToLower() == elements[i].Name.ToLower())
                {
                    iFound = true;
                    listItem.Items.Clear();
                    listItem.Items.Add(new ItemModel(ImageConvert.LoadImage(elements[i].Image), elements[i].Name, elements[i].CreationDate.ToShortDateString(), elements[i].Id, elements[i].IsWatched));
                }
            }
            if (!iFound)
            {
                listItem.Items.Clear();
                for (int i = 0; i < elements.Count; i++)
                {
                    listItem.Items.Add(new ItemModel(ImageConvert.LoadImage(elements[i].Image), elements[i].Name, elements[i].CreationDate.ToShortDateString(), elements[i].Id, elements[i].IsWatched));
                }
            }
        }

        private void ListItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ItemModel model = (ItemModel)listItem.SelectedItem;
            window.Content = new OneElementPage(window, model.Id);
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            window.Content = new MainMenu(window);
        }
    }
}