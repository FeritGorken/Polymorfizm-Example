using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Polymorfizm
{
    class Giyim:Urun
    {
        public int kalite { get; set; }

        public override void Yazdir()
        {
            base.Yazdir();
            Console.WriteLine("{0}", kalite);
        }
    }
}
