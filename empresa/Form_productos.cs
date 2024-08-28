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
    public partial class Form_productos : Form
    {
        public Form_productos()
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
        private void Form_productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds_empresa1.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.DS_PRODUCTOS.Productos);
            // TODO: esta línea de código carga datos en la tabla 'ds_empresa1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.DS_PRODUCTOS.Categoria);

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            this.Activar();
            BS_Productos.AddNew();
            this.cod_productoTextBox.Focus();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Desactivar();
                BS_Productos.EndEdit();
                productosTableAdapter.Update(DS_PRODUCTOS.Productos);
            }
            catch (NoNullAllowedException error)
            {
                MessageBox.Show(error.Message, "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BS_Productos.CancelEdit();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Desactivar();
            BS_Productos.CancelEdit();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            this.Activar();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            this.OFD_abrirArchivo.FileName = "*jpg";
            OFD_abrirArchivo.ShowDialog();
            try
            {
                this.Fotografia.Image = System.Drawing.Image.FromFile(this.OFD_abrirArchivo.FileName);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No se ha seleccionado ninguna foto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TB_buscar_TextChanged(object sender, EventArgs e)
        {
            this.BS_Productos.Filter = "cod_producto LIKE '" + this.TB_buscar + "%'";
        }
    }
}
