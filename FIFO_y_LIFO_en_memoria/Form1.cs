using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIFO_y_LIFO_en_memoria;

namespace FIFO_y_LIFO_en_memoria
{
    public partial class Form1 : Form
    {
        string elemento;
        public List<string> DetallesPila = new List<string>();
        public List<string> DetallesCola = new List<string>();

        //PIla MiPila = new PIla();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarPila_Click(object sender, EventArgs e)
        {
            elemento = Convert.ToString(txtAgregarPila.Text);
            DetallesPila.Add(elemento);
            actualizarPila();
            txtAgregarPila.Text = "";
            txtAgregarPila.Focus();
            //hasta aca funciona el agregar a la lista
        }

        private void actualizarPila()
        {
            lstPila.DataSource = null;
            lstPila.DataSource = DetallesPila;


        }

        private void btnQuitarPila_Click(object sender, EventArgs e)
        {

            int elementoAQuitar = (DetallesPila.Count - 1);
            DetallesPila.RemoveAt(elementoAQuitar);
            actualizarPila();
        }

        private void btnAgregarCola_Click(object sender, EventArgs e)
        {
            elemento = Convert.ToString(txtgAgregarCola.Text);
            DetallesCola.Add(elemento);
            actualizarCola();
            txtgAgregarCola.Text = "";
            txtgAgregarCola.Focus();
        }

        private void actualizarCola()
        {
            lstCola.DataSource = null;
            lstCola.DataSource = DetallesCola;
        }

        private void btnQuitaCola_Click(object sender, EventArgs e)
        {
            int elementoAQuitar = 0;
            DetallesCola.RemoveAt(elementoAQuitar);
            actualizarCola();

        }

        

        private void btnPrimerElementoPila_Click_1(object sender, EventArgs e)
        {
            if (DetallesPila.Count <= 0)
            {
                MessageBox.Show("La pila esta vacia!! ", "Atencion!!");

            }
            else
            {
                string mensaje = DetallesPila[0].ToString();
                MessageBox.Show("el primer elemento de la Pila es: " + mensaje, "Atencion!!");
            }
        }

        private void btnProxSalirPila_Click(object sender, EventArgs e)
        {
            if (DetallesPila.Count <= 0)
            {
                MessageBox.Show("La pila esta vacia!! ", "Atencion!!");

            }
            else
            {
                int numero = (DetallesPila.Count -1);
                string mensaje = DetallesPila[numero].ToString();
                MessageBox.Show("el proximo elemento de la Pila a salir es: " + mensaje, "Atencion!!");
            }
        }

      

        private void btnProxSalirCola_Click(object sender, EventArgs e)
        {
            if (DetallesCola.Count <= 0)
            {
                MessageBox.Show("La cola esta vacia!! ", "Atencion!!");

            }
            else
            {
              
                string mensaje = DetallesCola[0].ToString();
                MessageBox.Show("el proximo elemento de la Cola a salir es: " + mensaje, "Atencion!!");
            }
        }

        private void btnPrimerElementoCola_Click(object sender, EventArgs e)
        {
            if (DetallesCola.Count <= 0)
            {
                MessageBox.Show("La cola esta vacia!! ", "Atencion!!");

            }
            else
            {
                string mensaje = DetallesCola[0].ToString();
                MessageBox.Show("el primer elemento de la Cola es: " + mensaje, "Atencion!!");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?",
               "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                this.Close();
        }
    }
}
