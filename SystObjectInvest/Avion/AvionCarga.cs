using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystObjectInvest.Avion
{
    public class AvionCarga: Avion
    {
        public double Peso { get; set; }
        public string TipoMercaderia{ get; set; }

        public AvionCarga(string piloto, string azafata, string copiloto, double peso, string tipoMercaderia) : base(piloto, azafata, copiloto)
        {
            Peso = peso;
            TipoMercaderia = tipoMercaderia;
        }


        public override string Aterriza()
        {
            return "El Avion de Carga ha aterrizado.";
        }

        public override string Despega()
        {
            return "El Avion de Carga ha despegado";
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPeso: {Peso}. \nTipo de Mercaderia: {TipoMercaderia}";
        }
    }
}
