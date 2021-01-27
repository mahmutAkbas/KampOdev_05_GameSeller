using System;
using System.Collections.Generic;
using System.Text;

namespace KampOdev_05_GameSeller.Abstract
{
   public interface IGenelServis<T>
    {
        void Kaydet(T item);
        void Guncelle(T item,T oldItem);
        void Sil(T item);
        List<T> Listele();
    }
}
