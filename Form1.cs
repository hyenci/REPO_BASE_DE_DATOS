using EJERCICIO_EN_CLASE_1.DATA.DATA_ACCES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_EN_CLASE_1
{
    public partial class Form1 : Form

    {
        private personaje personaje1;


        public Form1()
        {
            InitializeComponent();
            personaje1 = new personaje();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(personaje1.ProbarConexion()) {


                MessageBox.Show("SI SE PUDO");

            
            }
            else
            {
                MessageBox.Show("NEL PASTEl");
            }




        }

        private void botoncargar_Click(object sender, EventArgs e)
        {
            dataGridViewPersonajes.DataSource = personaje1.LeerPersonajes();      }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void insertar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxnombre.Text;
            string raza = textBoxraza.Text; 
            int nivelpoder = (int)numericUpDownNivel_De_poder.Value;

            int respuesta = personaje1.CrearPersonaje(nombre, raza, nivelpoder);
            if (respuesta > 0)
            {


                MessageBox.Show("SE CREO CORRECTAMENTE");
                dataGridViewPersonajes.DataSource = personaje1.LeerPersonajes();   
            }
            else
            {

                MessageBox.Show("ERROR");

            }
        }
    }
}
