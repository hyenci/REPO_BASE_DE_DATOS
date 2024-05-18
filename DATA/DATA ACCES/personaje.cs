using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_EN_CLASE_1.DATA.DATA_ACCES
{
    internal class personaje
    {


        private string connectionString = "Server=localhost;Database=dragon;Uid=root;Pwd=ana21hm";
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {



                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }



            }

        }
        public DataTable LeerPersonajes()
        {

            DataTable personajes = new DataTable();


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {







                connection.Open();


                string sql = "Select * from personajes_dragon_ball";

                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {


                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {



                        adapter.Fill(personajes);

                    }



                }


            }
            return personajes;



        }


        public int CrearPersonaje(string nombre, string raza, int nivelPoder)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder) VALUES (@nombre, @raza, @nivelPoder)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);

                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}

