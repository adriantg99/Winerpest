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
    public partial class Cliente : Form
    {
        Conexiones.Conexion c = new Conexiones.Conexion();
        public Cliente()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSetClienteSQLTAP.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.cLIENTETableAdapter5.Fill(this.winnerPetDataSetClienteSQLTAP.CLIENTE);
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSet19.CLIENTE' Puede moverla o quitarla según sea necesario.

            Conexiones.Conexion c = new Conexiones.Conexion();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtbid.Text==""|| txtbNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else if(c.personaRegistrada(Convert.ToInt32(txtbid.Text))==0)
            {
                MessageBox.Show(c.insertarCliente(Convert.ToInt32(txtbid.Text), txtbNombre.Text, txtTelefono.Text));
                txtbid.Text = "";
                txtbNombre.Text = "";
                txtTelefono.Text = "";
            }
            else
            {
                MessageBox.Show("Imposible registrar, el registro ya existe");
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Opciones_clientes Regresar = new Opciones_clientes();
            Regresar.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opciones_clientes Regresar = new Opciones_clientes();
            Regresar.Show();
            this.Close();
        }

        private void gbx1_Enter(object sender, EventArgs e)
        {

        }
    }
}
