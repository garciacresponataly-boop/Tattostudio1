
namespace TattoStudio.Vista
{
    partial class FormPrincipal
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
            lblTitulo = new Label();
            btnClientes = new Button();
            btnTatuadores = new Button();
            lstClientes = new ListBox();
            lstTatuadoresVista = new ListBox();
            lblClientes = new Label();
            lblTatuadores = new Label();
            SuspendLayout();

            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(120, 90, 140);
            lblTitulo.Location = new Point(210, 20);
            lblTitulo.Text = "🖋 TattoStudio";

            btnClientes.BackColor = Color.FromArgb(255, 204, 213);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClientes.Location = new Point(40, 90);
            btnClientes.Size = new Size(250, 50);
            btnClientes.Text = "Registrar Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;

            btnTatuadores.BackColor = Color.FromArgb(189, 224, 254);
            btnTatuadores.FlatStyle = FlatStyle.Flat;
            btnTatuadores.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTatuadores.Location = new Point(320, 90);
            btnTatuadores.Size = new Size(250, 50);
            btnTatuadores.Text = "Registrar Tatuadores";
            btnTatuadores.UseVisualStyleBackColor = false;
            btnTatuadores.Click += btnTatuadores_Click;

            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblClientes.ForeColor = Color.FromArgb(90, 90, 90);
            lblClientes.Location = new Point(40, 170);
            lblClientes.Text = "Clientes Registrados";

            lstClientes.BackColor = Color.FromArgb(255, 240, 245);
            lstClientes.Font = new Font("Segoe UI", 10F);
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 23;
            lstClientes.Location = new Point(40, 200);
            lstClientes.Size = new Size(250, 188);

            lblTatuadores.AutoSize = true;
            lblTatuadores.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTatuadores.ForeColor = Color.FromArgb(90, 90, 90);
            lblTatuadores.Location = new Point(320, 170);
            lblTatuadores.Text = "Tatuadores Registrados";

            lstTatuadoresVista.BackColor = Color.FromArgb(240, 248, 255);
            lstTatuadoresVista.Font = new Font("Segoe UI", 10F);
            lstTatuadoresVista.FormattingEnabled = true;
            lstTatuadoresVista.ItemHeight = 23;
            lstTatuadoresVista.Location = new Point(320, 200);
            lstTatuadoresVista.Size = new Size(250, 188);

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 245, 255);
            ClientSize = new Size(620, 430);

            Controls.Add(lblTitulo);
            Controls.Add(btnClientes);
            Controls.Add(btnTatuadores);
            Controls.Add(lblClientes);
            Controls.Add(lstClientes);
            Controls.Add(lblTatuadores);
            Controls.Add(lstTatuadoresVista);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TattoStudio";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Button btnClientes;
        private Button btnTatuadores;
        private ListBox lstClientes;
        private ListBox lstTatuadoresVista;
        private Label lblClientes;
        private Label lblTatuadores;
    }
}
