using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciObjektno2
{
    class Zrakoplov
    {
        private string Naziv; 
        private double SnagaMotora; 
        private int DosegLeta; 
        public Zrakoplov(string n, double s, int d) 
        { 
            Naziv = n; 
            SnagaMotora = s; 
            DosegLeta = d; 
        }
    }
}

