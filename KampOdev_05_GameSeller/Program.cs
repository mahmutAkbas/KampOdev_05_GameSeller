using KampOdev_05_GameSeller.Concrete;
using KampOdev_05_GameSeller.Entities;
using System;

namespace KampOdev_05_GameSeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyun oyun = new Oyun { Id = 1, Adi = "Sokak Dövüşü", Fiyat = 55.5, OlusturmaTarihi = new DateTime(2021, 01, 02) };
            OyunYonetimi oyunYonetimi = new OyunYonetimi();
            oyunYonetimi.Kaydet(oyun) ;
            OyuncuYonetimi oyuncuYonetimi = new OyuncuYonetimi(new OyuncuKontrol());
            oyuncuYonetimi.Kaydet(new Oyuncu { Id = 1, Adi = "ökkeş", Soyadi = "yavuz", DogumTarihi = new DateTime(1995, 05, 06), Tc = "12365478966" });
            Kampanya kampanya = new Kampanya { Id = 2, Adi = "Mübarek Cumartesi Kampanyası", GecerlilikSuresi = new DateTime(2021, 02, 27), IndirimYuzdesi = 5 };
            KapmanyaYonetimi kapmanyaYonetimi = new KapmanyaYonetimi();
            kapmanyaYonetimi.Kaydet(kampanya);
            OyunKampanya oyunKampanya = new OyunKampanya { _Kampanya = kampanya, _Oyun = oyun };
            KampanyaOyunYonetimi kampanyaOyunYonetimi = new KampanyaOyunYonetimi();
            kampanyaOyunYonetimi.Ekle(oyunKampanya);
            kampanyaOyunYonetimi.GetIndirimliFiyat(oyunKampanya);
            
              
        }
    }
}
