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
    /// uyeduzenle.xaml etkileşim mantığı
    /// </summary>
    public partial class uyeduzenle : Window
    {
        KutuphaneDBEntities kutuphane = new KutuphaneDBEntities();
        public uyeduzenle()
        {
            InitializeComponent();
            Uyelistele();
        }
        public void Uyelistele()
        {
            dgwUyeler.ItemsSource = kutuphane.uyeler.ToList();
        }

        private void dgwUyeler_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid data = (DataGrid)sender;
            if (data.SelectedItem != null)
            {
                var selectedRow = (uyeler)data.SelectedItem;
                txt_ID.Text = selectedRow.uyeID.ToString();
                txt_uyetc.Text = selectedRow.uyeTC.ToString();
                txt_uyeadi.Text = selectedRow.uyeADİ.ToString();
                txt_uyesoyadi.Text = selectedRow.uyeSOYADİ.ToString();
                txt_uyetelno.Text = selectedRow.uyeTELNO.ToString();
                txt_uyemail.Text = selectedRow.uyeMAİL.ToString();
            }
        }
        private void btn_uyeekle_Click(object sender, RoutedEventArgs e)
        {
            uyeler uye = new uyeler();
            int uyeTC;
            if (int.TryParse(txt_uyetc.Text, out uyeTC))
            {
                uye.uyeTC = uyeTC;
            }
            uye.uyeADİ = txt_uyeadi.Text;
            uye.uyeSOYADİ = txt_uyesoyadi.Text;
            int uyeTelNo;
            if (int.TryParse(txt_uyetelno.Text, out uyeTelNo))
            {
                uye.uyeTELNO = uyeTelNo;
            }
            uye.uyeMAİL = txt_uyemail.Text;
            kutuphane.uyeler.Add(uye);
            kutuphane.SaveChanges();
            MessageBox.Show("Üye Bilgileri Kaydedildi");
            Uyelistele();

        }

        private void btn_Uyesil_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txt_ID.Text);
            using (var db = new KutuphaneDBEntities())
            {
                var del = db.uyeler.FirstOrDefault(k => k.uyeID == id);
                if (del != null)
                {
                    db.uyeler.Remove(del);
                    db.SaveChanges();
                    MessageBox.Show("Üye Bilgileri Silindi");
                    Uyelistele();
                }
            }
        }

        private void btn_guncelle_Click(object sender, RoutedEventArgs e)
        {
            int id;
            if (int.TryParse(txt_ID.Text, out id))
            {
                var upd = kutuphane.uyeler.Where(x => x.uyeID == id).FirstOrDefault();
                if (upd != null)
                {
                    int uyeTC;
                    if (int.TryParse(txt_uyetc.Text, out uyeTC))
                    {
                        upd.uyeTC = uyeTC;
                    }
                    upd.uyeADİ = txt_uyeadi.Text;
                    upd.uyeSOYADİ = txt_uyesoyadi.Text;
                    int uyeTelNo;
                    if (int.TryParse(txt_uyetelno.Text, out uyeTelNo))
                    {
                        upd.uyeTELNO = uyeTelNo;
                    }
                    upd.uyeMAİL = txt_uyemail.Text;
                    kutuphane.SaveChanges();
                    MessageBox.Show("Uye Bilgileri Güncellendi");
                    Uyelistele();

                }
            }
        }
    }
}
