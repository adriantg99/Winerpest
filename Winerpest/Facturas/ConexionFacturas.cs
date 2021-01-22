using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Winerpest.Login;

namespace Winerpest.Facturas
{
    class ConexionFacturas
    {
        Login.Login Entrada = new Login.Login();
        string auxu, auxp;

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        
        public ConexionFacturas()
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

        public string insertarFactura(string clave, float subtotal, float iva, float total, int claveVenta, int claveCliente)
        {
            string salida = "Se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO FACTURA(cve_factura,subtotal,iva,total,cve_venta,cve_cliente)VALUES('"+clave+"','"+subtotal+"','"+iva+"','"+total+"','"+claveVenta+"','"+claveCliente+"')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo insertar los datos en la base de datos" + ex.ToString();

            }


            return salida;
        }

        public string ModificarFactura(string clave, float subtotal, float iva, float total, int claveVenta, int claveCliente)
        {
            string salida = "Se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO FACTURA(cve_factura,subtotal,iva,total,cve_venta,cve_cliente)VALUES('" + clave + "','" + subtotal + "','" + iva + "','" + total + "','" + claveVenta + "','" + claveCliente + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo insertar los datos en la base de datos" + ex.ToString();

            }


            return salida;
        }

        public string ActualizarFactura(string clave, float subtotal, float iva, float total, int claveVenta, int claveCliente)
        {
            string salida = "Se actualizo el registro";
            try
            {
                cmd = new SqlCommand("update FACTURA SET subtotal='" + subtotal + "', iva='" + iva + "'," + "total='" + total + "'," + "cve_venta='" + claveVenta + "'," + "cve_cliente='"+ claveCliente + "' where cve_factura='" + clave + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se Modifico el registro: " + ex.ToString();

            }

            return salida;
        }

        public string eliminarFactura(string clave)
        {

            string salida = "Se removio el producto";
            try
            {
                ///"delete from GPS where imei='
                cmd = new SqlCommand("delete from FACTURA where cve_factura ='" + clave + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el producto" + ex.ToString();

            }
            return salida;
        }

        public int facturaRegistrada(string clave)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from FACTURA where cve_factura='" + clave + "'", cn);
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
