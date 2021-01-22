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

namespace Winerpest.Facturas
{
    class OpcionesCmbx
    {
        Login.Login Entrada = new Login.Login();
        string auxu, auxp;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public OpcionesCmbx()
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
        #region Items
        public void seleccionarVenta(ComboBox cmbx)
        {
            cmbx.Items.Clear();
            cmd = new SqlCommand("select * from Ventas", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbx.Items.Add(dr[0].ToString());
            }
            
            cmbx.Items.Insert(0, "--- Selecciona un item---");
            cmbx.SelectedIndex = 0;
            
        }



        public void seleccionarCliente(ComboBox cb)
        {
            cb.Items.Clear();
            
            cmd = new SqlCommand("select * from CLIENTE", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[0].ToString());
            }
            
            cb.Items.Insert(0, "--- Selecciona un item---");
            cb.SelectedIndex = 0;
            cn.Close();
        }
        #endregion
    }
}
