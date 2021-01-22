using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Winerpest.Conexiones.ConexionesGps
{
    class ConexionesGps
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        Login.Login Entrada = new Login.Login();
        private string auxu, auxp;

        public ConexionesGps()
        {
            Entrada.EntradaUsuario(auxu);
            Entrada.EntradaContrasena(auxp);
            try
            {
                cn = new SqlConnection("Data Source=192.168.0.23;Initial Catalog=WinnerPet;Persist Security Info=True;User ID=Adrian;Password=123");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }

        public string insertar(Int64 imei, string latitud, string longitud)
        {
            string salida= "Se inserto correctamente los datos";

            try
            {
                cmd = new SqlCommand("INSERT INTO GPS(imei, latitud, longitud) values('" + imei + "','" + latitud + "', '" + longitud+"')", cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo insertar el valor"+ex.ToString());
            }

            return salida;
        }

        public int GPSRegistrado(Int64 imei)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from GPS where imei='" + imei+"'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente: " + ex.ToString());
            }
            return contador;
        }

        public string EliminarGPS(Int64 imei)
        {
            string salida = "Se elimino el registro por id";
            try
            {
                cmd = new SqlCommand("delete from GPS where imei='" + imei + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se elimino el registro: " + ex.ToString();

            }

            return salida;
        }

        public string ActualizarGPS(Int64 imei, string latitud, string longitud)
        {
            string salida = "Se actualizo el registro";
            try
            {
                cmd = new SqlCommand("update GPS SET latitud='"+latitud+"', longitud='"+longitud+"'"+"where imei='"+imei+"'",cn);
                ///("INSERT INTO GPS(imei, latitud, longitud) values('" + imei + "','" + latitud + "', '" + longitud+"')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Modifico el registro: " + ex.ToString();

            }

            return salida;
        }
    }
}
