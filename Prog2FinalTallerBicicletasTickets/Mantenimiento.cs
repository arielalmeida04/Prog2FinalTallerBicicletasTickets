using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalTallerBicicletasTickets
{
    [Serializable]
    internal class Mantenimiento : Servicio
    {
        double extra;

        public Mantenimiento(int cod, string descripcion, double precioB) 
        { 
            this.NroCod = cod;
            this.descripcion=descripcion;
            precioBase= precioB;
        }

        public double PorcentajeExtra(double extra)
        {
            return precioBase*(extra / 100);
        }
        public override double Precio()
        {
            return precioBase + PorcentajeExtra(extra);
        }

        public override string TareaRealizada()
        {
            return NroCod+" "+descripcion + " " +precioBase;
        }

        public override string ToString()
        {
            return NroCod + " " + descripcion + " " + precioBase;
        }
    }
}
