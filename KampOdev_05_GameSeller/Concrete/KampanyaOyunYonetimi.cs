using KampOdev_05_GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev_05_GameSeller.Concrete
{
    class KampanyaOyunYonetimi
    {
        List<OyunKampanya> oyunKampanyalar = new List<OyunKampanya>();
        public void Ekle(OyunKampanya item)
        {
            double indirim = item._Kampanya.IndirimYuzdesi/100;
            double fiyat = item._Oyun.Fiyat;
            item.IndirimliFiyat = fiyat - fiyat * indirim;
            oyunKampanyalar.Add(item);
        }
        public List<OyunKampanya> OyunKampanyalar()
        {
            return oyunKampanyalar;
        }
        public void GetIndirimliFiyat(OyunKampanya ok)
        {
            Console.WriteLine("{0} kampanya ile {1} oyununa %{2} indirim yapıldı \n Indirimli fiyat : {3}\nIndirimsiz Fiyat : {4}",ok._Kampanya.Adi,ok._Oyun.Adi,ok._Kampanya.IndirimYuzdesi,ok.IndirimliFiyat,ok._Oyun.Fiyat);
        }
    }
}
