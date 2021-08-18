using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace Prototipo1P.Clases
=======
namespace sistema_reparto
>>>>>>> RamaMantenimiento9959189131
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {
            String servidor = "localhost";
<<<<<<< HEAD
            String bd = "SIC";
            String usuario = "root";
            String password = "root";
=======
            String bd = "sic";
            String usuario = "root";
            String password = "";
>>>>>>> RamaMantenimiento9959189131

            String cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id= " + usuario +
            "; Password=" + password + ";";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;
            }
<<<<<<< HEAD
            catch (MySqlException ex)
=======
            catch(MySqlException ex)
>>>>>>> RamaMantenimiento9959189131
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
<<<<<<< HEAD
    
=======
>>>>>>> RamaMantenimiento9959189131
