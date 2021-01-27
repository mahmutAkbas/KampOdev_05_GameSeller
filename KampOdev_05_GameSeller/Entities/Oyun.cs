using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev_05_GameSeller.Entities
{
  public  class Oyun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public double Fiyat { get; set; }
    }
}
