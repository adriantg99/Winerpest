using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Winerpest.Ventas
{
    class ConexionVentas
    {
        Login.Login Entrada = new Login.Login();
        string auxu, auxp;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public ConexionVentas()
        {
            Entrada.EntradaUsuario(auxu);
            Entrada.EntradaContrasena(auxp);
            try
            {
                cn = new SqlConnection("Data Source=localhost;Initial Catalog=WinnerPet;Integrated Security=True");
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }

        public string InsertarVenta(int clave_venta, int importe, int cantidad, int claveProducto)
        {

            string salida = "Se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO VENTAS(cve_venta,importe,cantidad,cve_producto) values('" + clave_venta + "','" + importe + "','" + cantidad + "','" + claveProducto + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo insertar los datos en la base de datos" + ex.ToString();

            }

            return salida;



        }

        public string EliminarVenta(int clave_venta)
        {
            string salida = "Se removio la venta";
            try
            {
                ///"delete from GPS where imei='
                cmd = new SqlCommand("delete from Ventas where cve_venta ='" + clave_venta + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar la venta" + ex.ToString();

            }
            return salida;
        }

        public string ActualizarVenta(int clave_venta, int importe, int cantidad, int claveProducto)
        {
            string salida = "Se actualizo el registro";
            try
            {
                cmd = new SqlCommand("update VENTAS SET importe='" + importe + "', cantidad='" + cantidad + "'," + "cve_producto='" + claveProducto + "' where cve_venta='" + clave_venta + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Modifico el registro: " + ex.ToString();

            }

            return salida;
        }

        public int VentaRegistrada(int clave_venta)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from VENTAS where cve_venta='" + clave_venta + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar correctamente: " + ex.ToString());
            }
            return contador;
        }


    }
}
