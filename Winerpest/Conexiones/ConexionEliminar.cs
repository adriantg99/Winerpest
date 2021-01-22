using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Winerpest.Conexiones
{
    class ConexionEliminar
    {
        Login.Login Entrada = new Login.Login();
        string auxu, auxp;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dR;

        public ConexionEliminar()
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

        public string EliminarClienteId(int id)
        {
            string salida = "Se elimino el registro por id";
            try
            {
                cmd = new SqlCommand("delete from Cliente where cve_cliente='"+id+ "'", cn);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                salida = "No se elimino el registro: " + ex.ToString();

            }

            return salida;
        }
        public string EliminarClienteNombre(string Nombre)
        {
            string salida = "Se elimino el registro por Nombre";
            try
            {
                cmd = new SqlCommand("delete from Cliente where nombre_cliente='" + Nombre + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se elimino el registro: " + ex.ToString();

            }

            return salida;
        }

        public string EliminarClienteTelefono(string Telefono)
        {
            string salida = "Se elimino el registro por telefono";
            try
            {
                cmd = new SqlCommand("delete from Cliente where telefono_cliente='" + Telefono + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se elimino el registro: " + ex.ToString();

            }

            return salida;
        }

        public int personaRegistradaByID(int id)
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

        public int personaRegistradaByName(string name)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from cliente where nombre_cliente='" + name + "'", cn);
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

        public int personaRegistradaByphone(string Telefono)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from cliente where telefono_cliente='" + Telefono + "'", cn);
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
