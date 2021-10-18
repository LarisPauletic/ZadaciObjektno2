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
        public Zrakoplov(string s, double d, int i) 
        { 
            Naziv = s; 
            SnagaMotora = d; 
            DosegLeta = i; 
        }
    }
}

