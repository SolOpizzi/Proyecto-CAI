namespace Prototipo_CAI
{
    partial class CrearReserva
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
            lblNombrePasajero = new Label();
            txtNombrePasajero = new TextBox();
            txtDNIPasajero = new TextBox();
            lblDNIPasajero = new Label();
            dtpNacimientoP = new DateTimePicker();
            lblFechaNacPasajero = new Label();
            lblNacionalidadPasajero = new Label();
            lblGeneroPasajero = new Label();
            cmbNacionalidad = new ComboBox();
            cmbGenero = new ComboBox();
            btnCerrarCrearReserva = new Button();
            chklbTarifasAsignadas = new CheckedListBox();
            btnAgregarPasajero = new Button();
            lsvTarifasReserva = new ListView();
            hdNombreApellidoPasajero = new ColumnHeader();
            hdDNIPasajero = new ColumnHeader();
            hdNacionalidadPasajero = new ColumnHeader();
            hdGeneroPasajero = new ColumnHeader();
            hdFechaNacPasajero = new ColumnHeader();
            hdTarifasPasajero = new ColumnHeader();
            gpbDatosPasajero = new GroupBox();
            btnLimpiarDatosPasajero = new Button();
            lblTarifasAsignadas = new Label();
            btnEliminarPasajero = new Button();
            btnCrearReserva = new Button();
            gpbDatosPasajero.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombrePasajero
            // 
            lblNombrePasajero.AutoSize = true;
            lblNombrePasajero.Location = new Point(17, 29);
            lblNombrePasajero.Name = "lblNombrePasajero";
            lblNombrePasajero.Size = new Size(107, 15);
            lblNombrePasajero.TabIndex = 0;
            lblNombrePasajero.Text = "Nombre y Apellido";
            // 
            // txtNombrePasajero
            // 
            txtNombrePasajero.BackColor = Color.White;
            txtNombrePasajero.Location = new Point(17, 47);
            txtNombrePasajero.Name = "txtNombrePasajero";
            txtNombrePasajero.Size = new Size(216, 23);
            txtNombrePasajero.TabIndex = 1;
            txtNombrePasajero.TextChanged += txtNombrePasajero_TextChanged;
            // 
            // txtDNIPasajero
            // 
            txtDNIPasajero.BackColor = Color.White;
            txtDNIPasajero.Location = new Point(250, 47);
            txtDNIPasajero.Name = "txtDNIPasajero";
            txtDNIPasajero.Size = new Size(216, 23);
            txtDNIPasajero.TabIndex = 3;
            // 
            // lblDNIPasajero
            // 
            lblDNIPasajero.AutoSize = true;
            lblDNIPasajero.Location = new Point(250, 29);
            lblDNIPasajero.Name = "lblDNIPasajero";
            lblDNIPasajero.Size = new Size(27, 15);
            lblDNIPasajero.TabIndex = 2;
            lblDNIPasajero.Text = "DNI";
            // 
            // dtpNacimientoP
            // 
            dtpNacimientoP.CalendarMonthBackground = Color.White;
            dtpNacimientoP.Format = DateTimePickerFormat.Short;
            dtpNacimientoP.Location = new Point(17, 155);
            dtpNacimientoP.Name = "dtpNacimientoP";
            dtpNacimientoP.Size = new Size(216, 23);
            dtpNacimientoP.TabIndex = 6;
            // 
            // lblFechaNacPasajero
            // 
            lblFechaNacPasajero.AutoSize = true;
            lblFechaNacPasajero.Location = new Point(17, 137);
            lblFechaNacPasajero.Name = "lblFechaNacPasajero";
            lblFechaNacPasajero.Size = new Size(119, 15);
            lblFechaNacPasajero.TabIndex = 7;
            lblFechaNacPasajero.Text = "Fecha de Nacimiento";
            // 
            // lblNacionalidadPasajero
            // 
            lblNacionalidadPasajero.AutoSize = true;
            lblNacionalidadPasajero.Location = new Point(17, 81);
            lblNacionalidadPasajero.Name = "lblNacionalidadPasajero";
            lblNacionalidadPasajero.Size = new Size(77, 15);
            lblNacionalidadPasajero.TabIndex = 8;
            lblNacionalidadPasajero.Text = "Nacionalidad";
            // 
            // lblGeneroPasajero
            // 
            lblGeneroPasajero.AutoSize = true;
            lblGeneroPasajero.Location = new Point(250, 81);
            lblGeneroPasajero.Name = "lblGeneroPasajero";
            lblGeneroPasajero.Size = new Size(45, 15);
            lblGeneroPasajero.TabIndex = 10;
            lblGeneroPasajero.Text = "Género";
            // 
            // cmbNacionalidad
            // 
            cmbNacionalidad.BackColor = Color.White;
            cmbNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNacionalidad.FormattingEnabled = true;
            cmbNacionalidad.Items.AddRange(new object[] { "Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bahréin", "Bangladesh", "Barbados", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania (Myanmar)", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Ciudad del Vaticano", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Eswatini", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guyana", "Guinea", "Guinea-Bissau", "Guinea Ecuatorial", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macedonia del Norte", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumanía", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Suazilandia", "Sudáfrica", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zambia", "Zimbabue" });
            cmbNacionalidad.Location = new Point(17, 99);
            cmbNacionalidad.Name = "cmbNacionalidad";
            cmbNacionalidad.Size = new Size(216, 23);
            cmbNacionalidad.TabIndex = 11;
            // 
            // cmbGenero
            // 
            cmbGenero.BackColor = Color.White;
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro..." });
            cmbGenero.Location = new Point(250, 99);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(216, 23);
            cmbGenero.TabIndex = 12;
            // 
            // btnCerrarCrearReserva
            // 
            btnCerrarCrearReserva.BackColor = Color.FromArgb(8, 32, 50);
            btnCerrarCrearReserva.FlatAppearance.BorderSize = 0;
            btnCerrarCrearReserva.FlatStyle = FlatStyle.Flat;
            btnCerrarCrearReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarCrearReserva.ForeColor = Color.White;
            btnCerrarCrearReserva.Location = new Point(761, 545);
            btnCerrarCrearReserva.Name = "btnCerrarCrearReserva";
            btnCerrarCrearReserva.Size = new Size(155, 34);
            btnCerrarCrearReserva.TabIndex = 18;
            btnCerrarCrearReserva.Text = "Cerrar";
            btnCerrarCrearReserva.UseVisualStyleBackColor = false;
            btnCerrarCrearReserva.Click += btnCerrarCrearReserva_Click;
            // 
            // chklbTarifasAsignadas
            // 
            chklbTarifasAsignadas.BackColor = Color.FromArgb(156, 184, 205);
            chklbTarifasAsignadas.BorderStyle = BorderStyle.None;
            chklbTarifasAsignadas.FormattingEnabled = true;
            chklbTarifasAsignadas.Location = new Point(491, 42);
            chklbTarifasAsignadas.Name = "chklbTarifasAsignadas";
            chklbTarifasAsignadas.Size = new Size(399, 180);
            chklbTarifasAsignadas.TabIndex = 20;
            // 
            // btnAgregarPasajero
            // 
            btnAgregarPasajero.BackColor = Color.FromArgb(8, 32, 50);
            btnAgregarPasajero.FlatAppearance.BorderSize = 0;
            btnAgregarPasajero.FlatStyle = FlatStyle.Flat;
            btnAgregarPasajero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarPasajero.ForeColor = Color.White;
            btnAgregarPasajero.Location = new Point(12, 274);
            btnAgregarPasajero.Name = "btnAgregarPasajero";
            btnAgregarPasajero.Size = new Size(418, 34);
            btnAgregarPasajero.TabIndex = 21;
            btnAgregarPasajero.Text = "Agregar v v v";
            btnAgregarPasajero.UseVisualStyleBackColor = false;
            btnAgregarPasajero.Click += btnAgregarPasajero_Click;
            // 
            // lsvTarifasReserva
            // 
            lsvTarifasReserva.BackColor = Color.FromArgb(156, 184, 205);
            lsvTarifasReserva.Columns.AddRange(new ColumnHeader[] { hdNombreApellidoPasajero, hdDNIPasajero, hdNacionalidadPasajero, hdGeneroPasajero, hdFechaNacPasajero, hdTarifasPasajero });
            lsvTarifasReserva.FullRowSelect = true;
            lsvTarifasReserva.Location = new Point(12, 330);
            lsvTarifasReserva.MultiSelect = false;
            lsvTarifasReserva.Name = "lsvTarifasReserva";
            lsvTarifasReserva.Size = new Size(904, 209);
            lsvTarifasReserva.TabIndex = 22;
            lsvTarifasReserva.UseCompatibleStateImageBehavior = false;
            lsvTarifasReserva.View = View.Details;
            lsvTarifasReserva.ColumnWidthChanged += lsvTarifasReserva_ColumnWidthChanged;
            // 
            // hdNombreApellidoPasajero
            // 
            hdNombreApellidoPasajero.Text = "Nombre y Apellido";
            hdNombreApellidoPasajero.Width = 200;
            // 
            // hdDNIPasajero
            // 
            hdDNIPasajero.Text = "DNI";
            hdDNIPasajero.Width = 80;
            // 
            // hdNacionalidadPasajero
            // 
            hdNacionalidadPasajero.Text = "Nacionalidad";
            hdNacionalidadPasajero.Width = 100;
            // 
            // hdGeneroPasajero
            // 
            hdGeneroPasajero.Text = "Género";
            hdGeneroPasajero.Width = 100;
            // 
            // hdFechaNacPasajero
            // 
            hdFechaNacPasajero.Text = "Fecha de Nacimiento";
            hdFechaNacPasajero.Width = 130;
            // 
            // hdTarifasPasajero
            // 
            hdTarifasPasajero.Text = "Tarifas Asociadas";
            hdTarifasPasajero.Width = 390;
            // 
            // gpbDatosPasajero
            // 
            gpbDatosPasajero.Controls.Add(btnLimpiarDatosPasajero);
            gpbDatosPasajero.Controls.Add(lblTarifasAsignadas);
            gpbDatosPasajero.Controls.Add(txtDNIPasajero);
            gpbDatosPasajero.Controls.Add(lblNombrePasajero);
            gpbDatosPasajero.Controls.Add(txtNombrePasajero);
            gpbDatosPasajero.Controls.Add(chklbTarifasAsignadas);
            gpbDatosPasajero.Controls.Add(lblDNIPasajero);
            gpbDatosPasajero.Controls.Add(dtpNacimientoP);
            gpbDatosPasajero.Controls.Add(cmbGenero);
            gpbDatosPasajero.Controls.Add(lblFechaNacPasajero);
            gpbDatosPasajero.Controls.Add(cmbNacionalidad);
            gpbDatosPasajero.Controls.Add(lblNacionalidadPasajero);
            gpbDatosPasajero.Controls.Add(lblGeneroPasajero);
            gpbDatosPasajero.ForeColor = Color.White;
            gpbDatosPasajero.Location = new Point(12, 12);
            gpbDatosPasajero.Name = "gpbDatosPasajero";
            gpbDatosPasajero.Size = new Size(904, 242);
            gpbDatosPasajero.TabIndex = 24;
            gpbDatosPasajero.TabStop = false;
            gpbDatosPasajero.Text = "Datos Pasajero";
            // 
            // btnLimpiarDatosPasajero
            // 
            btnLimpiarDatosPasajero.BackColor = Color.FromArgb(8, 32, 50);
            btnLimpiarDatosPasajero.FlatAppearance.BorderSize = 0;
            btnLimpiarDatosPasajero.FlatStyle = FlatStyle.Flat;
            btnLimpiarDatosPasajero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarDatosPasajero.ForeColor = Color.White;
            btnLimpiarDatosPasajero.Location = new Point(17, 191);
            btnLimpiarDatosPasajero.Name = "btnLimpiarDatosPasajero";
            btnLimpiarDatosPasajero.Size = new Size(34, 34);
            btnLimpiarDatosPasajero.TabIndex = 27;
            btnLimpiarDatosPasajero.Text = "\U0001f9f9";
            btnLimpiarDatosPasajero.UseVisualStyleBackColor = false;
            btnLimpiarDatosPasajero.Click += btnLimpiarDatosPasajero_Click;
            // 
            // lblTarifasAsignadas
            // 
            lblTarifasAsignadas.AutoSize = true;
            lblTarifasAsignadas.Location = new Point(491, 24);
            lblTarifasAsignadas.Name = "lblTarifasAsignadas";
            lblTarifasAsignadas.Size = new Size(97, 15);
            lblTarifasAsignadas.TabIndex = 22;
            lblTarifasAsignadas.Text = "Tarifas Asignadas";
            // 
            // btnEliminarPasajero
            // 
            btnEliminarPasajero.BackColor = Color.FromArgb(8, 32, 50);
            btnEliminarPasajero.FlatAppearance.BorderSize = 0;
            btnEliminarPasajero.FlatStyle = FlatStyle.Flat;
            btnEliminarPasajero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarPasajero.ForeColor = Color.White;
            btnEliminarPasajero.Location = new Point(503, 274);
            btnEliminarPasajero.Name = "btnEliminarPasajero";
            btnEliminarPasajero.Size = new Size(413, 34);
            btnEliminarPasajero.TabIndex = 25;
            btnEliminarPasajero.Text = "Eliminar ^ ^ ^";
            btnEliminarPasajero.UseVisualStyleBackColor = false;
            btnEliminarPasajero.Click += btnEliminarPasajero_Click;
            // 
            // btnCrearReserva
            // 
            btnCrearReserva.BackColor = Color.FromArgb(8, 32, 50);
            btnCrearReserva.FlatAppearance.BorderSize = 0;
            btnCrearReserva.FlatStyle = FlatStyle.Flat;
            btnCrearReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearReserva.ForeColor = Color.White;
            btnCrearReserva.Location = new Point(600, 545);
            btnCrearReserva.Name = "btnCrearReserva";
            btnCrearReserva.Size = new Size(155, 34);
            btnCrearReserva.TabIndex = 26;
            btnCrearReserva.Text = "Crear reserva";
            btnCrearReserva.UseVisualStyleBackColor = false;
            btnCrearReserva.Click += btnCrearReserva_Click;
            // 
            // CrearReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 124, 153);
            ClientSize = new Size(928, 586);
            Controls.Add(btnCrearReserva);
            Controls.Add(btnEliminarPasajero);
            Controls.Add(gpbDatosPasajero);
            Controls.Add(lsvTarifasReserva);
            Controls.Add(btnCerrarCrearReserva);
            Controls.Add(btnAgregarPasajero);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CrearReserva";
            Text = "Crear Reserva";
            Load += CrearReserva_Load;
            gpbDatosPasajero.ResumeLayout(false);
            gpbDatosPasajero.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombrePasajero;
        private TextBox txtNombrePasajero;
        private TextBox txtDNIPasajero;
        private Label lblDNIPasajero;
        private DateTimePicker dtpNacimientoP;
        private Label lblFechaNacPasajero;
        private Label lblNacionalidadPasajero;
        private Label lblGeneroPasajero;
        private ComboBox cmbNacionalidad;
        private ComboBox cmbGenero;
        private Button btnCerrarCrearReserva;
        private CheckedListBox chklbTarifasAsignadas;
        private Button btnAgregarPasajero;
        private ListView lsvTarifasReserva;
        private GroupBox gpbDatosPasajero;
        private Label lblTarifasAsignadas;
        private Button btnEliminarPasajero;
        private Button btnCrearReserva;
        private ColumnHeader hdNombreApellidoPasajero;
        private ColumnHeader hdDNIPasajero;
        private ColumnHeader hdNacionalidadPasajero;
        private ColumnHeader hdGeneroPasajero;
        private ColumnHeader hdFechaNacPasajero;
        private ColumnHeader hdTarifasPasajero;
        private Button btnLimpiarDatosPasajero;
    }
}