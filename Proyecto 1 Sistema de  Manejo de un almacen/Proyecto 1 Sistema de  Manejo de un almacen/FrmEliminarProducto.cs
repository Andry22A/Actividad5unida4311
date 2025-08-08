using System;
using System.Windows.Forms;

namespace Proyecto_1_Sistema_de__Manejo_de_un_almacen
{
    public partial class FrmEliminarProducto : Form
    {
        public string CodigoAEliminar { get; private set; }

        public FrmEliminarProducto()
        {
            InitializeComponent();
        }

        private void FrmEliminarProducto_Load(object sender, EventArgs e)
        {
            // Este evento se ejecuta al cargar el formulario.
            // Puedes usarlo para poner foco en el textbox.
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, introduce el código del producto a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CodigoAEliminar = txtCodigo.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}