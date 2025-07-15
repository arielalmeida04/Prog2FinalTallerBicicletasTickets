using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalTallerBicicletasTickets
{
    [Serializable]
    internal class Reparacion : Servicio
    {
        public double PrecioRepuesto {  get; set; }
        public int TiempoHoras {  get; set; }

        public Reparacion(int cod,string descp, double precioB,double precioR)
        {
            this.NroCod = cod;
            this.descripcion = descp;
            precioBase = precioB;
            PrecioRepuesto=precioR;
        }

        public override double Precio()
        {
            return precioBase * TiempoHoras + PrecioRepuesto;
        }

        public override string TareaRealizada()
        {
            return descripcion + " " + NroCod + " " + precioBase + " " +PrecioRepuesto;
        }

        public override string ToString()
        {
            return descripcion + " " + NroCod + " " + precioBase + " " + PrecioRepuesto;
        }
    }
}
