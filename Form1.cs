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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string historia = textBoxHistoria.Text;
            DateTime Fecha = dateTimePickerFechaCreacion.Value;


            int respuesta = personaje1.CrearPersonaje(nombre, raza, nivelpoder, Fecha, historia);
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

        private void buscarPorId()
        {
            int idPersonajeABuscar = int.Parse(textboxID.Text);

            DataTable personajeEncontrado = personaje1.BuscarPersonajePorId(idPersonajeABuscar);

            if (personajeEncontrado.Rows.Count > 0)
            {
                // El personaje fue encontrado
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                textBoxnombre.Text = nombre;
                textBoxraza.Text = raza;

                numericUpDownNivel_De_poder.Value = nivelPoder;
            }
            else
            {
                // El personaje no fue encontrado
                Console.WriteLine("No se encontró el personaje con ID: " + idPersonajeABuscar);
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
           
            

                buscarPorId();

            
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textboxID.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor en el campo de texto.");
                textboxID.Focus(); // Devolver el foco al TextBox
            }
            else
            {
                buscarPorId();
            }
        }

        private void ActualizarPersonaje()
        {
            int id = int.Parse(textboxID.Text);
            string nombre = textBoxnombre.Text;
            string raza = textBoxraza.Text;
            int nivelPoder = (int)numericUpDownNivel_De_poder.Value;
            DateTime Fecha = dateTimePickerFechaCreacion.Value;
            string historia = textBoxHistoria.Text;

            personaje1.ActualizarPersonaje(id, nombre, raza, nivelPoder, Fecha, historia);

            MessageBox.Show("Personaje actualizado correctamente.");
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarPersonaje();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }






}
