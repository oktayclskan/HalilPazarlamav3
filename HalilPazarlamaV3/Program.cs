using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlamaV3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ürünler ve Reyonlar

            Buzdolabi b1 = new Buzdolabi();
            b1.UrunTipi = "Buzdolabı";
            b1.Marka = "BOSCH";
            b1.Model = "KDN86AIE0N";
            b1.EnerjiTipi = "E";
            b1.SogutmaTipi = "No-Frost";
            b1.HızlıSogutma = "Yok";
            b1.Hacim = "158 L";
            b1.Fiyat = 23499;

            Buzdolabi b2 = new Buzdolabi();
            b2.UrunTipi = "Buzdolabı";
            b2.Marka = "SAMSUNG";
            b2.Model = "RB50RS334SA/TR";
            b2.EnerjiTipi = "F";
            b2.SogutmaTipi = "No-Frost";
            b2.HızlıSogutma = "Var";
            b2.Hacim = "120 L";
            b2.Fiyat = 16999;

            Buzdolabi b3 = new Buzdolabi();
            b3.UrunTipi = "Buzdolabı";
            b3.Marka = "LG";
            b3.Model = "GR-H802HlH";
            b3.EnerjiTipi = "B";
            b3.SogutmaTipi = "No-Frost";
            b3.HızlıSogutma = "var";
            b3.Hacim = "590 L";
            b3.Fiyat = 21999;

            CamasirMakinesi c1 = new CamasirMakinesi();
            c1.UrunTipi = "Çamaşır Makinesi";
            c1.Marka = "BOSCH";
            c1.YıkamaKapasitesi = "8 KG ";
            c1.EnerjiSinifi = "B";
            c1.YuklemeTipi = "Önden Yüklemeli";
            c1.KontrolTipi = "Mekanik+Elektronik";
            c1.ProgramSayisi = "6";
            c1.Fiyat = 8999;

            CamasirMakinesi c2 = new CamasirMakinesi();
            c2.UrunTipi = "Çamaşır Makinesi";
            c2.Marka = "GRUNDIG";
            c2.Model = "GWM 81013 S";
            c2.YıkamaKapasitesi = "9 KG ";
            c2.EnerjiSinifi = "C";
            c2.YuklemeTipi = "Önden Yüklemeli";
            c2.KontrolTipi = "Mekanik+Elektronik";
            c2.ProgramSayisi = "15";
            c2.Fiyat = 9650;

            CamasirMakinesi c3 = new CamasirMakinesi();
            c3.UrunTipi = "Çamaşır Makinesi";
            c3.Marka = "BOSCH";
            c3.Model = " WGA252X0TR";
            c3.YıkamaKapasitesi = "10 KG ";
            c3.EnerjiSinifi = "A";
            c3.YuklemeTipi = "Önden Yüklemeli";
            c3.KontrolTipi = "Mekanik+Elektronik";
            c3.ProgramSayisi = "10+";
            c3.Fiyat = 11999;

            BulasikMakinesi bm1 = new BulasikMakinesi();
            bm1.UrunTipi = "Bulaşık Makinesi";
            bm1.Marka = "BOSCH";
            bm1.Model = "SMS4IMI60T";
            bm1.ProgramSayisi = "6";
            bm1.UzaktanKontrol = "Var";
            bm1.Boyutlar = "600 mm x 845 mm x 600 mm";
            bm1.Fiyat = 10999;

            BulasikMakinesi bm2 = new BulasikMakinesi();
            bm2.UrunTipi = "Bulaşık Makinesi";
            bm2.Marka = "VESTEL";
            bm2.Model = "BM 4202 X";
            bm2.ProgramSayisi = "4";
            bm2.UzaktanKontrol = "Yok";
            bm2.Boyutlar = "59.8 cm x 85 cm x 59.8 cm";
            bm2.Fiyat = 6999;


            BulasikMakinesi bm3 = new BulasikMakinesi();
            bm3.UrunTipi = "Bulaşık Makinesi";
            bm3.Marka = "ALTUS";
            bm3.Model = "AL 404 MP";
            bm3.ProgramSayisi = "4";
            bm3.UzaktanKontrol = "Yok";
            bm3.Boyutlar = "59.8 cm x 85 cm x 59.8 cm";
            bm3.Fiyat = 5099;

            Reyon r1 = new Reyon();
            r1.Tür = "BULAŞIK MAKİNELERİ REYONU";
            Reyon r2 = new Reyon();
            r2.Tür = "ÇAMAŞIR MAKİNELERİ REYONU";
            Reyon r3 = new Reyon();
            r3.Tür = "BUZDOLAPLARI REYONU";
            Reyon r4 = new Reyon();
            r4.Tür = "TÜMÜNÜ YAZDIR";
            #endregion
            #region Dizi oluştur


            List<Buzdolabi> buzdolabları = new List<Buzdolabi>();
            List<CamasirMakinesi> camasirmakinleri = new List<CamasirMakinesi>();
            List<BulasikMakinesi> bulasikmakineleri = new List<BulasikMakinesi>();
            List<Reyon> reyonlar = new List<Reyon>();
            #endregion
            #region Ekle


            buzdolabları.Add(b1);
            buzdolabları.Add(b2);
            buzdolabları.Add(b3);

            camasirmakinleri.Add(c1);
            camasirmakinleri.Add(c2);
            camasirmakinleri.Add(c3);

            bulasikmakineleri.Add(bm1);
            bulasikmakineleri.Add(bm2);
            bulasikmakineleri.Add(bm3);

            reyonlar.Add(r1);
            reyonlar.Add(r2);
            reyonlar.Add(r3);
            reyonlar.Add(r4);
            #endregion
            double toplam = 0;
            string devammı = "e";
            while (devammı == "e")
            {
                
                Console.WriteLine("                       LÜTFEN REYON SEÇİNİZ");
                Console.WriteLine("  ");
                for (int i = 0; i < reyonlar.Count; i++)
                {
                    Console.WriteLine((i + 1) + ".) " + reyonlar[i].Tür);
                    Console.WriteLine(" ");
                }
                int rno = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                #region reyonları yazdır ve tümünü yazdır
                if (rno == 1)
                {
                    for (int i = 0; i < bulasikmakineleri.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ".)" + bulasikmakineleri[i].Yazdır());
                        Console.WriteLine("****************************");


                    }
                    Console.WriteLine("ALMAK İSTEDİĞİNİZ ÜRÜN NUMARASINI YAZINIZ");
                    int urnno = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < bulasikmakineleri.Count; i++)
                    {
                        if (urnno == i + 1)
                        {
                            
                            Console.WriteLine("ÜRÜN FİYATI = " + bulasikmakineleri[i].Fiyat);
                            toplam = bulasikmakineleri[i].Fiyat + toplam;
                            Console.WriteLine("GENEL TOPLAM=  " + toplam);
                        }
                    }
                }
                if (rno == 2)
                {
                    for (int i = 0; i < camasirmakinleri.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ".)" + camasirmakinleri[i].Yazdır());
                        Console.WriteLine("****************************");
                    }
                    Console.WriteLine("ALMAK İSTEDİĞİNİZ ÜRÜN NUMARASINI YAZINIZ");
                    int urnno = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < camasirmakinleri.Count; i++)
                    {
                        if (urnno == i + 1)
                        {
                            Console.WriteLine("ÜRÜN FİYATI = " + camasirmakinleri[i].Fiyat);
                            toplam = camasirmakinleri[i].Fiyat + toplam;
                            Console.WriteLine("GENEL TOPLAM=  " + toplam);
                        }
                    }
                }
                if (rno == 3)
                {
                    for (int i = 0; i < buzdolabları.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ".)" + buzdolabları[i].Yazdır());
                        Console.WriteLine("****************************");
                    }
                    Console.WriteLine("ALMAK İSTEDİĞİNİZ ÜRÜN NUMARASINI YAZINIZ");
                    int urnno = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < buzdolabları.Count; i++)
                    {
                        if (urnno == i + 1)
                        {
                            Console.WriteLine("ÜRÜN FİYATI = " + buzdolabları[i].Fiyat);
                            toplam = buzdolabları[i].Fiyat + toplam;
                            Console.WriteLine("GENEL TOPLAM= " + toplam);
                        }
                    }

                }
                if (rno == 4)
                {
                    for (int i = 0; i < camasirmakinleri.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ".)" + camasirmakinleri[i].Yazdır());
                        Console.WriteLine("**************************************");
                    }
                    for (int i = 0; i < bulasikmakineleri.Count; i++)
                    {
                        Console.WriteLine((camasirmakinleri.Count + i + 1) + ".)" + bulasikmakineleri[i].Yazdır());
                        Console.WriteLine("**************************************");
                    }
                    for (int i = 0; i < buzdolabları.Count; i++)
                    {
                        Console.WriteLine((camasirmakinleri.Count + bulasikmakineleri.Count + i + 1) + ".)" + buzdolabları[i].Yazdır());
                        Console.WriteLine("**************************************");

                    }
                    
                    #endregion
                    Console.WriteLine("ALMAK İSTEDİĞİNİZ ÜRÜN NUMARASINI YAZINIZ");
                    int urnno = Convert.ToInt32(Console.ReadLine());

                    if (urnno <=camasirmakinleri.Count)
                    {
                        
                        for (int i = 0; i < camasirmakinleri.Count; i++)
                        {
                            if (urnno == i + 1)
                            {
                                Console.WriteLine("ÜRÜN FİYATI = " + camasirmakinleri[i].Fiyat);
                                toplam = camasirmakinleri[i].Fiyat + toplam;
                                Console.WriteLine("GENEL TOPLAM=  " + toplam);
                            }
                        }

                    }
                    else if (urnno>camasirmakinleri.Count && urnno<=camasirmakinleri.Count+bulasikmakineleri.Count)
                    {
                        for (int i = 0; i < bulasikmakineleri.Count; i++)
                        {
                            if (urnno == camasirmakinleri.Count+  i + 1)
                            {

                                Console.WriteLine("ÜRÜN FİYATI = " + bulasikmakineleri[i].Fiyat);
                                toplam = bulasikmakineleri[i].Fiyat + toplam;
                                Console.WriteLine("GENEL TOPLAM=  " + toplam);
                            }
                        }
                    }
                    else if (urnno> camasirmakinleri.Count + bulasikmakineleri.Count)
                    {
                        for (int i = 0; i < buzdolabları.Count; i++)
                        {
                            if (urnno == camasirmakinleri.Count+bulasikmakineleri.Count+ i + 1)
                            {
                                Console.WriteLine("ÜRÜN FİYATI = " + buzdolabları[i].Fiyat);
                                toplam = buzdolabları[i].Fiyat + toplam;
                                Console.WriteLine("GENEL TOPLAM= " + toplam);
                            }
                        }
                    }
                    
                }
                
                Console.WriteLine("ALİŞVERİŞE DEVAM EDİLSİNMİ ? E/H");
                devammı = Console.ReadLine();
                Console.Clear();
            }
            if (devammı == "h")
            {
                Console.WriteLine("Genel toplam = " + toplam);
            }
        }
    }
    
}
