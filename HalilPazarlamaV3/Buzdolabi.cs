using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamaV3
{
    class Buzdolabi
    {
        public string UrunTipi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string EnerjiTipi { get; set; }
        public string SogutmaTipi { get; set; }
        public string HızlıSogutma { get; set; }
        public string Hacim { get; set; }
        public double Fiyat { get; set; }

        public string Yazdır()
        {
            return $"Ürün Tipi = {UrunTipi}\n Marka = {Marka}\n  Model = {Model}\n  Enerji Tipi = {EnerjiTipi}\n  Soğutma Tipi = {SogutmaTipi}\n  Hızlı Soğutma = {SogutmaTipi}\n  Hacim = {Hacim}\n  Fiyat = {Fiyat}";
        }
    }
}
