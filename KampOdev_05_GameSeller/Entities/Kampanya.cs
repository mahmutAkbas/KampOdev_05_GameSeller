using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev_05_GameSeller.Entities
{
   public class Kampanya
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double IndirimYuzdesi { get; set; }
        public DateTime GecerlilikSuresi { get; set; }
    }
}
