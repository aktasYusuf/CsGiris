using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{

    //MİRAS = "INHERITANCE" TUZEL MÜŞTERİYE MÜŞTERİ DEME OLAYIDIR.   Müşteride olan her şey tüzel müşteride de var demektir.
    class TuzelMusteri:Musteri
    { 
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
