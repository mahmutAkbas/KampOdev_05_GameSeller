using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev_05_GameSeller.Entities
{
  public  class Oyuncu
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Tc { get; set; }
    }
}
