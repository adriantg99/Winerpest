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
    public partial class Opciones_clientes : Form
    {
        public Opciones_clientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente Agregar = new Cliente();
            Agregar.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente eliminar = new EliminarCliente();
            eliminar.Show();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            WinnerPet Principal = new WinnerPet();
            Principal.Visible= true;
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar Mod = new Modificar();
            Mod.Show();
            this.Close();

        }
    }
}
