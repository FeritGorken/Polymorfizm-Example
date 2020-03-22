using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Polymorfizm
{
    abstract class Urun
    {
        public int yil { get; set; }
        public int sinif { get; set; }

        public virtual void Yazdir()
        {
            Console.WriteLine("{0} {1}", yil,sinif);
        }
        public abstract void Deger();
    }
}
