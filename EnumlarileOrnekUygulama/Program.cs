using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlarileOrnekUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri(1,"Enes","Bayram","Erkek","enes.bayram@gmail.com");

           MusteriDurum donenDurum = musteri.musteriEkle(musteri);

            if(donenDurum == MusteriDurum.kayitBasarili)
            {
                Console.WriteLine("Müşteri başarılı bir şekilde eklenmiştir.");
            }

            Console.ReadLine();
        }
    }
}
