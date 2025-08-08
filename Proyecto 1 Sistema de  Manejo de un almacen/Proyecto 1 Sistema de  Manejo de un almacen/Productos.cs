namespace Proyecto_1_Sistema_de__Manejo_de_un_almacen
{
    public class Productos
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Necesidad { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal ITBIS { get; set; }
        public int CantidadMinima { get; set; }
        public string Estado { get; set; }
    }
}