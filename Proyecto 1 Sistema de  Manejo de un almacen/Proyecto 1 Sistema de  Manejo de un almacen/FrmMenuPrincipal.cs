using Proyecto_1_Sistema_de_Manejo_de_un_almacen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1_Sistema_de__Manejo_de_un_almacen
{
    public partial class FrmMenuPrincipal : Form
    {
        private List<Productos> listaProductos = new List<Productos>();

        // Lista que almacena todos los productos del sistema
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            listaProductos.Add(new Productos
            {
                Codigo = "A001",
                Nombre = "Papel",
                Categoria = "Oficina",
                Necesidad = "Alta",
                Cantidad = 20,
                Precio = 100.00m,
                ITBIS = 18.00m,
                CantidadMinima = 10,
                Estado = "Disponible"
            });

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Este evento no es necesario si no lo usas
        }

        private void mostrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarProductos mostrar = new FrmMostrarProductos(listaProductos);
            mostrar.MdiParent = this;
            mostrar.Show();
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto agregar = new FrmAgregarProducto();
            if (agregar.ShowDialog() == DialogResult.OK)
            {
                listaProductos.Add(agregar.ProductoAgregado);
            }
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarProducto actualizar = new FrmActualizarProducto(listaProductos);
            actualizar.MdiParent = this;
            actualizar.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarProducto eliminar = new FrmEliminarProducto();
            eliminar.MdiParent = this;
            eliminar.Show();
        }

        private void exportarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar el código para exportar la lista a CSV.
            // Por ahora, solo mostramos un mensaje.
            MessageBox.Show("Función Exportar Datos aún no implementada.", "Exportar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}