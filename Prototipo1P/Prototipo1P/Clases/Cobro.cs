using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P.Clases
{
    public class Cobro
    {
        String codCobro;
        String tipoPago;
        String cantidadCobro;
        String ventaEncabezado;

        public Cobro(string codCobro, string tipoPago, string cantidadCobro, string ventaEncabezado)
        {
            this.CodCobro = codCobro;
            this.TipoPago = tipoPago;
            this.CantidadCobro = cantidadCobro;
            this.VentaEncabezado = ventaEncabezado;
        }
        public Cobro()
        {
        }

        public string CodCobro { get => codCobro; set => codCobro = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public string CantidadCobro { get => cantidadCobro; set => cantidadCobro = value; }
        public string VentaEncabezado { get => ventaEncabezado; set => ventaEncabezado = value; }

        public void funInsertar()
        {
            if (CodCobro == "" && TipoPago == "" && CantidadCobro == "" && VentaEncabezado == "")
            {
                MessageBox.Show("No se pueden dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String psql = "INSERT INTO cobro(codCobro,tipoPago,cantidadCobro,ventaEncabezado)" +
             " VALUES('" + codCobro + "' , '" + tipoPago + "' , '" + cantidadCobro + "', '" + ventaEncabezado + "')";

                //Console.WriteLine(psql);
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                try
                {
                    MySqlCommand insertarCobro = new MySqlCommand(psql, conexionBD);
                    insertarCobro.ExecuteNonQuery();
                    MessageBox.Show("Datos Ingresados Correctamente");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar los datos " + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }
        public List<Object> consulta(String dato)
        {
            MySqlDataReader reader = null;
            List<Object> lista = new List<Object>();
            String sql;

            if (dato == null)
            {
                sql = "SELECT * FROM cobro";
            }
            else
            {
                sql = "SELECT * FROM cobro WHERE codCobro LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarCobro = new MySqlCommand(sql, conexionBD);
                reader = buscarCobro.ExecuteReader();


                while (reader.Read())
                {

                    Cobro cobro = new Cobro();

                    cobro.CodCobro = reader.GetString("codCobro");
                    cobro.TipoPago = reader.GetString("tipoPago");
                    cobro.CantidadCobro = reader.GetString("cantidadCobro");
                    cobro.VentaEncabezado = reader.GetString("ventaEncabezado");

                    lista.Add(cobro);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;
        }
        public void funModificar(String idModificar)
        {
            String pSqlModificar = "UPDATE cobro SET tipoPago='" + TipoPago + "', cantidadCobro='" + CantidadCobro + "', ventaEncabezado='" + VentaEncabezado + "' WHERE codCobro='" + idModificar + "'";
            //Console.WriteLine(pSqlModificar);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand modificarCobro = new MySqlCommand(pSqlModificar, conexionBD);
                modificarCobro.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
        public void funBuscarSetearTxt(TextBox codC, ComboBox tipoP,TextBox cantC, ComboBox ventaEnc, String codCobro)
        {
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT * from cobro WHERE codCobro='" + codCobro + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand busqueda = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = busqueda.ExecuteReader();

                while (leer.Read())
                {
                    codC.Text = leer.GetString(0);
                    tipoP.Text = leer.GetString(1);
                    cantC.Text = leer.GetString(2);
                    ventaEnc.Text = leer.GetString(3);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
        public void funLlenarCombo(ComboBox combobox, String tabla, String id, String nombre)
        {
            combobox.DataSource = null;
            combobox.Items.Clear();
            String psql = "Select * FROM " + tabla;
            Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            try
            {
                MySqlCommand llenarCombo = new MySqlCommand(psql, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(llenarCombo);
                DataTable dt = new DataTable();
                data.Fill(dt);
                combobox.ValueMember = id;
                combobox.DisplayMember = nombre;
                combobox.DataSource = dt;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
        }
        public void obtenerNombreTipoPago(String idTipoPago)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombreTipoPago from tipoPago WHERE idTipoPago='" + idTipoPago + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscarCobro = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscarCobro.ExecuteReader();
                while (leer.Read())
                {
                    idTipoPago = leer.GetString("nombreTipoPago");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
        }
        public void obtenerNombreVentaEnca(String idVentaEnc)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombreVentaEnc from ventaEncabezado WHERE idVentaEnc='" + idVentaEnc + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscarCobro = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscarCobro.ExecuteReader();
                while (leer.Read())
                {
                    idVentaEnc = leer.GetString("nombreVentaEnc");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
        }
        public void funEliminar(String idEliminar)
        {
            String pSqlModificar = "delete from cobro WHERE codCobro='" + idEliminar + "'";
            //Console.WriteLine(pSqlModificar);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand eliminarCobro = new MySqlCommand(pSqlModificar, conexionBD);
                eliminarCobro.ExecuteNonQuery();
                MessageBox.Show("Datos Eliminados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
