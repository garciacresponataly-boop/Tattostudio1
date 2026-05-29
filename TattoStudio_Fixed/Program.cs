using System;
using System.Windows.Forms;
using TattoStudio.Vista;

namespace TattoStudio
{
    // ============================================================
    // PROGRAMA: Punto de entrada
    // Esta clase inicia la aplicación. Solo hace una cosa:
    // crear y mostrar el formulario principal.
    // ============================================================
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Iniciar la app mostrando el menú principal
            Application.Run(new FormPrincipal());
        }
    }
}
