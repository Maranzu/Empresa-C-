using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresa
{
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Run(new Form_categorias());
            Form_categorias Categorias = new Form_categorias();
            Categorias.MdiParent = this;
            Categorias.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_productos Productos = new Form_productos();
            Productos.MdiParent = this;
            Productos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_consultas Consultas = new Form_consultas();
            Consultas.MdiParent = this;
            Consultas.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_informes Reportes = new Form_informes();
            Reportes.MdiParent = this;
            Reportes.Show();
        }
    }
}
