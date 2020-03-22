using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Polymorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Urun> envanter = new List<Urun>();
            Telefon tel = new Telefon();
            tel.yil = 2011;
            tel.sinif = 3;
            tel.model = 2;

            Giyim giy = new Giyim();
            giy.kalite = 2;
            giy.sinif = 1;
            giy.yil = 2030;

            Otobus oto = new Otobus();
            oto.yil = 2020;
            oto.teker = 5;
            oto.sinif = 3;

            envanter.Add(oto);
            envanter.Add(giy);
            envanter.Add(tel);

            foreach (var item in envanter)
            {
                item.Yazdir();

            }
            Console.ReadLine();
        }
    }
}
