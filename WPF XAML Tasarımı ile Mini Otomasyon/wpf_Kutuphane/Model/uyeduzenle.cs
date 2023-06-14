using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_Kutuphane.Model
{
    internal class uyeduzenle
    {
        [Key]
        public int uye_ID { get; set; }
        public int tc_no { get; set; }
        public string uye_adi { get; set;}
        public string uye_soyadi { get; set;}
        public int tel_no { get; set; }
        public string uye_mail { get; set;}

    }
}
