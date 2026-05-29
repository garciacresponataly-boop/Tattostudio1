using System.Windows.Forms;
using TattoStudio.Servicios;

namespace TattoStudio.Vista
{
    // ============================================================
    // FORMULARIO: FormPrincipal
    // Es el menú de inicio de la aplicación. Desde aquí se abren
    // los otros formularios. Crea los gestores y los pasa a cada
    // formulario para que compartan la misma información.
    // ============================================================
    public partial class FormPrincipal : Form
    {
        // Los gestores se crean aquí y se comparten con los subformularios.
        // Así, si registras un cliente en FormRegistroCliente, la lista
        // permanece aunque cierres y abras el formulario de nuevo.
        private GestorClientes   _gestorClientes;
        private GestorTatuadores _gestorTatuadores;

        public FormPrincipal()
        {
            InitializeComponent();

            // Crear los gestores al iniciar la aplicación
            _gestorClientes   = new GestorClientes();
            _gestorTatuadores = new GestorTatuadores();

            ActualizarListas();
        }

        private void ActualizarListas()
        {
            lstClientes.Items.Clear();
            lstTatuadoresVista.Items.Clear();

            foreach (var cliente in _gestorClientes.ObtenerClientes())
            {
                lstClientes.Items.Add(cliente.Nombre + " - " + cliente.Telefono);
            }

            foreach (var tatuador in _gestorTatuadores.ObtenerTatuadores())
            {
                lstTatuadoresVista.Items.Add(tatuador.Nombre + " - " + tatuador.Especialidad);
            }
        }

        // --- Abrir ventana de clientes ---
        private void btnClientes_Click(object sender, System.EventArgs e)
        {
            // Pasar el gestor para que el formulario use la misma lista
            FormRegistroCliente ventanaClientes = new FormRegistroCliente(_gestorClientes);
            ventanaClientes.ShowDialog();

            ActualizarListas();
        }

        // --- Abrir ventana de tatuadores ---
        private void btnTatuadores_Click(object sender, System.EventArgs e)
        {
            FormRegistroTatuador ventanaTatuadores = new FormRegistroTatuador(_gestorTatuadores);
            ventanaTatuadores.ShowDialog();

            ActualizarListas();
        }
    }
}
