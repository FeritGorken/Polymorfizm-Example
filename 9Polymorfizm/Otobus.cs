using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Polymorfizm
{
    class Otobus:Urun
    {
        public int teker { get; set; }

        public override void Deger()
        {
            Console.WriteLine("Fonksiyon");
        }

        public override void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine("{0}", teker);
        }
    }
}
