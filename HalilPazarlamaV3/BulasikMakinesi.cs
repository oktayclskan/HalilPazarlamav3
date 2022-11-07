using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamaV3
{
    class BulasikMakinesi
    {
        public string UrunTipi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string ProgramSayisi { get; set; }
        public string UzaktanKontrol { get; set; }
        public string Boyutlar { get; set; }
        public double Fiyat { get; set; }
        public string Yazdır()
        {
            return $"Ürün= {UrunTipi}\n Marka= {Marka}\n Model= {Model}\n Program Sayısı= {ProgramSayisi}\n Uzaktan Kontrol={UzaktanKontrol}\n Boyutları= {Boyutlar}\n Fiyat= {Fiyat}";
        }
    }
}
