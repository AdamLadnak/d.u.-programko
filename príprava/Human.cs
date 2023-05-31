using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.jun_príprava
{
    internal class Human
    {
        private string meno;
        private string priezvisko;
        private string rok_narodenia;
        private string robota;
        public Human(string meno, string priezvisko, string rok_narodenia, string robota)
        {
            Meno = meno;
            Priezvisko = priezvisko;
            Rok_narodenia = rok_narodenia;
            Robota = robota;
        }

        public string Meno { get => meno; set => meno = value; }
        public string Priezvisko { get => priezvisko; set => priezvisko = value; }
        public string Rok_narodenia { get => rok_narodenia; set => rok_narodenia = value; }
        public string Robota { get => robota; set => robota = value; }
    }
}
