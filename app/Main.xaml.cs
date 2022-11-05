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

namespace app
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            MainGrid.ItemsSource = PracticeEntities.GetContext().products_users.ToList();
            //MainFrame.Navigate(new Add());
            //Manager.MainFrame = MainFrame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Add());
            MainGrid.Visibility = Visibility.Hidden;
            Panel.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var productsForRemoving = MainGrid.SelectedItems.Cast<products_users>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {productsForRemoving.Count()} элементов?",
                "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    PracticeEntities.GetContext().products_users.RemoveRange(productsForRemoving);
                    //PracticeEntities.GetContext().products.RemoveRange();
                    PracticeEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //if (Visibility == Visibility.Visible)
            //{
            //    PracticeEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            //    MainGrid.ItemsSource = PracticeEntities.GetContext().products_users.ToList();
            //}
            //MainGrid.Visibility = Visibility.Visible;
            //Panel.Visibility = Visibility.Visible;
        }
    }
}
