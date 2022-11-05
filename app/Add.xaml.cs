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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        private products _currentproduct = new products();
        private products_users _currentcount = new products_users();
        int id =1;

        public Add()
        {
            InitializeComponent();
            Combo_category.ItemsSource = Instance.db.category.ToList();
            //this.id = id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products products = new products();
            products_users products_Users = new products_users();
            var category = Combo_category.SelectedItem as category;
            products.fk_ID_category = category.pk_id;
            products_Users.fk_ID_product = products.pk_ID;
            products_Users.Количество = Convert.ToInt32(Count.Text);
            products.Название = Name.Text;
            products.Цена = Convert.ToInt32(Price.Text);
            products_Users.Сумма = products.Цена * products_Users.Количество;
            products_Users.fk_ID_user = id;
            Instance.db.products_users.Add(products_Users);
            Instance.db.products.Add(products);
            Instance.db.SaveChanges();
            Main main = new Main();
            main.Visibility = Visibility;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            main.Visibility = Visibility;   

        }
    }
}
