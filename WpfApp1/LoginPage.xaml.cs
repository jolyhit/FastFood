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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        readonly DataBase.FastFoodEntities connect1 = new DataBase.FastFoodEntities();
        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
            string empPhone = TextLogin.Text;
            string empPassword = TextPassword.Text;
            if (empPhone.Length == 0 || empPassword.Length == 0)
            {
                MessageBox.Show("Введите все данные!");
                return;
            }
            var users = connect1.Employee.Where(p => p.Phone == empPhone && p.Password == empPassword).FirstOrDefault();
            if (users != null)
                MainFrame.Navigate(new MainPage());
            else
                MessageBox.Show("Данные введены неправильно!");

        }
    }
}
