using KampOdev_05_GameSeller.Abstract;
using KampOdev_05_GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev_05_GameSeller.Concrete
{
    public class OyunYonetimi : IGenelServis<Oyun>
    {
        List<Oyun> oyunlar = new List<Oyun>();
        public void Guncelle(Oyun item, Oyun oldItem)
        {
            foreach (var oyun in oyunlar)
            {
                if (oyun == oldItem)
                {
                    oyunlar.Remove(oldItem);
                    oyunlar.Add(item);
                    Console.WriteLine("Oyun başarıyla güncellendi");
                }
                else
                {
                    Console.WriteLine("Oyun bulunamadı");
                }
            }
        }

        public void Kaydet(Oyun item)
        {
            oyunlar.Add(item);
        }

        public List<Oyun> Listele()
        {
            return oyunlar;
        }

        public void Sil(Oyun item)
        {
            foreach (var oyun in oyunlar)
            {
                if (oyun == item)
                {
                    oyunlar.Remove(item);
                    Console.WriteLine("Oyun başarıyla silindi");
                }
                else
                {
                    Console.WriteLine("Oyun bulunamadı");
                }
            }
        }
    }
}
