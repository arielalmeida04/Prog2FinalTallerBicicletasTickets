using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Prog2FinalTallerBicicletasTickets
{
    internal class Ticket
    {
        Cliente unCliente;
        static int nroOrden = 0;
        public int NroOrden {  get { return nroOrden; } set { value = nroOrden; } }
        DateTime FechaHora;
        List<Servicio> listaServicio = new List<Servicio>();

        public Ticket(long cuit, string nombre)
        {
            unCliente = new Cliente(cuit, nombre);
            FechaHora = DateTime.Now;
            nroOrden++;
            NroOrden = nroOrden;
        }
        public void AgregarServicio(Servicio tarea)
        {
            if (tarea != null) listaServicio.Add(tarea);
        }
        public Servicio QuitarServicio(int nro) //Busqueda Binaria
        {
            Ordenar();
            Servicio buscado = new Mantenimiento(nro, "", 0);

            int indice = listaServicio.BinarySearch(buscado);
            if (indice >= 0) //Existe el objeto si es mayor o igual a 0
            {
                Servicio encontrado = listaServicio[indice];
                listaServicio.RemoveAt(indice);
                return encontrado;
            }

            return null;
        }
        public double PrecioFinal()
        {
            double acm = 0;
            foreach (Servicio item in listaServicio)
            {
                acm += item.Precio();
            }
            return acm;
        }
        public void Ordenar()
        {
            listaServicio.Sort();
        }

        public override string ToString()
        {
            return NroOrden + " " + unCliente.ToString() + " " +FechaHora + " " +PrecioFinal();
        }
    
    }
}
