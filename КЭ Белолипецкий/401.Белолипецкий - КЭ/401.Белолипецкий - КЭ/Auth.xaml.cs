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
using System.Windows.Shapes;

namespace _401.Белолипецкий___КЭ
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btn_ent_Click(object sender, RoutedEventArgs e)
        {
            CatalogAdm adm = new CatalogAdm();

            if (tb_login.Text == "логин" && tb_password.Text == "пароль")
            {
                adm.Show();
                this.Close();
            }
            else MessageBox.Show("Неверно введён логин или пароль", "Неверно введённые данные", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}
