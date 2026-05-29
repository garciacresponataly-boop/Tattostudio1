using System;
using System.Windows.Forms;
using TattoStudio.Modelo;
using TattoStudio.Servicios;
using TattoStudio.Utilidades;

namespace TattoStudio.Vista
{
    // ============================================================
    // FORMULARIO: FormRegistroTatuador
    // Muy similar a FormRegistroCliente, pero para tatuadores.
    // Nota cómo la estructura es la misma: recibe un gestor,
    // valida, crea el objeto y delega al servicio.
    // ============================================================
    public partial class FormRegistroTatuador : Form
    {
        private GestorTatuadores _gestorTatuadores;

        public FormRegistroTatuador(GestorTatuadores gestor)
        {
            InitializeComponent();
            _gestorTatuadores = gestor;
            CargarOpcionesEspecialidad();
        }

        private void CargarOpcionesEspecialidad()
        {
            foreach (TipoTatuaje tipo in Enum.GetValues(typeof(TipoTatuaje)))
            {
                cmbEspecialidad.Items.Add(tipo);
            }
            cmbEspecialidad.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre   = txtNombre.Text;
            string id       = txtId.Text;
            string telefono = txtTelefono.Text;

            string error = Validador.ValidarCamposPersona(nombre, id, telefono);
            if (error != string.Empty)
            {
                MostrarError(error);
                return;
            }

            if (cmbEspecialidad.SelectedItem == null)
            {
                MostrarError("Debes seleccionar una especialidad.");
                return;
            }

            TipoTatuaje especialidadSeleccionada = (TipoTatuaje)cmbEspecialidad.SelectedItem;

            try
            {
                Tatuador nuevoTatuador = new Tatuador(nombre, id, telefono, especialidadSeleccionada);
                _gestorTatuadores.AgregarTatuador(nuevoTatuador);

                MostrarExito($"✔ Tatuador '{nuevoTatuador.Nombre}' registrado correctamente.");
                ActualizarLista();
                LimpiarCampos();
            }
            catch (InvalidOperationException ex)
            {
                MostrarError(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MostrarError(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MostrarMensaje("", System.Drawing.Color.Gray);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstTatuadores.SelectedItem == null)
            {
                MostrarError("Selecciona un tatuador de la lista para eliminarlo.");
                return;
            }

            Tatuador seleccionado = lstTatuadores.SelectedItem as Tatuador;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Seguro que deseas eliminar a '{seleccionado.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                _gestorTatuadores.EliminarPorId(seleccionado.Id);
                MostrarExito($"Tatuador '{seleccionado.Nombre}' eliminado.");
                ActualizarLista();
            }
        }

        private void ActualizarLista()
        {
            lstTatuadores.Items.Clear();
            foreach (Tatuador t in _gestorTatuadores.ObtenerTodos())
            {
                lstTatuadores.Items.Add(t);
            }
            lblTotal.Text = $"Total: {_gestorTatuadores.ObtenerTotal()} tatuador(es)";
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtId.Clear();
            txtTelefono.Clear();
            cmbEspecialidad.SelectedIndex = 0;
            txtNombre.Focus();
        }

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
