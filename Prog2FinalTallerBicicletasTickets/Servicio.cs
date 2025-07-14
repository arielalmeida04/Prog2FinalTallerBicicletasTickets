using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalTallerBicicletasTickets
{
    internal abstract class Servicio:IComparable<Servicio>
    {
        public int NroCod {  get; set; }
        protected string descripcion;
        protected double precioBase;

        public abstract string TareaRealizada();
        public abstract double Precio();

        public int CompareTo(Servicio other)
        {
           return this.NroCod.CompareTo(other.NroCod);
        }
    }
}
