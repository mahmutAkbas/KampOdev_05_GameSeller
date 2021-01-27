using KampOdev_05_GameSeller.Abstract;
using KampOdev_05_GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev_05_GameSeller.Concrete
{
    public  class OyuncuKontrol : IOyuncuKontrol
    {
        public bool Kontrol(Oyuncu oyuncu)
        {
            if (oyuncu.Tc == null && oyuncu.Adi == null && oyuncu.DogumTarihi.Year != 0)
                return true;
            else
                return false;
        }
    }
}
