using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2FinalTallerBicicletasTickets
{
    public partial class Form1 : Form
    {
        Stack<Ticket> listatickets = new Stack<Ticket>();
        List<Servicio> listaServicios = new List<Servicio>();
        Ticket tiki;
       

        public Form1()
        {
            InitializeComponent();


            listaServicios.Add(new Reparacion(100, "Frenos", 2400, 3000));
            listaServicios.Add(new Mantenimiento(120, "Ajuste de cambios", 4500));
            listaServicios.Add(new Mantenimiento(130, "Lubricar cadena", 2000));
            listaServicios.Add(new Reparacion(110, "Cambio de piñon", 2500, 5000));

            foreach (Servicio item in listaServicios)
            {
                listBox1.Items.Add(item); // Servicio sv = listbox1.selecteditem as  Servicio
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttCrearTicket_Click(object sender, EventArgs e)
        {
            try
            {
                listatickets.Push(tiki);

                lbTickets.Items.Add(tiki);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bttClietne_Click(object sender, EventArgs e)
        {
            GenerarTicket gt = new GenerarTicket();
            try
            {
                if (gt.ShowDialog() == DialogResult.OK)
                {
                    string nombre = gt.txbNombre.Text;
                    long cuit = Convert.ToInt64(gt.txbCuit.Text);
                    tiki = new Ticket(cuit, nombre);
                    MessageBox.Show("Se agrego correctamente");
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ex.Message);
            }
            finally
            {
                gt.Dispose();
            }
        }

        private void bttAgregarServicio_Click(object sender, EventArgs e)
        {
            Servicio sv = listBox1.SelectedItem as Servicio;
            try
            {
                if (sv is Reparacion r)
                {
                    int horas = Convert.ToInt32(txbTiempo.Text);
                    r.TiempoHoras = horas;
                    tiki.AgregarServicio(sv);
                    MessageBox.Show("Se agrego el servicio R");

                }
               else if(sv is Mantenimiento m)
                {
                    if (rbFeriado.Checked)
                    {
                        double extra = Convert.ToDouble(txbExtra.Text);
                        m.PorcentajeExtra(extra);
                        tiki.AgregarServicio(sv);
                        MessageBox.Show("Se agrego el servicio M");
                    }
                  
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bttEliminarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                int nro = Convert.ToInt32(textBox1.Text);
                Servicio s = tiki.QuitarServicio(nro);
                if (s != null)
                {
                    MessageBox.Show("Se elimino el ticket: " + s);
                }
                else
                {
                    MessageBox.Show("Servicio no encontrado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error "+ex.Message);
            }
        }
    }
}
