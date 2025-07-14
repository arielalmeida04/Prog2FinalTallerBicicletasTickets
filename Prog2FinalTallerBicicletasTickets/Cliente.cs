using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalTallerBicicletasTickets
{
    internal class Cliente
    {
        long cuit { get; set; }
        string nombre {  get; set; }
        
        public Cliente(long cuit,string nombre)
        {
            this.cuit = cuit;
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return cuit + " " + nombre;
        }
    
    }
}
