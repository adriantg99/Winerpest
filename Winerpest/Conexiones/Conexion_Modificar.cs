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

namespace Winerpest.Conexiones
{
    class Conexion_Modificar
    {
        Login.Login Entrada = new Login.Login();
        string auxu, auxp;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dR;


        public Conexion_Modificar()
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

        public string ModificarCliente(int id, string nombre_Cliente, string telefono_Cliente)
        {

            string salida = "Se Realizo la modificacion de los datos";
            try
            {
                //cmd = new SqlCommand("INSERT INTO CLIENTE(cve_cliente,nombre_cliente,telefono_cliente)VALUES("+id+",'"+nombre_Cliente+"','"+telefono_Cliente+"')",cn);
                cmd = new SqlCommand("UPDATE CLIENTE SET nombre_cliente='" + nombre_Cliente + "', telefono_cliente='" + telefono_Cliente + "'" + "where cve_cliente='" + id + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se pudo insertar los datos en la base de datos" + ex.ToString();

            }


            return salida;
        }

        public int personaRegistrada(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from cliente where cve_cliente=" + id + "", cn);
                dR = cmd.ExecuteReader();
                while (dR.Read())
                {
                    contador++;
                }
                dR.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
    }
}
