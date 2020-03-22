using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Polymorfizm
{
    class Telefon:Urun,Kablo
    {
        public int model { get; set; }

        public void Fonksiyon()
        {
            Console.WriteLine("Fonksiyon");
        }

        public override void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine("{0}", model);
        }
    }
}
