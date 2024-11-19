using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikafy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Sanatcı> Sanatcılar = new List<Sanatcı>()
            {
                new Sanatcı {Ad="Ajda",Soyad="Pekkan",Tür="Pop",Yıl=1968,Adet=20},
                  new Sanatcı {Ad="Sezen",Soyad="Aksu",Tür="Türk Halk Müziği",Yıl=1971,Adet=10},
                    new Sanatcı {Ad="Funda",Soyad="Arar",Tür="Pop",Yıl=1999,Adet=3},
                      new Sanatcı {Ad="Sertap",Soyad="Eraner",Tür="Pop",Yıl=1994,Adet=5},
                        new Sanatcı {Ad="Sıla",Soyad="Kural",Tür="Pop",Yıl=2009,Adet=3},
                          new Sanatcı {Ad="Serdar",Soyad="ortaç",Tür="Pop",Yıl=1994,Adet=10},
                            new Sanatcı {Ad="Tarkan",Soyad="Tevetoğlu",Tür="Pop",Yıl=1992,Adet=40},
                              new Sanatcı {Ad="Hadise",Soyad="Boz",Tür="Pop",Yıl=2005,Adet=10},

            };



            Console.WriteLine("Tüm sanatcılar :"); 

            var tüm = Sanatcılar;
            foreach(var t in tüm)
            {
                Console.WriteLine("{0} {1} Tür : {2} Yıl : {3} Adet : {4} Milyon",t.Ad,t.Soyad,t.Tür,t.Yıl,t.Adet);
                Console.WriteLine();
            }



            Console.WriteLine();

            //S ile başlayanları bulma
            var HarfS = Sanatcılar.Where(s => s.Ad.StartsWith("S"));
            Console.WriteLine("S ile başlayan sanatcılar");
            foreach (var s in HarfS)
            {
                Console.WriteLine("{0} {1}", s.Ad, s.Soyad);
            }

            Console.WriteLine();

            //Albümü 10 milyon uzerinde satış yapanlar
            var Satıs = Sanatcılar.Where(a => a.Adet > 10);
            Console.WriteLine("10 milyonun uzerinde Albüm satan sanatçılar");
            foreach (var a in Satıs)
            {
                Console.WriteLine("{0} {1} - {2} : {3} Milyon ", a.Ad, a.Soyad, a.Tür, a.Adet);
            }


            Console.WriteLine();


            //Albümü en çok satan sanatcı
            var ÇokSatan = Sanatcılar.OrderByDescending(En => En.Adet).First();
            Console.WriteLine("Albümü en çok satan sanatcı");
            Console.WriteLine("{0} {1} - {2} Milyon", ÇokSatan.Ad, ÇokSatan.Soyad, ÇokSatan.Adet);


            Console.WriteLine();

            //Pop yapan ve 2000 yılından eski ve Pop yapan sanastcılar
            Console.WriteLine("2000 yılından eski ve pop yapan sanatçılar : ");
            var yıl = Sanatcılar.Where(y => y.Yıl < 2000 && y.Tür == "Pop" );
            foreach(var y in yıl)
            {
                Console.WriteLine("{0} {1} yıl : {2} tür : {3}",y.Ad,y.Soyad,y.Yıl,y.Tür);
            }


            //En eski ve yeni çıkış yapanlar

            var Yeni=Sanatcılar.OrderByDescending(e => e.Yıl).First();
            var Eski = Sanatcılar.OrderBy(E => E.Yıl).First();
            Console.WriteLine();
            Console.WriteLine("En yeni çıkış yapan sanatçı : {0} {1} yıl : {2}",Yeni.Ad,Yeni.Soyad,Yeni.Yıl);
            Console.WriteLine();
            Console.WriteLine("En eski çıkış yapan sanatçı : {0} {1} yıl : {2}", Eski.Ad, Eski.Soyad, Eski.Yıl);




            Console.ReadLine();
        }
    }
}
