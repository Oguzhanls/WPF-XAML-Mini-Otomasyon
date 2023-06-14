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

namespace wpf_Kutuphane
{
    /// <summary>
    /// Anasayfa.xaml etkileşim mantığı
    /// </summary>
    public partial class Anasayfa : Window
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btn_Kitaplar_Click(object sender, RoutedEventArgs e)
        {
            kitapduzenle kitaplar = new kitapduzenle();
            kitaplar.Show();
            
        }

        private void btn_uyeler_Click(object sender, RoutedEventArgs e)
        {
            uyeduzenle Uyeler = new uyeduzenle();
            Uyeler.Show();
            
        }
    }
}
