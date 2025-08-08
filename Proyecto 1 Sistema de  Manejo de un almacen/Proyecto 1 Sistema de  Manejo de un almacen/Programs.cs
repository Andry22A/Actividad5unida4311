using Proyecto_1_Sistema_de__Manejo_de_un_almacen;
using System;
using System.Windows.Forms;

namespace Proyecto_1_Sistema_de_Manejo_de_un_almacen
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenuPrincipal());
        }
    }
}