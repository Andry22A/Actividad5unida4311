using Proyecto_1_Sistema_de__Manejo_de_un_almacen;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_1_Sistema_de_Manejo_de_un_almacen
{
    public partial class FrmMostrarProductos : Form
    {
        private List<Productos> productos;

        // CONSTRUCTOR CORRECTO
        public FrmMostrarProductos(List<Productos> lista)
        {
            InitializeComponent();
            productos = lista;
        }

        private void FrmMostrarProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.AutoGenerateColumns = true; // Esta línea activa la generación automática

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes dejarlo vacío si no haces nada aquí
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}