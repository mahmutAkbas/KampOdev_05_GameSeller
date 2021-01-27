using KampOdev_05_GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev_05_GameSeller.Concrete
{
   public class SatisYonetimi
    {
        public void Ekle(Satis satis)
        {
            Console.WriteLine("{0} adlı musteri {1} oyununu {2} fitaya satın aldı ",satis._Oyuncu.Adi+" "+satis._Oyuncu.Soyadi,satis._OyunKampanya._Oyun.Adi,satis._OyunKampanya.IndirimliFiyat);
        }
        
    }
}
