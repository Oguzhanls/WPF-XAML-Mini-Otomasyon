using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_Kutuphane.Model
{
    public class girisyap
    {
        [Key]
        public int kullanici_Id { get; set; }
        public string kullanici_adi {get; set; }
        public string sifre { get; set; }

    }
}
