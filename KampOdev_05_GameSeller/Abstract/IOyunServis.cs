using KampOdev_05_GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev_05_GameSeller.Abstract
{
  public  interface IOyunServis
    {
        void Satis(Oyun oyun);
        void KampanyaliOyun(Oyun oyun,Kampanya kapmanya);
    }
}
