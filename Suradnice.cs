using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredPisomkou
{
    public class Suradnice
    {
        /*
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        */

        public string X { get; private set; }
        public string Y { get; private set; }

        public Suradnice(string x, string y) 
        { 
            this.X = x; 
            this.Y = y;
        }
    }
}
