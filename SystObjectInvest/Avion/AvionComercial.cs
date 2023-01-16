using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystObjectInvest.Avion
{
    public class AvionComercial: Avion
    {

        public int Capacidad { get; set; }
        public string LineaAerea { get; set; }


        public AvionComercial(string piloto, string azafata, string copiloto, int capacidad, string lineaAerea) : base(piloto, azafata, copiloto) 
        {
            Capacidad= capacidad;
            LineaAerea= lineaAerea;
        
        }



        public override string Aterriza()
        {
            return "El Avion Comercial ha aterrizado";
        }

        public override string Despega()
        {
            return "El Avion Comercial ha despegado";
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCapacidad: {Capacidad}. \nLineaAerea: {LineaAerea}";
        }

    }
}
