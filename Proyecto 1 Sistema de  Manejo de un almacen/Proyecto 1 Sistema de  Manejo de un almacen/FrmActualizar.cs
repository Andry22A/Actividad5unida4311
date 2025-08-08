using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_1_Sistema_de__Manejo_de_un_almacen
{
    public partial class FrmActualizarProducto : Form
    {
        private List<Productos> productos;

        public FrmActualizarProducto(List<Productos> lista)
        {
            InitializeComponent();
            productos = lista;
        }

        private void FrmActualizarProducto_Load(object sender, EventArgs e)
        {
            // Aquí puedes cargar algo al iniciar, si necesitas.
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBuscado = txtCodigo.Text.Trim();
            Productos producto = productos.Find(p => p.Codigo == codigoBuscado);

            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                cmbCategoria.SelectedItem = producto.Categoria;
                txtCantidad.Text = producto.Cantidad.ToString();
                txtPrecio.Text = producto.Precio.ToString();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string codigoBuscado = txtCodigo.Text.Trim();
            Productos producto = productos.Find(p => p.Codigo == codigoBuscado);

            if (producto != null)
            {
                producto.Nombre = txtNombre.Text.Trim();
                producto.Categoria = cmbCategoria.SelectedItem.ToString();
                producto.Cantidad = int.Parse(txtCantidad.Text);
                producto.Precio = decimal.Parse(txtPrecio.Text);

                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmActualizarProducto_Load_1(object sender, EventArgs e)
        {

        }
    }
}