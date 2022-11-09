using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaIobjektiPonavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(false);
            Stablo stablo2 = new Stablo(true);

            Console.WriteLine("Stablo 1");
            Console.WriteLine(stablo1.ToString());
            Console.WriteLine("\r\nStablo 2");
            Console.WriteLine(stablo2.ToString());
            Console.ReadKey();
        }
        class Stablo
        {
            private bool otpadajuListovi;
            private string vrstaStabla;

            public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
            public string VrstaStabla { get => vrstaStabla; set => vrstaStabla = value; }

            public override string ToString()
            {
                string otpis = "Vrsta Stabla je " + VrstaStabla + ".";
                return otpis;
            }
            public Stablo(bool otpadajulistovi) 
            {
                this.OtpadajuListovi = otpadajulistovi;
                if (this.OtpadajuListovi)
                {
                    this.VrstaStabla = "bijelogorično";
                }
                else
                {
                    this.VrstaStabla = "crnogorično";
                }
            }
        }
    }
}
