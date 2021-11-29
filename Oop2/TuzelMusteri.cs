using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{//Coorporate
    //inheratance yani miras deniyor.
    //Musteride olan özellikler Tuzel'de de olduğu kabul edilir
    class TuzelMusteri:Musteri
    {
        public string VergiNo { get; set; }
        public string SirketAdi { get; set; }
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        
    }
}
