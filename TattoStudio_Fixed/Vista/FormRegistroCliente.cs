using System;
using System.Windows.Forms;
using TattoStudio.Modelo;
using TattoStudio.Servicios;
using TattoStudio.Utilidades;

namespace TattoStudio.Vista
{
    // ============================================================
    // FORMULARIO: FormRegistroCliente
    // Maneja la interfaz gráfica para registrar, listar y
    // eliminar clientes. NO contiene lógica de negocio: esa
    // la delega al GestorClientes (Servicio).
    // ============================================================
    public partial class FormRegistroCliente : Form
    {
        // Referencia al gestor de clientes.
        // Se recibe desde afuera (por el constructor) para compartir
        // la misma lista entre diferentes ventanas si se necesita.
        private GestorClientes _gestorClientes;

        // Constructor: recibe el gestor para trabajar con él.
        public FormRegistroCliente(GestorClientes gestor)
        {
            InitializeComponent();
            _gestorClientes = gestor;

            // Cargar las opciones del ComboBox con los valores del enum TipoTatuaje
            CargarOpcionesTipoTatuaje();
        }

        // --- Llena el ComboBox con los valores del enum ---
        private void CargarOpcionesTipoTatuaje()
        {
            // Enum.GetValues devuelve todos los valores de un enum.
            foreach (TipoTatuaje tipo in Enum.GetValues(typeof(TipoTatuaje)))
            {
                cmbTipoTatuaje.Items.Add(tipo);
            }
            cmbTipoTatuaje.SelectedIndex = 0; // Seleccionar el primero por defecto
        }

        // --- Evento: clic en "Registrar cliente" ---
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Leer los datos del formulario
            string nombre   = txtNombre.Text;
            string id       = txtId.Text;
            string telefono = txtTelefono.Text;

            // 2. Validar con el Validador (clase de Utilidades)
            string error = Validador.ValidarCamposPersona(nombre, id, telefono);
            if (error != string.Empty)
            {
                MostrarError(error);
                return; // Detener si hay error
            }

            if (cmbTipoTatuaje.SelectedItem == null)
            {
                MostrarError("Debes seleccionar un tipo de tatuaje.");
                return;
            }

            // 3. Obtener el tipo de tatuaje seleccionado
            TipoTatuaje tipoSeleccionado = (TipoTatuaje)cmbTipoTatuaje.SelectedItem;

            // 4. Intentar crear y registrar el cliente
            try
            {
                // Crear el objeto Cliente (Modelo)
                Cliente nuevoCliente = new Cliente(nombre, id, telefono, tipoSeleccionado);

                // Registrarlo usando el servicio (no directamente en la lista)
                _gestorClientes.AgregarCliente(nuevoCliente);

                // 5. Actualizar la interfaz
                MostrarExito($"✔ Cliente '{nuevoCliente.Nombre}' registrado correctamente.");
                ActualizarLista();
                LimpiarCampos();
            }
            catch (InvalidOperationException ex)
            {
                // ID duplicado u otro error de negocio
                MostrarError(ex.Message);
            }
            catch (ArgumentException ex)
            {
                // Error en las propiedades del modelo
                MostrarError(ex.Message);
            }
        }

        // --- Evento: clic en "Limpiar" ---
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MostrarMensaje("", System.Drawing.Color.Gray);
        }

        // --- Evento: clic en "Cerrar" ---
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- Evento: clic en "Eliminar seleccionado" ---
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar que hay algo seleccionado en la lista
            if (lstClientes.SelectedItem == null)
            {
                MostrarError("Selecciona un cliente de la lista para eliminarlo.");
                return;
            }

            // Obtener el cliente seleccionado (el ListBox guarda objetos Cliente)
            Cliente seleccionado = lstClientes.SelectedItem as Cliente;

            // Confirmar antes de eliminar
            DialogResult confirmacion = MessageBox.Show(
                $"¿Seguro que deseas eliminar a '{seleccionado.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                _gestorClientes.EliminarPorId(seleccionado.Id);
                MostrarExito($"Cliente '{seleccionado.Nombre}' eliminado.");
                ActualizarLista();
            }
        }

        // --- Actualiza la lista visual con los clientes actuales ---
        private void ActualizarLista()
        {
            lstClientes.Items.Clear();

            foreach (Cliente c in _gestorClientes.ObtenerTodos())
            {
                // Agrega el objeto Cliente; se mostrará usando su ToString()
                lstClientes.Items.Add(c);
            }

            // Actualizar el contador
            lblTotal.Text = $"Total: {_gestorClientes.ObtenerTotal()} cliente(s)";
        }

        // --- Limpia todos los campos del formulario ---
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtId.Clear();
            txtTelefono.Clear();
            cmbTipoTatuaje.SelectedIndex = 0;
            txtNombre.Focus(); // Poner el cursor en el primer campo
        }

        // --- Métodos auxiliares para mostrar mensajes de colores ---
        private void MostrarError(string mensaje)
        {
            MostrarMensaje("⚠ " + mensaje, System.Drawing.Color.Crimson);
        }

        private void MostrarExito(string mensaje)
        {
            MostrarMensaje(mensaje, System.Drawing.Color.DarkGreen);
        }

        private void MostrarMensaje(string mensaje, System.Drawing.Color color)
        {
            lblMensaje.Text      = mensaje;
            lblMensaje.ForeColor = color;
        }
    }
}
