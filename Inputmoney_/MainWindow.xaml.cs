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

namespace Inputmoney_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            
            db = new ApplicationContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string User = "Maria";
            User us = new User();
            int money = Convert.ToInt32(Money.Text);
            us.name = User;
            us.money = money;
            MessageBox.Show("Деньги успешно добавлены");
            db.User.Add(us);
            db.SaveChanges();

        }
    }
}
