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

namespace wpf_Kutuphane
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            KutuphaneDBEntities kutuphane = new KutuphaneDBEntities();

            string usr = txt_Username.Text;
            string pw = txt_password.Password.ToString();

            bool bul = kutuphane.login.Any(users => users.users_name == usr && users.password == pw);
            if (bul)
            {
                Anasayfa ana = new Anasayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
        }

       
    }
}
