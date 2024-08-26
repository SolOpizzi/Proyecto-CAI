namespace Prototipo_CAI
{
    partial class Itinerarios
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
            lsvItinerario = new ListView();
            hdCodItinerario = new ColumnHeader();
            hdCUILCUIT = new ColumnHeader();
            hdNombre = new ColumnHeader();
            hdReservado = new ColumnHeader();
            hdPrecio = new ColumnHeader();
            fileSystemWatcher1 = new FileSystemWatcher();
            txtBuscarItinerario = new TextBox();
            lblItinerarios = new Label();
            panelMenuItinerario = new Panel();
            iconbtnCrearReservaItinerario = new FontAwesome.Sharp.IconButton();
            iconbtnEliminarItinerario = new FontAwesome.Sharp.IconButton();
            iconbtnEstItinerarioActivo = new FontAwesome.Sharp.IconButton();
            iconbtnDatosCliente = new FontAwesome.Sharp.IconButton();
            iconbtnNuevoItinerario = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnModificar = new Button();
            lblNombreSubmenu = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblCuilCuit = new Label();
            lblNombreCliente = new Label();
            txtCuilCuit = new TextBox();
            txtNombreCliente = new TextBox();
            iconbtnLimpiarBuscarItinerario = new FontAwesome.Sharp.IconButton();
            iconbtnBuscarItinerario = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panelMenuItinerario.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lsvItinerario
            // 
            lsvItinerario.BackColor = Color.FromArgb(214, 237, 255);
            lsvItinerario.BorderStyle = BorderStyle.None;
            lsvItinerario.Columns.AddRange(new ColumnHeader[] { hdCodItinerario, hdCUILCUIT, hdNombre, hdReservado, hdPrecio });
            lsvItinerario.FullRowSelect = true;
            lsvItinerario.Location = new Point(226, 45);
            lsvItinerario.MultiSelect = false;
            lsvItinerario.Name = "lsvItinerario";
            lsvItinerario.Size = new Size(495, 262);
            lsvItinerario.TabIndex = 1;
            lsvItinerario.UseCompatibleStateImageBehavior = false;
            lsvItinerario.View = View.Details;
            lsvItinerario.ColumnWidthChanged += lsvItinerario_ColumnWidthChanged;
            lsvItinerario.SelectedIndexChanged += lsvItinerario_SelectedIndexChanged;
            // 
            // hdCodItinerario
            // 
            hdCodItinerario.Text = "Código";
            hdCodItinerario.Width = 51;
            // 
            // hdCUILCUIT
            // 
            hdCUILCUIT.Text = "CUIL/CUIT";
            hdCUILCUIT.Width = 100;
            // 
            // hdNombre
            // 
            hdNombre.Text = "Nombre/Razón Social";
            hdNombre.Width = 170;
            // 
            // hdReservado
            // 
            hdReservado.Text = "Reservado";
            hdReservado.Width = 70;
            // 
            // hdPrecio
            // 
            hdPrecio.Text = "Precio Total";
            hdPrecio.Width = 80;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtBuscarItinerario
            // 
            txtBuscarItinerario.BackColor = Color.White;
            txtBuscarItinerario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarItinerario.Location = new Point(421, 13);
            txtBuscarItinerario.Name = "txtBuscarItinerario";
            txtBuscarItinerario.PlaceholderText = "Filtrar por...";
            txtBuscarItinerario.Size = new Size(228, 25);
            txtBuscarItinerario.TabIndex = 8;
            // 
            // lblItinerarios
            // 
            lblItinerarios.AutoSize = true;
            lblItinerarios.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblItinerarios.Location = new Point(226, 8);
            lblItinerarios.Name = "lblItinerarios";
            lblItinerarios.Size = new Size(105, 30);
            lblItinerarios.TabIndex = 10;
            lblItinerarios.Text = "Itinerarios";
            // 
            // panelMenuItinerario
            // 
            panelMenuItinerario.BackColor = Color.FromArgb(8, 32, 50);
            panelMenuItinerario.Controls.Add(iconbtnCrearReservaItinerario);
            panelMenuItinerario.Controls.Add(iconbtnEliminarItinerario);
            panelMenuItinerario.Controls.Add(iconbtnEstItinerarioActivo);
            panelMenuItinerario.Controls.Add(iconbtnDatosCliente);
            panelMenuItinerario.Controls.Add(iconbtnNuevoItinerario);
            panelMenuItinerario.Dock = DockStyle.Left;
            panelMenuItinerario.Location = new Point(0, 0);
            panelMenuItinerario.Name = "panelMenuItinerario";
            panelMenuItinerario.Size = new Size(220, 307);
            panelMenuItinerario.TabIndex = 13;
            // 
            // iconbtnCrearReservaItinerario
            // 
            iconbtnCrearReservaItinerario.Dock = DockStyle.Top;
            iconbtnCrearReservaItinerario.FlatAppearance.BorderSize = 0;
            iconbtnCrearReservaItinerario.FlatStyle = FlatStyle.Flat;
            iconbtnCrearReservaItinerario.ForeColor = Color.White;
            iconbtnCrearReservaItinerario.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconbtnCrearReservaItinerario.IconColor = Color.White;
            iconbtnCrearReservaItinerario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnCrearReservaItinerario.IconSize = 32;
            iconbtnCrearReservaItinerario.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnCrearReservaItinerario.Location = new Point(0, 240);
            iconbtnCrearReservaItinerario.Name = "iconbtnCrearReservaItinerario";
            iconbtnCrearReservaItinerario.Padding = new Padding(10, 0, 20, 0);
            iconbtnCrearReservaItinerario.Size = new Size(220, 60);
            iconbtnCrearReservaItinerario.TabIndex = 4;
            iconbtnCrearReservaItinerario.Text = "Crear reserva";
            iconbtnCrearReservaItinerario.TextAlign = ContentAlignment.MiddleLeft;
            iconbtnCrearReservaItinerario.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnCrearReservaItinerario.UseVisualStyleBackColor = true;
            iconbtnCrearReservaItinerario.Click += iconbtnCrearReservaItinerario_Click;
            // 
            // iconbtnEliminarItinerario
            // 
            iconbtnEliminarItinerario.Dock = DockStyle.Top;
            iconbtnEliminarItinerario.FlatAppearance.BorderSize = 0;
            iconbtnEliminarItinerario.FlatStyle = FlatStyle.Flat;
            iconbtnEliminarItinerario.ForeColor = Color.White;
            iconbtnEliminarItinerario.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconbtnEliminarItinerario.IconColor = Color.White;
            iconbtnEliminarItinerario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnEliminarItinerario.IconSize = 32;
            iconbtnEliminarItinerario.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnEliminarItinerario.Location = new Point(0, 180);
            iconbtnEliminarItinerario.Name = "iconbtnEliminarItinerario";
            iconbtnEliminarItinerario.Padding = new Padding(10, 0, 20, 0);
            iconbtnEliminarItinerario.Size = new Size(220, 60);
            iconbtnEliminarItinerario.TabIndex = 3;
            iconbtnEliminarItinerario.Text = "Eliminar";
            iconbtnEliminarItinerario.TextAlign = ContentAlignment.MiddleLeft;
            iconbtnEliminarItinerario.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnEliminarItinerario.UseVisualStyleBackColor = true;
            iconbtnEliminarItinerario.Click += iconbtnEliminarItinerario_Click;
            // 
            // iconbtnEstItinerarioActivo
            // 
            iconbtnEstItinerarioActivo.Dock = DockStyle.Top;
            iconbtnEstItinerarioActivo.FlatAppearance.BorderSize = 0;
            iconbtnEstItinerarioActivo.FlatStyle = FlatStyle.Flat;
            iconbtnEstItinerarioActivo.ForeColor = Color.White;
            iconbtnEstItinerarioActivo.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            iconbtnEstItinerarioActivo.IconColor = Color.White;
            iconbtnEstItinerarioActivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnEstItinerarioActivo.IconSize = 32;
            iconbtnEstItinerarioActivo.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnEstItinerarioActivo.Location = new Point(0, 120);
            iconbtnEstItinerarioActivo.Name = "iconbtnEstItinerarioActivo";
            iconbtnEstItinerarioActivo.Padding = new Padding(10, 0, 20, 0);
            iconbtnEstItinerarioActivo.Size = new Size(220, 60);
            iconbtnEstItinerarioActivo.TabIndex = 2;
            iconbtnEstItinerarioActivo.Text = "Establecer como activo";
            iconbtnEstItinerarioActivo.TextAlign = ContentAlignment.MiddleLeft;
            iconbtnEstItinerarioActivo.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnEstItinerarioActivo.UseVisualStyleBackColor = true;
            iconbtnEstItinerarioActivo.Click += iconbtnEstItinerarioActivo_Click;
            // 
            // iconbtnDatosCliente
            // 
            iconbtnDatosCliente.Dock = DockStyle.Top;
            iconbtnDatosCliente.FlatAppearance.BorderSize = 0;
            iconbtnDatosCliente.FlatStyle = FlatStyle.Flat;
            iconbtnDatosCliente.ForeColor = Color.White;
            iconbtnDatosCliente.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            iconbtnDatosCliente.IconColor = Color.White;
            iconbtnDatosCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnDatosCliente.IconSize = 32;
            iconbtnDatosCliente.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnDatosCliente.Location = new Point(0, 60);
            iconbtnDatosCliente.Name = "iconbtnDatosCliente";
            iconbtnDatosCliente.Padding = new Padding(10, 0, 20, 0);
            iconbtnDatosCliente.Size = new Size(220, 60);
            iconbtnDatosCliente.TabIndex = 1;
            iconbtnDatosCliente.Text = "Datos cliente";
            iconbtnDatosCliente.TextAlign = ContentAlignment.MiddleLeft;
            iconbtnDatosCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnDatosCliente.UseVisualStyleBackColor = true;
            iconbtnDatosCliente.Click += iconbtnDatosCliente_Click;
            // 
            // iconbtnNuevoItinerario
            // 
            iconbtnNuevoItinerario.Dock = DockStyle.Top;
            iconbtnNuevoItinerario.FlatAppearance.BorderSize = 0;
            iconbtnNuevoItinerario.FlatStyle = FlatStyle.Flat;
            iconbtnNuevoItinerario.ForeColor = Color.White;
            iconbtnNuevoItinerario.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconbtnNuevoItinerario.IconColor = Color.White;
            iconbtnNuevoItinerario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnNuevoItinerario.IconSize = 32;
            iconbtnNuevoItinerario.ImageAlign = ContentAlignment.MiddleLeft;
            iconbtnNuevoItinerario.Location = new Point(0, 0);
            iconbtnNuevoItinerario.Name = "iconbtnNuevoItinerario";
            iconbtnNuevoItinerario.Padding = new Padding(10, 0, 20, 0);
            iconbtnNuevoItinerario.Size = new Size(220, 60);
            iconbtnNuevoItinerario.TabIndex = 0;
            iconbtnNuevoItinerario.Text = "Nuevo";
            iconbtnNuevoItinerario.TextAlign = ContentAlignment.MiddleLeft;
            iconbtnNuevoItinerario.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnNuevoItinerario.UseVisualStyleBackColor = true;
            iconbtnNuevoItinerario.Click += iconbtnNuevoItinerario_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(lblNombreSubmenu);
            panel1.Controls.Add(btnAceptar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(lblCuilCuit);
            panel1.Controls.Add(lblNombreCliente);
            panel1.Controls.Add(txtCuilCuit);
            panel1.Controls.Add(txtNombreCliente);
            panel1.Location = new Point(727, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(306, 307);
            panel1.TabIndex = 14;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(8, 32, 50);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(19, 199);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(276, 23);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblNombreSubmenu
            // 
            lblNombreSubmenu.AutoSize = true;
            lblNombreSubmenu.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreSubmenu.Location = new Point(19, 12);
            lblNombreSubmenu.Name = "lblNombreSubmenu";
            lblNombreSubmenu.Size = new Size(181, 30);
            lblNombreSubmenu.TabIndex = 15;
            lblNombreSubmenu.Text = "LABEL DINÁMICO";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(8, 32, 50);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(19, 228);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(276, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(8, 32, 50);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(19, 257);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(276, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCuilCuit
            // 
            lblCuilCuit.AutoSize = true;
            lblCuilCuit.ForeColor = Color.Black;
            lblCuilCuit.Location = new Point(19, 120);
            lblCuilCuit.Name = "lblCuilCuit";
            lblCuilCuit.Size = new Size(62, 15);
            lblCuilCuit.TabIndex = 10;
            lblCuilCuit.Text = "CUIL/CUIT";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.ForeColor = Color.Black;
            lblNombreCliente.Location = new Point(19, 62);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(122, 15);
            lblNombreCliente.TabIndex = 9;
            lblNombreCliente.Text = "Nombre/Razón Social";
            // 
            // txtCuilCuit
            // 
            txtCuilCuit.BackColor = Color.FromArgb(214, 237, 255);
            txtCuilCuit.Location = new Point(19, 140);
            txtCuilCuit.Name = "txtCuilCuit";
            txtCuilCuit.Size = new Size(276, 23);
            txtCuilCuit.TabIndex = 8;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = Color.FromArgb(214, 237, 255);
            txtNombreCliente.Location = new Point(19, 80);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(276, 23);
            txtNombreCliente.TabIndex = 7;
            // 
            // iconbtnLimpiarBuscarItinerario
            // 
            iconbtnLimpiarBuscarItinerario.BackColor = Color.White;
            iconbtnLimpiarBuscarItinerario.FlatStyle = FlatStyle.Flat;
            iconbtnLimpiarBuscarItinerario.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            iconbtnLimpiarBuscarItinerario.IconColor = Color.Black;
            iconbtnLimpiarBuscarItinerario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnLimpiarBuscarItinerario.IconSize = 20;
            iconbtnLimpiarBuscarItinerario.Location = new Point(686, 13);
            iconbtnLimpiarBuscarItinerario.Name = "iconbtnLimpiarBuscarItinerario";
            iconbtnLimpiarBuscarItinerario.Size = new Size(25, 25);
            iconbtnLimpiarBuscarItinerario.TabIndex = 15;
            iconbtnLimpiarBuscarItinerario.UseVisualStyleBackColor = false;
            iconbtnLimpiarBuscarItinerario.Click += iconbtnLimpiarBuscarItinerario_Click;
            // 
            // iconbtnBuscarItinerario
            // 
            iconbtnBuscarItinerario.BackColor = Color.White;
            iconbtnBuscarItinerario.FlatStyle = FlatStyle.Flat;
            iconbtnBuscarItinerario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconbtnBuscarItinerario.IconColor = Color.Black;
            iconbtnBuscarItinerario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnBuscarItinerario.IconSize = 20;
            iconbtnBuscarItinerario.Location = new Point(655, 13);
            iconbtnBuscarItinerario.Name = "iconbtnBuscarItinerario";
            iconbtnBuscarItinerario.Size = new Size(25, 25);
            iconbtnBuscarItinerario.TabIndex = 16;
            iconbtnBuscarItinerario.UseVisualStyleBackColor = false;
            iconbtnBuscarItinerario.Click += iconbtnBuscarItinerario_Click;
            // 
            // Itinerarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 237, 255);
            ClientSize = new Size(1034, 307);
            Controls.Add(iconbtnBuscarItinerario);
            Controls.Add(iconbtnLimpiarBuscarItinerario);
            Controls.Add(panel1);
            Controls.Add(panelMenuItinerario);
            Controls.Add(lblItinerarios);
            Controls.Add(txtBuscarItinerario);
            Controls.Add(lsvItinerario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(50, 50);
            MaximizeBox = false;
            Name = "Itinerarios";
            Text = "Itinerarios";
            Load += Itinerarios_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panelMenuItinerario.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvItinerario;
        private ColumnHeader hdCUILCUIT;
        private ColumnHeader hdCodItinerario;
        private Button btnNuevoItinerario;
        private Button btnEstItinerarioActivo;
        private Button btnEliminarItinerario;
        private ColumnHeader hdNombre;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox txtBuscarItinerario;
        private Label lblItinerarios;
        private Button btnCrearReservaItinerario;
        private Button btnDatosCliente;
        private Panel panelMenuItinerario;
        private FontAwesome.Sharp.IconButton iconbtnNuevoItinerario;
        private FontAwesome.Sharp.IconButton iconbtnCrearReservaItinerario;
        private FontAwesome.Sharp.IconButton iconbtnEliminarItinerario;
        private FontAwesome.Sharp.IconButton iconbtnEstItinerarioActivo;
        private FontAwesome.Sharp.IconButton iconbtnDatosCliente;
        private Panel panel1;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblCuilCuit;
        private Label lblNombreCliente;
        private TextBox txtCuilCuit;
        private TextBox txtNombreCliente;
        private Label lblNombreSubmenu;
        private Button btnModificar;
        private FontAwesome.Sharp.IconButton iconbtnLimpiarBuscarItinerario;
        private FontAwesome.Sharp.IconButton iconbtnBuscarItinerario;
        private ColumnHeader hdReservado;
        private ColumnHeader hdPrecio;
    }
}