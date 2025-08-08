using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_1_Sistema_de__Manejo_de_un_almacen
{
    public partial class FrmExportarDatos : Form
    {
        // Ejemplo de lista de productos para exportar
        private List<Producto> listaProductos;

        public FrmExportarDatos()
        {
            InitializeComponent();
            // Simulamos algunos datos, en tu caso debe venir de tu estructura real
            listaProductos = new List<Producto>()
            {
                new Producto(){ Id = 1, Nombre = "Producto A", Cantidad = 10, Precio = 15.5m },
                new Producto(){ Id = 2, Nombre = "Producto B", Cantidad = 5, Precio = 8.99m },
                new Producto(){ Id = 3, Nombre = "Producto C", Cantidad = 20, Precio = 3.75m }
            };
        }

        private void btnBuscarRuta_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivos CSV (*.csv)|*.csv";
                sfd.Title = "Seleccione la ruta para guardar el archivo CSV";
                sfd.FileName = "exportacion.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    txtRutaArchivo.Text = sfd.FileName;
                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string ruta = txtRutaArchivo.Text.Trim();

    if (string.IsNullOrEmpty(ruta))
    {
        MessageBox.Show("Por favor, seleccione una ruta para guardar el archivo.", "Ruta no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    try
    {
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            // Escribimos encabezados
            sw.WriteLine("Id,Nombre,Cantidad,Precio");

            // Escribimos cada producto en formato CSV
            foreach (var p in listaProductos)
            {
                string linea = $"{p.Id},{EscapeCsv(p.Nombre)},{p.Cantidad},{p.Precio}";
                sw.WriteLine(linea);
            }
        }

        MessageBox.Show("Datos exportados correctamente.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al exportar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
        private void txtRutaArchivo_TextChanged(object sender, EventArgs e)
        {
            btnExportar.Enabled = !string.IsNullOrWhiteSpace(txtRutaArchivo.Text);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para escapar comas y comillas en texto CSV
        private string EscapeCsv(string texto)
        {
            if (texto.Contains(",") || texto.Contains("\"") || texto.Contains("\n"))
            {
                texto = texto.Replace("\"", "\"\"");
                texto = $"\"{texto}\"";
            }
            return texto;
        }

        private void FrmExportarDatos_Load(object sender, EventArgs e)
        {
            btnExportar.Enabled = false;
            
        }

        private void lblRutaArchivo_Click(object sender, EventArgs e)
        {

        }
    }

    // Clase ejemplo Producto
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}