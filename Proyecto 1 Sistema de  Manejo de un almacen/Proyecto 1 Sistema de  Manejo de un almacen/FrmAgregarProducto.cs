using Proyecto_1_Sistema_de__Manejo_de_un_almacen;
using System;
using System.Windows.Forms;

namespace Proyecto_1_Sistema_de_Manejo_de_un_almacen
{
    public partial class FrmAgregarProducto : Form
    {
        public Productos ProductoAgregado { get; private set; }

        public FrmAgregarProducto()
        {
            InitializeComponent();
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Bebidas");
            cmbCategoria.Items.Add("Alimentos");
            cmbCategoria.Items.Add("Limpieza");
            cmbCategoria.Items.Add("Electrónica");
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSeleccionCategoria.Text = "Categoría seleccionada: " + cmbCategoria.SelectedItem.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                cmbCategoria.SelectedIndex == -1 ||
                !int.TryParse(txtCantidad.Text, out int cantidad) ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Datos inválidos. Completa todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProductoAgregado = new Productos()
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Categoria = cmbCategoria.SelectedItem.ToString(),
                Cantidad = cantidad,
                Precio = precio
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función de prueba ejecutada correctamente.", "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblSeleccionCategoria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecciona una categoría en el ComboBox.", "Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}