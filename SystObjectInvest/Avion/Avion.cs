using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystObjectInvest.Avion
{
    public abstract class Avion
    {
        public string Piloto { get; set; }
        public string Azafata { get; set; }
        public string Copiloto { get; set; }


        public Avion(string piloto, string azafata, string copiloto)
        {
            Piloto= piloto;
            Azafata= azafata;
            Copiloto= copiloto;
        }

        public abstract string Aterriza();
        public abstract string Despega();
        public override string ToString()
        {
            return $"Piloto: {Piloto}. \nAzafata: {Azafata}. \nCopiloto: {Copiloto}.";
        }

    }
}
