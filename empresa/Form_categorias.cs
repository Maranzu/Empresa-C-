using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresa
{
    public partial class Form_categorias : Form
    {
        public Form_categorias()
        {
            InitializeComponent();
        }
        public void Activar()
        {
            Nuevo.Enabled = false;
            Guardar.Enabled = true;
            Cancelar.Enabled = true;
            Editar.Enabled = false;
            Eliminar.Enabled = false;
            Salir.Enabled = false;
        }
        public void Desactivar()
        {
            Nuevo.Enabled = true;
            Guardar.Enabled = false;
            Cancelar.Enabled = false;
            Editar.Enabled = true;
            Eliminar.Enabled = true;
            Salir.Enabled = true;
        }

        private void Form_categorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds_empresa.Categoria' Puede moverla o quitarla según sea necesario.
            this.TA_categoria.Fill(this.ds_empresa.Categoria);

        }
        private void Nuevo_Click(object sender, EventArgs e)
        {
            this.Activar();
            BS_categoria.AddNew();
            this.cod_categoriaTextBox.Focus();
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Desactivar();
                BS_categoria.EndEdit();
                TA_categoria.Update(ds_empresa.Categoria);
            }
            catch (NoNullAllowedException error)
            {
                MessageBox.Show(error.Message, "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BS_categoria.CancelEdit();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Desactivar();
            BS_categoria.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            this.Activar();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
