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


namespace Winerpest.Ventas
{
    class ComboBoxss
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public ComboBoxss()
        {
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
        public void seleccionar(ComboBox cmbx)
        {
            cmbx.Items.Clear();
            cmd = new SqlCommand("select * from CATALOGO", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbx.Items.Add(dr[0].ToString());
            }
            cn.Close();
            cmbx.Items.Insert(0, "--- Selecciona un item---");
            cmbx.SelectedIndex = 0;
            cn.Close();
        }
    }
}
