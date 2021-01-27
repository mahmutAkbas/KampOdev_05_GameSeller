using KampOdev_05_GameSeller.Abstract;
using KampOdev_05_GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev_05_GameSeller.Concrete
{
    public class OyuncuYonetimi :OyuncuKontrol, IGenelServis<Oyuncu>
    {
        List<Oyuncu> oyuncular = new List<Oyuncu>();
        public void Guncelle(Oyuncu item, Oyuncu oldItem)
        {
            foreach (var oyuncu in oyuncular)
            {
                if (oldItem == oyuncu)
                {
                    oyuncular.Remove(oldItem);
                    oyuncular.Add(item);
                }
                else
                {
                    Console.WriteLine("Kayit Bulunamadi");
                }
            }
        }
        private IOyuncuKontrol _oyuncuKontrol;
        public OyuncuYonetimi(IOyuncuKontrol oyuncuKontrol)
        {
            _oyuncuKontrol = oyuncuKontrol;
        }
        
        public void Kaydet(Oyuncu item)
        {
            if (_oyuncuKontrol.Kontrol(item) == true)
            {
                oyuncular.Add(item);
            }
            else
            {
                Console.WriteLine("Lütfen bilgilerinizi kontrol ediniz.");
            }
        }

        public List<Oyuncu> Listele()
        {
            return oyuncular;
        }

        public void Sil(Oyuncu item)
        {
            foreach (var oyuncu in oyuncular)
            {
                if (item == oyuncu)
                {
                    oyuncular.Remove(item);
                }
                else
                {
                    Console.WriteLine("Kayit Bulunamadi");
                }
            }
        }
    }
}
