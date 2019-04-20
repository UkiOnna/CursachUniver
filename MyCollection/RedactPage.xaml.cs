using Microsoft.Win32;
using System;
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
    public partial class RedactPage : Page
    {
        private Window window;
        private int id;
        public string filePath;
        public RedactPage(Window window,int id)
        {
            InitializeComponent();
            this.window = window;
            this.id = id;
            comboBoxType.Items.Add("Книга");
            comboBoxType.Items.Add("Фильм");
            comboBoxType.Items.Add("Сериал");
            comboBoxType.Items.Add("Аниме");
            comboBoxType.Items.Add("Другое...");
            
            comboBoxIsWatched.Items.Add("Да");
            comboBoxIsWatched.Items.Add("Нет");
            filePath = "";
            for (int i = 1; i <= 10; i++)
            {
                RateComboBox.Items.Add(i);
            }
            OtherTextBox.Visibility = Visibility.Hidden;
            OtherTextBlock.Visibility = Visibility.Hidden;
            RateComboBox.Visibility = Visibility.Hidden;
            RateText.Visibility = Visibility.Hidden;
            using (var context = new CollectionContext())
            {
                for (int i = 0; i < context.Elements.Count(); i++)
                {
                    if (context.Elements.ToList()[i].Id == id)
                    {
                       imageContainer.Source= ImageConvert.LoadImage(context.Elements.ToList()[i].Image);
                       comboBoxType.SelectedItem = context.Elements.ToList()[i].ElementType;
                        comboBoxType.Items.Add(context.Elements.ToList()[i].ElementType);

                        if (context.Elements.ToList()[i].IsWatched)
                        {
                            comboBoxIsWatched.SelectedItem = "Да";
                        }
                        else
                        {
                            comboBoxIsWatched.SelectedItem = "Нет";
                        }
                        LinkText.Text = context.Elements.ToList()[i].Link;
                        if (context.Elements.ToList()[i].Rate != null)
                        {
                            RateComboBox.SelectedItem = context.Elements.ToList()[i].Rate;
                        }
                        nameText.Text = context.Elements.ToList()[i].Name;
                    }
                }
                context.SaveChanges();
            }
        }

        private void SaveElementClick(object sender, RoutedEventArgs e)
        {
            if (comboBoxType.SelectedItem.ToString() == "Другое..." && OtherTextBox.Text == String.Empty)
            {
                MessageBox.Show("Вы ввели данные неверно");
            }
            else
            {
                if (nameText.Text == String.Empty)
                {
                    MessageBox.Show("Вы ввели данные неверно");
                }
                else
                {
                        using (var context = new CollectionContext())
                        {

                            for (int i = 0; i < context.Elements.Count(); i++)
                            {
                                if (context.Elements.ToList()[i].Id == id)
                                {
                                    context.Elements.ToList()[i].CreationDate = DateTime.Now;
                                    if (filePath != "")
                                    {
                                        context.Elements.ToList()[i].Image = File.ReadAllBytes(filePath);
                                    }

                                    context.Elements.ToList()[i].Name = nameText.Text;
                                    if (comboBoxIsWatched.SelectedItem.ToString() == "Да")
                                    {
                                        context.Elements.ToList()[i].IsWatched = true;
                                    }
                                    else
                                    {
                                        context.Elements.ToList()[i].IsWatched = false;
                                    }
                                    if (LinkText.Text == String.Empty)
                                    {
                                        context.Elements.ToList()[i].Link = "-";
                                    }
                                    else
                                    {
                                        context.Elements.ToList()[i].Link = LinkText.Text;
                                    }
                                    if (RateComboBox.SelectedItem == null)
                                    {
                                        context.Elements.ToList()[i].Rate = null;
                                    }
                                    else
                                    {
                                        int kek;
                                        if (int.TryParse(RateComboBox.SelectedItem.ToString(), out kek))
                                        {
                                            context.Elements.ToList()[i].Rate = kek;
                                        }
                                    }
                                    if (comboBoxType.SelectedItem.ToString() == "Другое...")
                                    {
                                        context.Elements.ToList()[i].ElementType = OtherTextBox.Text;
                                    }
                                    else
                                    {
                                        context.Elements.ToList()[i].ElementType = comboBoxType.SelectedItem.ToString();
                                    }
                                }
                            }
                            context.SaveChanges();
                        }
                        MessageBox.Show("Изменено!");
                        window.Content = new OneElementPage(window, id);
                }
            }
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            window.Content = new OneElementPage(window,id);
        }

        private void LoadClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            //dialog.DefaultExt = ".png";
            dialog.ShowDialog();

            filePath = dialog.FileName;
            if (filePath != "")
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(filePath);
                image.EndInit();

                imageContainer.Source = image;
            }
        }

        private void ComboBoxIsWatchedSelectionChange(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxIsWatched.SelectedItem.ToString() == "Да")
            {
                RateText.Visibility = Visibility.Visible;
                RateComboBox.Visibility = Visibility.Visible;
            }
            else
            {
                RateComboBox.Visibility = Visibility.Hidden;
                RateText.Visibility = Visibility.Hidden;
                RateComboBox.SelectedItem = null;
            }
        }

        private void ComboBoxTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBoxType.SelectedItem.ToString() == "Другое...")
            {
                OtherTextBlock.Visibility = Visibility.Visible;
                OtherTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                OtherTextBlock.Visibility = Visibility.Hidden;
                OtherTextBox.Visibility = Visibility.Hidden;
                OtherTextBox.Clear();
            }
        }

        
    }
 }

