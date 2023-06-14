using System;
using System.Collections.Generic;
using System.Data;
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
    /// kitapduzenle.xaml etkileşim mantığı
    /// </summary>
    public partial class kitapduzenle : Window
    {
        KutuphaneDBEntities kutuphane = new KutuphaneDBEntities();
        public kitapduzenle()
        {
            InitializeComponent();
            kitaplistele();
        }

        public void kitaplistele()
        {
            dgwKitaplar.ItemsSource = kutuphane.Kitaplar.ToList();
        }
        public void Temizle()
        {
            txt_adi.Text = txt_kitapturu.Text = txt_rafnumara.Text = txt_yayinevi.Text = txt_yazaradi.Text = "";
        }


        private void dgwKitaplar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid data = (DataGrid)sender;
            if (data.SelectedItem != null)
            {
                var selectedRow = (Kitaplar)data.SelectedItem;
                txt_ID.Text = selectedRow.kitapID.ToString();
                txt_adi.Text = selectedRow.kitapAdi.ToString();
                txt_yazaradi.Text = selectedRow.kitapYazari.ToString();
                txt_kitapturu.Text = selectedRow.kitapTuru.ToString();
                txt_yayinevi.Text = selectedRow.yayinEvi.ToString();
                txt_rafnumara.Text = selectedRow.rafNumara.ToString();
            }
        }

        private void btn_Ekle_Click(object sender, RoutedEventArgs e)
        {
            Kitaplar kitap= new Kitaplar();
            kitap.kitapAdi = txt_adi.Text;
            kitap.kitapYazari = txt_yazaradi.Text;
            kitap.kitapTuru = txt_kitapturu.Text;
            kitap.yayinEvi = txt_yayinevi.Text;
            int rafNumara;
            if (int.TryParse(txt_rafnumara.Text, out rafNumara))
            {
                kitap.rafNumara = rafNumara;
            }
            kutuphane.Kitaplar.Add(kitap);
            kutuphane.SaveChanges();
            MessageBox.Show("Kitap Bilgileri Kaydedildi");
            kitaplistele();
            Temizle();
        }

        private void btn_Sil_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txt_ID.Text);
            using (var db= new KutuphaneDBEntities())
            {
                var del = db.Kitaplar.FirstOrDefault(k => k.kitapID == id);
                if(del != null)
                {
                    db.Kitaplar.Remove(del);
                    db.SaveChanges();
                    MessageBox.Show("Kitap Bilgileri Silindi");
                    kitaplistele();
                    Temizle();
                }

            

            }
        }

        private void btn_guncelle_Click(object sender, RoutedEventArgs e)
        {
            int id;
            if (int.TryParse(txt_ID.Text, out id))
            {
                var upd = kutuphane.Kitaplar.Where(x => x.kitapID == id).FirstOrDefault();
                if (upd != null)
                {
                    upd.kitapAdi = txt_adi.Text;
                    upd.kitapYazari = txt_yazaradi.Text;
                    upd.kitapTuru = txt_kitapturu.Text;
                    upd.yayinEvi = txt_yayinevi.Text;

                    int rafNumara;
                    if (int.TryParse(txt_rafnumara.Text, out rafNumara))
                    {
                        upd.rafNumara = rafNumara;
                    }

                    kutuphane.SaveChanges();
                    MessageBox.Show("Kitap Bilgileri Güncellendi");
                    kitaplistele();
                    
                }
                else
                {
                    MessageBox.Show("Güncellenecek kitap bulunamadı");
                }
            }
        }
    }
}
