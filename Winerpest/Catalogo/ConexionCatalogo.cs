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

namespace Winerpest.Catalogo
{
    class ConexionCatalogo
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        Login.Login Entrada = new Login.Login();

        public ConexionCatalogo()
        {
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

        public enum Productos
        {
            Mascotas,
            Higiene,
            Servicios,
            Gps
        }


        public string InsertarCatalogo(int idProducto, int tipoProducto, string nombreProducto, float precioProducto, string clasificacion)
        {


            string salida = "Se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO CATALOGO(cve_producto,tipo_producto, nombre_producto, precio_producto,clasificacion)VALUES('"
                    + idProducto + "','" + tipoProducto + "','" + nombreProducto + "','" + precioProducto + "','" + clasificacion + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo insertar los datos en la base de datos" + ex.ToString();

            }

            return salida;

        }

        public string EliminarCatalogo(int idProducto)
        {

            string salida = "Se removio el producto";
            try
            {
                ///"delete from GPS where imei='
                cmd = new SqlCommand("delete from CATALOGO where cve_producto ='" + idProducto + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el producto" + ex.ToString();

            }
            return salida;
        }

        public int ProductoRegistrado(int claveProducto)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from CATALOGO where cve_producto='" + claveProducto + "'", cn);
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

        public string ActualizarProducto(int idProducto, int tipoProducto, string nombreProducto, float precioProducto, string clasificacion)
        {
            string salida = "Se actualizo el registro";
            try
            {
                cmd = new SqlCommand("update CATALOGO SET nombre_producto='" + nombreProducto + "', tipo_producto='" + tipoProducto + "'," +  "precio_producto='"+precioProducto+"',"+ "clasificacion='"+clasificacion+"'"+ " where cve_producto='"+idProducto+"'" ,cn);
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
