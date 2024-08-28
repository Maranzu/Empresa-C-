using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace empresa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Class_sqlserver acceso = new Class_sqlserver();

        private void btningreso_Click(object sender, EventArgs e)
        {
            if (acceso.validar(this.tbUser.Text, this.tbpassword.Text) == true)
            {
                MessageBox.Show("Bienvenido");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
