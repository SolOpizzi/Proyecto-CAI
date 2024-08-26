namespace Prototipo_CAI
{
    partial class Reservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsvReservas = new ListView();
            codReserva = new ColumnHeader();
            nombre = new ColumnHeader();
            fechaReserva = new ColumnHeader();
            estadoReserva = new ColumnHeader();
            btnConfirmarReserva = new Button();
            txtBuscarReserva = new TextBox();
            btnCancelarReserva = new Button();
            iconbtnBuscarItinerario = new FontAwesome.Sharp.IconButton();
            iconbtnRefrescaBuscarReserva = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lsvReservas
            // 
            lsvReservas.BackColor = Color.FromArgb(156, 184, 205);
            lsvReservas.Columns.AddRange(new ColumnHeader[] { codReserva, nombre, fechaReserva, estadoReserva });
            lsvReservas.FullRowSelect = true;
            lsvReservas.Location = new Point(12, 12);
            lsvReservas.MultiSelect = false;
            lsvReservas.Name = "lsvReservas";
            lsvReservas.Size = new Size(776, 387);
            lsvReservas.TabIndex = 0;
            lsvReservas.UseCompatibleStateImageBehavior = false;
            lsvReservas.View = View.Details;
            lsvReservas.ColumnWidthChanged += lsvReservas_ColumnWidthChanged;
            lsvReservas.SelectedIndexChanged += lsvReservas_SelectedIndexChanged;
            // 
            // codReserva
            // 
            codReserva.Text = "Código";
            codReserva.Width = 150;
            // 
            // nombre
            // 
            nombre.Text = "Nombre/Razón Social";
            nombre.Width = 150;
            // 
            // fechaReserva
            // 
            fechaReserva.Text = "Fecha";
            fechaReserva.Width = 150;
            // 
            // estadoReserva
            // 
            estadoReserva.Text = "Estado";
            estadoReserva.Width = 150;
            // 
            // btnConfirmarReserva
            // 
            btnConfirmarReserva.BackColor = Color.FromArgb(8, 32, 50);
            btnConfirmarReserva.FlatAppearance.BorderSize = 0;
            btnConfirmarReserva.FlatStyle = FlatStyle.Flat;
            btnConfirmarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarReserva.ForeColor = Color.White;
            btnConfirmarReserva.Location = new Point(524, 405);
            btnConfirmarReserva.Name = "btnConfirmarReserva";
            btnConfirmarReserva.Size = new Size(129, 35);
            btnConfirmarReserva.TabIndex = 2;
            btnConfirmarReserva.Text = "Confirmar reserva";
            btnConfirmarReserva.UseVisualStyleBackColor = false;
            btnConfirmarReserva.Click += btnConfirmarReserva_Click;
            // 
            // txtBuscarReserva
            // 
            txtBuscarReserva.BackColor = Color.White;
            txtBuscarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarReserva.Location = new Point(12, 407);
            txtBuscarReserva.Name = "txtBuscarReserva";
            txtBuscarReserva.PlaceholderText = "Ingrese Código de Reserva...";
            txtBuscarReserva.Size = new Size(200, 25);
            txtBuscarReserva.TabIndex = 5;
            txtBuscarReserva.KeyDown += txtBuscarReserva_KeyDown;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.BackColor = Color.FromArgb(8, 32, 50);
            btnCancelarReserva.FlatAppearance.BorderSize = 0;
            btnCancelarReserva.FlatStyle = FlatStyle.Flat;
            btnCancelarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarReserva.ForeColor = Color.White;
            btnCancelarReserva.Location = new Point(659, 405);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(129, 35);
            btnCancelarReserva.TabIndex = 6;
            btnCancelarReserva.Text = "Cancelar Reserva";
            btnCancelarReserva.UseVisualStyleBackColor = false;
            btnCancelarReserva.Click += btnCancelarReserva_Click;
            // 
            // iconbtnBuscarItinerario
            // 
            iconbtnBuscarItinerario.BackColor = Color.White;
            iconbtnBuscarItinerario.FlatStyle = FlatStyle.Flat;
            iconbtnBuscarItinerario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconbtnBuscarItinerario.IconColor = Color.Black;
            iconbtnBuscarItinerario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnBuscarItinerario.IconSize = 20;
            iconbtnBuscarItinerario.Location = new Point(218, 407);
            iconbtnBuscarItinerario.Name = "iconbtnBuscarItinerario";
            iconbtnBuscarItinerario.Size = new Size(25, 25);
            iconbtnBuscarItinerario.TabIndex = 17;
            iconbtnBuscarItinerario.UseVisualStyleBackColor = false;
            iconbtnBuscarItinerario.Click += iconbtnBuscarItinerario_Click;
            // 
            // iconbtnRefrescaBuscarReserva
            // 
            iconbtnRefrescaBuscarReserva.BackColor = Color.White;
            iconbtnRefrescaBuscarReserva.FlatStyle = FlatStyle.Flat;
            iconbtnRefrescaBuscarReserva.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            iconbtnRefrescaBuscarReserva.IconColor = Color.Black;
            iconbtnRefrescaBuscarReserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnRefrescaBuscarReserva.IconSize = 20;
            iconbtnRefrescaBuscarReserva.Location = new Point(249, 407);
            iconbtnRefrescaBuscarReserva.Name = "iconbtnRefrescaBuscarReserva";
            iconbtnRefrescaBuscarReserva.Size = new Size(25, 25);
            iconbtnRefrescaBuscarReserva.TabIndex = 18;
            iconbtnRefrescaBuscarReserva.UseVisualStyleBackColor = false;
            iconbtnRefrescaBuscarReserva.Click += iconbtnRefrescaBuscarReserva_Click_1;
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 124, 153);
            ClientSize = new Size(800, 444);
            Controls.Add(iconbtnRefrescaBuscarReserva);
            Controls.Add(iconbtnBuscarItinerario);
            Controls.Add(btnCancelarReserva);
            Controls.Add(txtBuscarReserva);
            Controls.Add(btnConfirmarReserva);
            Controls.Add(lsvReservas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Reservas";
            Text = "Reservas";
            Load += Reservas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvReservas;
        private Button btnConfirmarReserva;
        private TextBox txtBuscarReserva;
        private ColumnHeader codReserva;
        private ColumnHeader nombre;
        private ColumnHeader fechaReserva;
        private ColumnHeader estadoReserva;
        private Button btnCancelarReserva;
        private FontAwesome.Sharp.IconButton iconbtnBuscarItinerario;
        private FontAwesome.Sharp.IconButton iconbtnRefrescaBuscarReserva;
    }
}