using KampOdev_05_GameSeller.Abstract;
using KampOdev_05_GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev_05_GameSeller.Concrete
{
    public class KapmanyaYonetimi : IGenelServis<Kampanya>
    {
        List<Kampanya> kampanyalar = new List<Kampanya>();
        public void Guncelle(Kampanya item, Kampanya oldItem)
        {
            foreach (var kampanya in kampanyalar)
            {
                if (kampanya == oldItem)
                {
                    kampanyalar.Remove(oldItem);
                    kampanyalar.Add(item);
                    Console.WriteLine("Kapmyanya başarıyla güncellendi");
                }
                else
                {
                    Console.WriteLine("Kampanya bulunamadı");
                }
            }
        }

        public void Kaydet(Kampanya item)
        {
            kampanyalar.Add(item);
        }

        public List<Kampanya> Listele()
        {
            return kampanyalar;
        }

        public void Sil(Kampanya item)
        {
            foreach (var kampanya in kampanyalar)
            {
                if (kampanya == item)
                {
                    kampanyalar.Remove(item);
                    Console.WriteLine("Kapmyanya başarıyla silindi");
                }
                else
                {
                    Console.WriteLine("Kampanya bulunamadı");
                }
            }
        }
        
    
    }
}
