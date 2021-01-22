using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winerpest
{
    public partial class Bitacoras : Form
    {
        public Bitacoras()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bitacoras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'winnerPetDataSet9.Bitacoras' Puede moverla o quitarla según sea necesario.
            this.bitacorasTableAdapter.Fill(this.winnerPetDataSet9.Bitacoras);

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            WinnerPet Principal = new WinnerPet();
            Principal.Visible = true;
            this.Close();
        }
    }
}
