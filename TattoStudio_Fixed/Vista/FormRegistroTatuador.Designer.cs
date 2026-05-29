namespace TattoStudio.Vista
{
    partial class FormRegistroTatuador
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo        = new System.Windows.Forms.Label();
            this.lblNombre        = new System.Windows.Forms.Label();
            this.txtNombre        = new System.Windows.Forms.TextBox();
            this.lblId            = new System.Windows.Forms.Label();
            this.txtId            = new System.Windows.Forms.TextBox();
            this.lblTelefono      = new System.Windows.Forms.Label();
            this.txtTelefono      = new System.Windows.Forms.TextBox();
            this.lblEspecialidad  = new System.Windows.Forms.Label();
            this.cmbEspecialidad  = new System.Windows.Forms.ComboBox();
            this.btnRegistrar     = new System.Windows.Forms.Button();
            this.btnLimpiar       = new System.Windows.Forms.Button();
            this.btnCerrar        = new System.Windows.Forms.Button();
            this.lblMensaje       = new System.Windows.Forms.Label();
            this.lstTatuadores    = new System.Windows.Forms.ListBox();
            this.lblListaTitle    = new System.Windows.Forms.Label();
            this.btnEliminar      = new System.Windows.Forms.Button();
            this.lblTotal         = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // --- Título ---
            this.lblTitulo.Text      = "✏ Registro de Tatuadores";
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(40, 80, 160);
            this.lblTitulo.Location  = new System.Drawing.Point(20, 15);
            this.lblTitulo.Size      = new System.Drawing.Size(360, 35);

            // --- Nombre ---
            this.lblNombre.Text     = "Nombre completo:";
            this.lblNombre.Location = new System.Drawing.Point(20, 65);
            this.lblNombre.Size     = new System.Drawing.Size(130, 20);

            this.txtNombre.Location  = new System.Drawing.Point(160, 62);
            this.txtNombre.Size      = new System.Drawing.Size(220, 22);
            this.txtNombre.MaxLength = 80;

            // --- ID ---
            this.lblId.Text     = "ID / Documento:";
            this.lblId.Location = new System.Drawing.Point(20, 100);
            this.lblId.Size     = new System.Drawing.Size(130, 20);

            this.txtId.Location  = new System.Drawing.Point(160, 97);
            this.txtId.Size      = new System.Drawing.Size(220, 22);
            this.txtId.MaxLength = 20;

            // --- Teléfono ---
            this.lblTelefono.Text     = "Teléfono:";
            this.lblTelefono.Location = new System.Drawing.Point(20, 135);
            this.lblTelefono.Size     = new System.Drawing.Size(130, 20);

            this.txtTelefono.Location  = new System.Drawing.Point(160, 132);
            this.txtTelefono.Size      = new System.Drawing.Size(220, 22);
            this.txtTelefono.MaxLength = 15;

            // --- Especialidad (en vez de "tipo de tatuaje") ---
            this.lblEspecialidad.Text     = "Especializado en:";
            this.lblEspecialidad.Location = new System.Drawing.Point(20, 170);
            this.lblEspecialidad.Size     = new System.Drawing.Size(130, 20);

            this.cmbEspecialidad.Location      = new System.Drawing.Point(160, 167);
            this.cmbEspecialidad.Size          = new System.Drawing.Size(220, 22);
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // --- Mensaje ---
            this.lblMensaje.Text     = "";
            this.lblMensaje.Location = new System.Drawing.Point(20, 205);
            this.lblMensaje.Size     = new System.Drawing.Size(360, 20);
            this.lblMensaje.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);

            // --- Botón Registrar ---
            this.btnRegistrar.Text      = "✔ Registrar tatuador";
            this.btnRegistrar.Location  = new System.Drawing.Point(20, 235);
            this.btnRegistrar.Size      = new System.Drawing.Size(155, 32);
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(40, 80, 160);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Click    += new System.EventHandler(this.btnRegistrar_Click);

            // --- Botón Limpiar ---
            this.btnLimpiar.Text      = "↺ Limpiar";
            this.btnLimpiar.Location  = new System.Drawing.Point(190, 235);
            this.btnLimpiar.Size      = new System.Drawing.Size(85, 32);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Click    += new System.EventHandler(this.btnLimpiar_Click);

            // --- Botón Cerrar ---
            this.btnCerrar.Text      = "✕ Cerrar";
            this.btnCerrar.Location  = new System.Drawing.Point(290, 235);
            this.btnCerrar.Size      = new System.Drawing.Size(90, 32);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Click    += new System.EventHandler(this.btnCerrar_Click);

            // --- Lista de tatuadores ---
            this.lblListaTitle.Text     = "Tatuadores registrados:";
            this.lblListaTitle.Font     = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblListaTitle.Location = new System.Drawing.Point(20, 285);
            this.lblListaTitle.Size     = new System.Drawing.Size(200, 20);

            this.lstTatuadores.Location            = new System.Drawing.Point(20, 310);
            this.lstTatuadores.Size                = new System.Drawing.Size(360, 180);
            this.lstTatuadores.Font                = new System.Drawing.Font("Segoe UI", 9F);
            this.lstTatuadores.HorizontalScrollbar  = true;

            // --- Botón Eliminar ---
            this.btnEliminar.Text      = "🗑 Eliminar seleccionado";
            this.btnEliminar.Location  = new System.Drawing.Point(20, 500);
            this.btnEliminar.Size      = new System.Drawing.Size(180, 30);
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Click    += new System.EventHandler(this.btnEliminar_Click);

            // --- Total ---
            this.lblTotal.Text     = "Total: 0 tatuadores";
            this.lblTotal.Location = new System.Drawing.Point(220, 505);
            this.lblTotal.Size     = new System.Drawing.Size(160, 20);
            this.lblTotal.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);

            // --- Configuración del formulario ---
            this.ClientSize  = new System.Drawing.Size(400, 545);
            this.Text        = "TattoStudio - Tatuadores";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.BackColor   = System.Drawing.Color.FromArgb(235, 240, 250);

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblListaTitle);
            this.Controls.Add(this.lstTatuadores);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblTotal);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label     lblTitulo;
        private System.Windows.Forms.Label     lblNombre;
        private System.Windows.Forms.TextBox   txtNombre;
        private System.Windows.Forms.Label     lblId;
        private System.Windows.Forms.TextBox   txtId;
        private System.Windows.Forms.Label     lblTelefono;
        private System.Windows.Forms.TextBox   txtTelefono;
        private System.Windows.Forms.Label     lblEspecialidad;
        private System.Windows.Forms.ComboBox  cmbEspecialidad;
        private System.Windows.Forms.Button    btnRegistrar;
        private System.Windows.Forms.Button    btnLimpiar;
        private System.Windows.Forms.Button    btnCerrar;
        private System.Windows.Forms.Label     lblMensaje;
        private System.Windows.Forms.ListBox   lstTatuadores;
        private System.Windows.Forms.Label     lblListaTitle;
        private System.Windows.Forms.Button    btnEliminar;
        private System.Windows.Forms.Label     lblTotal;
    }
}
