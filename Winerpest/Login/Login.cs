using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Winerpest.Login
{
    public partial class Login : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public string user;
        public string password;
        public string guardarUsuario;

        public Login()
        {
            InitializeComponent();

        }
             
public int logear(string user, string password)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from usuarios where Usuario='" + user + "' AND password='"+password+"'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos Incorrectos: " + ex.ToString());
            }
            return contador;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            guardarUsuario = txtUser.Text;
            try
            {

                cn = new SqlConnection("Data Source=localhost;Initial Catalog=WinnerPet;Persist Security Info=True;User ID='"+txtUser.Text+"';Password='"+txtPassword.Text+"'");
                cn.Open();
                WinnerPet principal = new WinnerPet();
                this.Visible = false;
                principal.Show();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
            }
        }
          

        public string EntradaUsuario(string Login)
        {
            Login = txtUser.Text;
            return Login;
        }

        public string EntradaContrasena(string Contra)
        {
            Contra = txtPassword.Text;
            return Contra;
        }
    }
}
