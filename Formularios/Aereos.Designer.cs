namespace Prototipo_CAI
{
    partial class Aereos
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
            lsvAereos = new ListView();
            hdCodVuelo = new ColumnHeader();
            hdDestino = new ColumnHeader();
            hdFechaSalida = new ColumnHeader();
            hdOrigen = new ColumnHeader();
            hdTipoPasajero = new ColumnHeader();
            hdClase = new ColumnHeader();
            hdTarifa = new ColumnHeader();
            hdAsientosDisp = new ColumnHeader();
            hdFechaLlegada = new ColumnHeader();
            hdTiempoVuelo = new ColumnHeader();
            hdAerolinea = new ColumnHeader();
            hdCodigoTarifaVuelo = new ColumnHeader();
            grpAereos = new GroupBox();
            iconbtnLimpiarBuscarItinerario = new FontAwesome.Sharp.IconButton();
            lblTipoPasajeroAereos = new Label();
            cmbTipoPasajeroAereos = new ComboBox();
            cmbClaseAereos = new ComboBox();
            lblClaseAereos = new Label();
            lblFechaIdaAereos = new Label();
            dtFechaDesdeAereos = new DateTimePicker();
            lblDestinoAereos = new Label();
            txtDestinoAereos = new TextBox();
            lblOrigenAereos = new Label();
            txtOrigenAereos = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnAgregarItinerarioAereos = new Button();
            lblAereosDisponibles = new Label();
            lblAereoEnItinerario = new Label();
            btnQuitarItinerarioAereos = new Button();
            lblItinerarioActivo = new Label();
            lsvItinerarioAereos = new ListView();
            hdCodigoTarifaVueloItinerario = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            lblSubTotal = new Label();
            grpAereos.SuspendLayout();
            SuspendLayout();
            // 
            // lsvAereos
            // 
            lsvAereos.BackColor = Color.FromArgb(156, 184, 205);
            lsvAereos.Columns.AddRange(new ColumnHeader[] { hdCodVuelo, hdDestino, hdFechaSalida, hdOrigen, hdTipoPasajero, hdClase, hdTarifa, hdAsientosDisp, hdFechaLlegada, hdTiempoVuelo, hdAerolinea, hdCodigoTarifaVuelo });
            lsvAereos.FullRowSelect = true;
            lsvAereos.Location = new Point(12, 42);
            lsvAereos.MultiSelect = false;
            lsvAereos.Name = "lsvAereos";
            lsvAereos.Size = new Size(507, 275);
            lsvAereos.TabIndex = 0;
            lsvAereos.UseCompatibleStateImageBehavior = false;
            lsvAereos.View = View.Details;
            lsvAereos.ColumnWidthChanged += lsvAereos_ColumnWidthChanged_1;
            lsvAereos.SelectedIndexChanged += lsvAereos_SelectedIndexChanged;
            // 
            // hdCodVuelo
            // 
            hdCodVuelo.Text = "Cod. Vuelo";
            hdCodVuelo.Width = 70;
            // 
            // hdDestino
            // 
            hdDestino.Text = "Destino";
            hdDestino.Width = 52;
            // 
            // hdFechaSalida
            // 
            hdFechaSalida.Text = "Fecha Salida";
            hdFechaSalida.Width = 77;
            // 
            // hdOrigen
            // 
            hdOrigen.Text = "Origen";
            hdOrigen.Width = 48;
            // 
            // hdTipoPasajero
            // 
            hdTipoPasajero.Text = "Tipo Pasajero";
            hdTipoPasajero.Width = 85;
            // 
            // hdClase
            // 
            hdClase.Text = "Clase";
            // 
            // hdTarifa
            // 
            hdTarifa.Text = "Tarifa";
            // 
            // hdAsientosDisp
            // 
            hdAsientosDisp.Text = "Asientos Disp.";
            hdAsientosDisp.Width = 85;
            // 
            // hdFechaLlegada
            // 
            hdFechaLlegada.Text = "Fecha Llegada";
            hdFechaLlegada.Width = 87;
            // 
            // hdTiempoVuelo
            // 
            hdTiempoVuelo.Text = "Tiempo Vuelo";
            hdTiempoVuelo.Width = 85;
            // 
            // hdAerolinea
            // 
            hdAerolinea.Text = "Aerolinea";
            // 
            // hdCodigoTarifaVuelo
            // 
            hdCodigoTarifaVuelo.Text = "CodigoTarifa";
            hdCodigoTarifaVuelo.Width = 1;
            // 
            // grpAereos
            // 
            grpAereos.BackColor = SystemColors.ActiveCaption;
            grpAereos.Controls.Add(iconbtnLimpiarBuscarItinerario);
            grpAereos.Controls.Add(lblTipoPasajeroAereos);
            grpAereos.Controls.Add(cmbTipoPasajeroAereos);
            grpAereos.Controls.Add(cmbClaseAereos);
            grpAereos.Controls.Add(lblClaseAereos);
            grpAereos.Controls.Add(lblFechaIdaAereos);
            grpAereos.Controls.Add(dtFechaDesdeAereos);
            grpAereos.Controls.Add(lblDestinoAereos);
            grpAereos.Controls.Add(txtDestinoAereos);
            grpAereos.Controls.Add(lblOrigenAereos);
            grpAereos.Controls.Add(txtOrigenAereos);
            grpAereos.ForeColor = Color.White;
            grpAereos.Location = new Point(12, 339);
            grpAereos.Name = "grpAereos";
            grpAereos.Size = new Size(1133, 87);
            grpAereos.TabIndex = 11;
            grpAereos.TabStop = false;
            grpAereos.Text = "Opciones de Búsqueda";
            // 
            // iconbtnLimpiarBuscarItinerario
            // 
            iconbtnLimpiarBuscarItinerario.BackColor = Color.White;
            iconbtnLimpiarBuscarItinerario.FlatStyle = FlatStyle.Flat;
            iconbtnLimpiarBuscarItinerario.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            iconbtnLimpiarBuscarItinerario.IconColor = Color.Black;
            iconbtnLimpiarBuscarItinerario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnLimpiarBuscarItinerario.IconSize = 20;
            iconbtnLimpiarBuscarItinerario.Location = new Point(1092, 45);
            iconbtnLimpiarBuscarItinerario.Name = "iconbtnLimpiarBuscarItinerario";
            iconbtnLimpiarBuscarItinerario.Size = new Size(25, 25);
            iconbtnLimpiarBuscarItinerario.TabIndex = 31;
            iconbtnLimpiarBuscarItinerario.UseVisualStyleBackColor = false;
            iconbtnLimpiarBuscarItinerario.Click += iconbtnLimpiarBuscarItinerario_Click;
            // 
            // lblTipoPasajeroAereos
            // 
            lblTipoPasajeroAereos.AutoSize = true;
            lblTipoPasajeroAereos.Location = new Point(684, 29);
            lblTipoPasajeroAereos.Name = "lblTipoPasajeroAereos";
            lblTipoPasajeroAereos.Size = new Size(77, 15);
            lblTipoPasajeroAereos.TabIndex = 29;
            lblTipoPasajeroAereos.Text = "Tipo Pasajero";
            // 
            // cmbTipoPasajeroAereos
            // 
            cmbTipoPasajeroAereos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPasajeroAereos.FormattingEnabled = true;
            cmbTipoPasajeroAereos.Items.AddRange(new object[] { "A", "M", "I" });
            cmbTipoPasajeroAereos.Location = new Point(684, 47);
            cmbTipoPasajeroAereos.Name = "cmbTipoPasajeroAereos";
            cmbTipoPasajeroAereos.Size = new Size(161, 23);
            cmbTipoPasajeroAereos.TabIndex = 28;
            cmbTipoPasajeroAereos.SelectedIndexChanged += cmbTipoPasajeroAereos_SelectedIndexChanged;
            // 
            // cmbClaseAereos
            // 
            cmbClaseAereos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClaseAereos.FormattingEnabled = true;
            cmbClaseAereos.Items.AddRange(new object[] { "E", "P", "B", "F" });
            cmbClaseAereos.Location = new Point(890, 47);
            cmbClaseAereos.Name = "cmbClaseAereos";
            cmbClaseAereos.Size = new Size(161, 23);
            cmbClaseAereos.TabIndex = 27;
            cmbClaseAereos.SelectedIndexChanged += cmbClaseAereos_SelectedIndexChanged;
            // 
            // lblClaseAereos
            // 
            lblClaseAereos.AutoSize = true;
            lblClaseAereos.Location = new Point(890, 29);
            lblClaseAereos.Name = "lblClaseAereos";
            lblClaseAereos.Size = new Size(35, 15);
            lblClaseAereos.TabIndex = 26;
            lblClaseAereos.Text = "Clase";
            // 
            // lblFechaIdaAereos
            // 
            lblFechaIdaAereos.AutoSize = true;
            lblFechaIdaAereos.Location = new Point(443, 29);
            lblFechaIdaAereos.Name = "lblFechaIdaAereos";
            lblFechaIdaAereos.Size = new Size(72, 15);
            lblFechaIdaAereos.TabIndex = 7;
            lblFechaIdaAereos.Text = "Fecha Salida";
            lblFechaIdaAereos.Click += lblFechaIdaAereos_Click;
            // 
            // dtFechaDesdeAereos
            // 
            dtFechaDesdeAereos.Format = DateTimePickerFormat.Short;
            dtFechaDesdeAereos.Location = new Point(443, 47);
            dtFechaDesdeAereos.Name = "dtFechaDesdeAereos";
            dtFechaDesdeAereos.Size = new Size(195, 23);
            dtFechaDesdeAereos.TabIndex = 6;
            dtFechaDesdeAereos.CloseUp += dtFechaDesdeAereos_CloseUp;
            dtFechaDesdeAereos.ValueChanged += dtFechaDesdeAereos_ValueChanged;
            // 
            // lblDestinoAereos
            // 
            lblDestinoAereos.AutoSize = true;
            lblDestinoAereos.Location = new Point(231, 29);
            lblDestinoAereos.Name = "lblDestinoAereos";
            lblDestinoAereos.Size = new Size(47, 15);
            lblDestinoAereos.TabIndex = 5;
            lblDestinoAereos.Text = "Destino";
            // 
            // txtDestinoAereos
            // 
            txtDestinoAereos.Location = new Point(231, 47);
            txtDestinoAereos.Name = "txtDestinoAereos";
            txtDestinoAereos.Size = new Size(161, 23);
            txtDestinoAereos.TabIndex = 4;
            txtDestinoAereos.TextChanged += txtDestinoAereos_TextChanged;
            // 
            // lblOrigenAereos
            // 
            lblOrigenAereos.AutoSize = true;
            lblOrigenAereos.Location = new Point(26, 29);
            lblOrigenAereos.Name = "lblOrigenAereos";
            lblOrigenAereos.Size = new Size(43, 15);
            lblOrigenAereos.TabIndex = 3;
            lblOrigenAereos.Text = "Origen";
            // 
            // txtOrigenAereos
            // 
            txtOrigenAereos.Location = new Point(27, 47);
            txtOrigenAereos.Name = "txtOrigenAereos";
            txtOrigenAereos.Size = new Size(161, 23);
            txtOrigenAereos.TabIndex = 2;
            txtOrigenAereos.TextChanged += txtOrigenAereos_TextChanged;
            // 
            // btnAgregarItinerarioAereos
            // 
            btnAgregarItinerarioAereos.BackColor = Color.FromArgb(8, 32, 50);
            btnAgregarItinerarioAereos.Enabled = false;
            btnAgregarItinerarioAereos.FlatAppearance.BorderSize = 0;
            btnAgregarItinerarioAereos.FlatStyle = FlatStyle.Flat;
            btnAgregarItinerarioAereos.ForeColor = Color.White;
            btnAgregarItinerarioAereos.Location = new Point(527, 141);
            btnAgregarItinerarioAereos.Name = "btnAgregarItinerarioAereos";
            btnAgregarItinerarioAereos.Size = new Size(102, 26);
            btnAgregarItinerarioAereos.TabIndex = 7;
            btnAgregarItinerarioAereos.Text = "Agregar >>>";
            btnAgregarItinerarioAereos.UseVisualStyleBackColor = false;
            btnAgregarItinerarioAereos.Click += btnAgregarItinerarioAereos_Click;
            // 
            // lblAereosDisponibles
            // 
            lblAereosDisponibles.AutoSize = true;
            lblAereosDisponibles.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAereosDisponibles.ForeColor = Color.White;
            lblAereosDisponibles.Location = new Point(12, 9);
            lblAereosDisponibles.Name = "lblAereosDisponibles";
            lblAereosDisponibles.Size = new Size(120, 30);
            lblAereosDisponibles.TabIndex = 17;
            lblAereosDisponibles.Text = "Disponibles";
            // 
            // lblAereoEnItinerario
            // 
            lblAereoEnItinerario.AutoSize = true;
            lblAereoEnItinerario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAereoEnItinerario.ForeColor = Color.White;
            lblAereoEnItinerario.Location = new Point(638, 9);
            lblAereoEnItinerario.Name = "lblAereoEnItinerario";
            lblAereoEnItinerario.Size = new Size(146, 30);
            lblAereoEnItinerario.TabIndex = 20;
            lblAereoEnItinerario.Text = "En el itinerario";
            // 
            // btnQuitarItinerarioAereos
            // 
            btnQuitarItinerarioAereos.BackColor = Color.FromArgb(8, 32, 50);
            btnQuitarItinerarioAereos.Enabled = false;
            btnQuitarItinerarioAereos.FlatAppearance.BorderSize = 0;
            btnQuitarItinerarioAereos.FlatStyle = FlatStyle.Flat;
            btnQuitarItinerarioAereos.ForeColor = Color.White;
            btnQuitarItinerarioAereos.Location = new Point(527, 190);
            btnQuitarItinerarioAereos.Name = "btnQuitarItinerarioAereos";
            btnQuitarItinerarioAereos.Size = new Size(102, 26);
            btnQuitarItinerarioAereos.TabIndex = 21;
            btnQuitarItinerarioAereos.Text = "<<< Quitar";
            btnQuitarItinerarioAereos.UseVisualStyleBackColor = false;
            btnQuitarItinerarioAereos.Click += btnQuitarItinerarioAereos_Click;
            // 
            // lblItinerarioActivo
            // 
            lblItinerarioActivo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblItinerarioActivo.ForeColor = Color.White;
            lblItinerarioActivo.Location = new Point(932, 19);
            lblItinerarioActivo.Name = "lblItinerarioActivo";
            lblItinerarioActivo.RightToLeft = RightToLeft.No;
            lblItinerarioActivo.Size = new Size(213, 18);
            lblItinerarioActivo.TabIndex = 27;
            lblItinerarioActivo.Text = "NO HAY ITINERARIO ACTIVO";
            lblItinerarioActivo.TextAlign = ContentAlignment.TopRight;
            // 
            // lsvItinerarioAereos
            // 
            lsvItinerarioAereos.BackColor = Color.FromArgb(156, 184, 205);
            lsvItinerarioAereos.Columns.AddRange(new ColumnHeader[] { hdCodigoTarifaVueloItinerario, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15 });
            lsvItinerarioAereos.FullRowSelect = true;
            lsvItinerarioAereos.Location = new Point(638, 42);
            lsvItinerarioAereos.MultiSelect = false;
            lsvItinerarioAereos.Name = "lsvItinerarioAereos";
            lsvItinerarioAereos.Size = new Size(507, 275);
            lsvItinerarioAereos.TabIndex = 30;
            lsvItinerarioAereos.UseCompatibleStateImageBehavior = false;
            lsvItinerarioAereos.View = View.Details;
            lsvItinerarioAereos.ColumnWidthChanged += lsvItinerarioAereos_ColumnWidthChanged;
            lsvItinerarioAereos.SelectedIndexChanged += lsvItinerarioAereos_SelectedIndexChanged;
            // 
            // hdCodigoTarifaVueloItinerario
            // 
            hdCodigoTarifaVueloItinerario.Text = "Cod. Vuelo";
            hdCodigoTarifaVueloItinerario.Width = 1;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Destino";
            columnHeader6.Width = 52;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Fecha Salida";
            columnHeader7.Width = 77;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Origen";
            columnHeader8.Width = 48;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Tipo Pasajero";
            columnHeader9.Width = 85;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Clase";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Tarifa";
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Asientos Disp.";
            columnHeader12.Width = 85;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Fecha Llegada";
            columnHeader13.Width = 87;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Tiempo Vuelo";
            columnHeader14.Width = 85;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Aerolinea";
            // 
            // lblSubTotal
            // 
            lblSubTotal.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTotal.ForeColor = Color.White;
            lblSubTotal.Location = new Point(934, 320);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.RightToLeft = RightToLeft.No;
            lblSubTotal.Size = new Size(213, 18);
            lblSubTotal.TabIndex = 31;
            lblSubTotal.Text = "Subtotal: -";
            lblSubTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // Aereos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 124, 153);
            ClientSize = new Size(1159, 456);
            Controls.Add(lblSubTotal);
            Controls.Add(lsvItinerarioAereos);
            Controls.Add(lblItinerarioActivo);
            Controls.Add(btnQuitarItinerarioAereos);
            Controls.Add(lblAereoEnItinerario);
            Controls.Add(lblAereosDisponibles);
            Controls.Add(grpAereos);
            Controls.Add(btnAgregarItinerarioAereos);
            Controls.Add(lsvAereos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Aereos";
            Text = "Aéreos Disponibles";
            FormClosed += Aereos_FormClosed;
            Load += Aereos_Load;
            grpAereos.ResumeLayout(false);
            grpAereos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvProductosDisponibles;
        private Button btnDetalles;
        private GroupBox grpAereos;
        private Label lblFechaIdaAereos;
        private DateTimePicker dtFechaDesdeAereos;
        private Label lblDestinoAereos;
        private TextBox txtDestinoAereos;
        private Label lblOrigenAereos;
        private TextBox txtOrigenAereos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView lsvAereos;
        private Label lblTipoPasajeroAereos;
        private ComboBox cmbTipoPasajeroAereos;
        private ComboBox cmbClaseAereos;
        private Label lblClaseAereos;
        private Button btnAgregarItinerarioAereos;
        private Label lblAereosDisponibles;
        private Label lblAereoEnItinerario;
        private Button btnQuitarItinerarioAereos;
        private ColumnHeader hdCodVuelo;
        private ColumnHeader hdDestino;
        private ColumnHeader hdFechaSalida;
        private ColumnHeader hdFechaLlegada;
        private ColumnHeader hdOrigen;
        private ColumnHeader hdTiempoVuelo;
        private ColumnHeader hdAerolinea;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label lblItinerarioActivo;
        private ColumnHeader hdTipoPasajero;
        private ColumnHeader hdClase;
        private ColumnHeader hdTarifa;
        private ColumnHeader hdAsientosDisp;
        private ListView lsvItinerarioAereos;
        private ColumnHeader hdCodigoTarifaVueloItinerario;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private FontAwesome.Sharp.IconButton iconbtnLimpiarBuscarItinerario;
        private ColumnHeader hdCodigoTarifaVuelo;
        private Label lblSubTotal;
    }
}