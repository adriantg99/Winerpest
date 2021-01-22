using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winerpest.Cliente
{
    public partial class Modificar : Form
    {
        Conexiones.Conexion_Modificar Mod = new Conexiones.Conexion_Modificar();
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSetClienteSQLTAP.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter4.Fill(this.winnerPetDataSetClienteSQLTAP.CLIENTE);
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSetClienteModificar.CLIENTE' Puede moverla o quitarla según sea necesario.


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opciones_clientes Principal = new Opciones_clientes();
            Principal.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbid.Text == "" || txtbNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if (Mod.personaRegistrada(Convert.ToInt32(txtbid.Text)) == 1)
            {
                MessageBox.Show(Mod.ModificarCliente(Convert.ToInt32(txtbid.Text), txtbNombre.Text, txtTelefono.Text));
                txtbid.Text = "";
                txtbNombre.Text = "";
                txtTelefono.Text = "";
            }
            else
            {
                MessageBox.Show("Imposible registrar, el registro ya existe");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
