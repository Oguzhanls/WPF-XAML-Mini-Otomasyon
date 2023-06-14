using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_Kutuphane.Model
{
    public class kitapduzenle
    {
        [Key]
        public int Kitap_ID { get; set; }
        public  string Kitap_adi {get; set; }
        public  string Kitap_yazari { get; set; }
        public  string Kitap_turu { get; set; }
        public  string yayin_evi { get; set; }
        public  int raf_numara { get; set; }



    }
}
