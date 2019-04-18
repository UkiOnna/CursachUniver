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
    public partial class AddPage : Page
    {
        private Window window;
        public string filePath;
        public AddPage(Window window)
        {
            InitializeComponent();
            this.window = window;
            comboBoxType.Items.Add("Книга");
            comboBoxType.Items.Add("Фильм");
            comboBoxType.Items.Add("Сериал");
            comboBoxType.Items.Add("Аниме");
            comboBoxType.Items.Add("Другое...");
            comboBoxIsWatched.Items.Add("Да");
            comboBoxIsWatched.Items.Add("Нет");
            for(int i = 1; i <= 10; i++)
            {
                RateComboBox.Items.Add(i);
            }
            OtherTextBox.Visibility = Visibility.Hidden;
            OtherTextBlock.Visibility = Visibility.Hidden;
            RateComboBox.Visibility = Visibility.Hidden;
            RateText.Visibility = Visibility.Hidden;
            comboBoxType.SelectedItem = "Книга";
            comboBoxIsWatched.SelectedItem = "Нет";
            filePath = "Images/noimage.png";

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

        private void ComboBoxTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBoxType.SelectedItem.ToString()== "Другое...")
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

        private void ComboBoxIsWatchedSelectionChanged(object sender, SelectionChangedEventArgs e)
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
                            CollectionElement element = new CollectionElement();
                            element.CreationDate = DateTime.Now;
                            element.Image = File.ReadAllBytes(filePath);

                            element.Name = nameText.Text;
                            if (comboBoxIsWatched.SelectedItem.ToString() == "Да")
                            {
                                element.IsWatched = true;
                            }
                            else
                            {
                                element.IsWatched = false;
                            }
                            if (LinkText.Text == String.Empty)
                            {
                                element.Link = "-";
                            }
                            else
                            {
                                element.Link = LinkText.Text;
                            }
                            if (RateComboBox.SelectedItem == null)
                            {
                                element.Rate = null;
                            }
                            else
                            {
                                int kek;
                                if (int.TryParse(RateComboBox.SelectedItem.ToString(), out kek))
                                {
                                    element.Rate = kek;
                                }
                            }
                            if (comboBoxType.SelectedItem.ToString() == "Другое...")
                            {
                                element.ElementType = OtherTextBox.Text;
                            }
                            else
                            {
                                element.ElementType = comboBoxType.SelectedItem.ToString();
                            }

                            context.Elements.Add(element);
                            context.SaveChanges();
                        }
                        MessageBox.Show("Добавлено!");
                        window.Content = new MainMenu(window);
                }
            }
        }

        private void BackButtonClick(object sender, RoutedEventArgs e)
        {
            window.Content = new MainMenu(window);
        }
    }
}
