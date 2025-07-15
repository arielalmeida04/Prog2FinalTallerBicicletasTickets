using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2FinalTallerBicicletasTickets
{
    internal class ImportarServicios : Iimportable
    {
		private List<Servicio> listaServicios;
		public ImportarServicios(List<Servicio> lista)
		{
			listaServicios = lista;
		}
        public void CargarArchivo(string ruta)
        {
			//FileStream fs = null;
			//StreamReader sr = null;
			try
			{
				FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
				StreamReader sr = new StreamReader(fs);
				listaServicios.Clear();
				while (!sr.EndOfStream)
				{
					string linea = sr.ReadLine();
					string[] campos = linea.Split(';');
					string servicio = campos[0];

					if (servicio == "R")
					{
						int cod = int.Parse(campos[1]);
						string descripcion = campos[2];
						double precioB = double.Parse(campos[3]);
						double precioR = double.Parse(campos[4]);
						Servicio r = new Reparacion(cod, descripcion, precioB, precioR);
						listaServicios.Add(r);
					}

					else if (servicio == "M")
					{
						int codigo = int.Parse(campos[1]);
						string descipcion = campos[2];
						double precioB = Double.Parse(campos[3]);
						Servicio m = new Mantenimiento(codigo, descipcion, precioB);
						listaServicios.Add(m);
					}
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show("error "+ex.Message);
			}
			finally 
			{ 
				//if(fs!=null)
				//fs.Close();
				//sr.Close();
			}
		
		}
    }
}
