using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Winerpest.Conexiones;

namespace Winerpest.Altas
{
    class ConexionAltas
    {
        Login.Login Entrada = new Login.Login();
        string auxu, auxp;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public ConexionAltas()
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


        #region Captura de datos

        public string eliminarAlta(int clave)
        {

            string salida = "Se removio el producto";
            try
            {
                ///"delete from GPS where imei='
                cmd = new SqlCommand("delete from ALTAS where id_alta='" + clave + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo eliminar el producto" + ex.ToString();

            }
            return salida;
        }


        public string insertarAlta(int Alta, int clave, string Imei)
        {
            string salida = "Se inserto";
            try
            {
                cmd = new SqlCommand("INSERT INTO Altas(id_alta,cve_venta,imei) values('"+Alta+"','"+clave+"','"+Imei+"')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo insertar los datos en la base de datos" + ex.ToString();

            }


            return salida;
        }

        public int AltaRegistrada(int clave)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from ALTAS where id_alta='" + clave + "'", cn);
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



        #endregion

    }
}
