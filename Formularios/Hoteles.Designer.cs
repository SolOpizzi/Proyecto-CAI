namespace Prototipo_CAI
{
    partial class Hoteles
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
            lblHoteles = new Label();
            grpHoteles = new GroupBox();
            lblTipoHabitacion = new Label();
            cmbTipoHabitacion = new ComboBox();
            iconbtnLimpiarBuscarHoteles = new FontAwesome.Sharp.IconButton();
            lblFechaHastaHoteles = new Label();
            lblUbicacionHoteles = new Label();
            dtpFechaHastaHoteles = new DateTimePicker();
            txtUbicacionHoteles = new TextBox();
            lblFechaDesdeHoteles = new Label();
            lblCantHabitacionesHoteles = new Label();
            dtpFechaDesdeHoteles = new DateTimePicker();
            cmbCalificacionHoteles = new ComboBox();
            txtHabitacionesHoteles = new TextBox();
            lblCalificacionHoteles = new Label();
            lsvHoteles = new ListView();
            hdCodHotel = new ColumnHeader();
            hdNombre = new ColumnHeader();
            hdCalificacion = new ColumnHeader();
            hdCiudad = new ColumnHeader();
            hdHabitacion = new ColumnHeader();
            hdTarifa = new ColumnHeader();
            hdCapacidad = new ColumnHeader();
            hdCodigoDisponibilidad = new ColumnHeader();
            btnAgregarItinerarioHoteles = new Button();
            lblItinerarioActivo = new Label();
            btnQuitarItinerarioHotel = new Button();
            lsvHotelesAgregados = new ListView();
            hdCodHotelItinerario = new ColumnHeader();
            hdNombreHotelItinerario = new ColumnHeader();
            hdCalificacionItinerario = new ColumnHeader();
            hdCiudadHotelItinerario = new ColumnHeader();
            hdTipoHabItinerario = new ColumnHeader();
            hdTarifaHotelItinerario = new ColumnHeader();
            hdCapacidadHotelItinerario = new ColumnHeader();
            hdCodigoDisponibilidadItinerario = new ColumnHeader();
            lblHotelEnItinerario = new Label();
            lblSubTotal = new Label();
            grpHoteles.SuspendLayout();
            SuspendLayout();
            // 
            // lblHoteles
            // 
            lblHoteles.AutoSize = true;
            lblHoteles.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoteles.ForeColor = Color.White;
            lblHoteles.Location = new Point(10, 7);
            lblHoteles.Name = "lblHoteles";
            lblHoteles.Size = new Size(120, 30);
            lblHoteles.TabIndex = 18;
            lblHoteles.Text = "Disponibles";
            // 
            // grpHoteles
            // 
            grpHoteles.BackColor = SystemColors.ActiveCaption;
            grpHoteles.Controls.Add(lblTipoHabitacion);
            grpHoteles.Controls.Add(cmbTipoHabitacion);
            grpHoteles.Controls.Add(iconbtnLimpiarBuscarHoteles);
            grpHoteles.Controls.Add(lblFechaHastaHoteles);
            grpHoteles.Controls.Add(lblUbicacionHoteles);
            grpHoteles.Controls.Add(dtpFechaHastaHoteles);
            grpHoteles.Controls.Add(txtUbicacionHoteles);
            grpHoteles.Controls.Add(lblFechaDesdeHoteles);
            grpHoteles.Controls.Add(lblCantHabitacionesHoteles);
            grpHoteles.Controls.Add(dtpFechaDesdeHoteles);
            grpHoteles.Controls.Add(cmbCalificacionHoteles);
            grpHoteles.Controls.Add(txtHabitacionesHoteles);
            grpHoteles.Controls.Add(lblCalificacionHoteles);
            grpHoteles.ForeColor = Color.White;
            grpHoteles.Location = new Point(12, 320);
            grpHoteles.Name = "grpHoteles";
            grpHoteles.Size = new Size(1057, 88);
            grpHoteles.TabIndex = 19;
            grpHoteles.TabStop = false;
            grpHoteles.Text = "Opciones de Búsqueda";
            // 
            // lblTipoHabitacion
            // 
            lblTipoHabitacion.AutoSize = true;
            lblTipoHabitacion.ForeColor = Color.White;
            lblTipoHabitacion.Location = new Point(806, 29);
            lblTipoHabitacion.Name = "lblTipoHabitacion";
            lblTipoHabitacion.Size = new Size(91, 15);
            lblTipoHabitacion.TabIndex = 20;
            lblTipoHabitacion.Text = "Tipo Habitación";
            // 
            // cmbTipoHabitacion
            // 
            cmbTipoHabitacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoHabitacion.FormattingEnabled = true;
            cmbTipoHabitacion.Items.AddRange(new object[] { "Individual", "Doble", "Matrimonial", "Suite", "Familiar", "Presidencial" });
            cmbTipoHabitacion.Location = new Point(806, 47);
            cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            cmbTipoHabitacion.Size = new Size(150, 23);
            cmbTipoHabitacion.TabIndex = 19;
            cmbTipoHabitacion.TextChanged += cmbTipoHabitacion_TextChanged;
            // 
            // iconbtnLimpiarBuscarHoteles
            // 
            iconbtnLimpiarBuscarHoteles.BackColor = Color.White;
            iconbtnLimpiarBuscarHoteles.FlatStyle = FlatStyle.Flat;
            iconbtnLimpiarBuscarHoteles.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            iconbtnLimpiarBuscarHoteles.IconColor = Color.Black;
            iconbtnLimpiarBuscarHoteles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnLimpiarBuscarHoteles.IconSize = 20;
            iconbtnLimpiarBuscarHoteles.Location = new Point(1014, 54);
            iconbtnLimpiarBuscarHoteles.Name = "iconbtnLimpiarBuscarHoteles";
            iconbtnLimpiarBuscarHoteles.Size = new Size(25, 25);
            iconbtnLimpiarBuscarHoteles.TabIndex = 18;
            iconbtnLimpiarBuscarHoteles.UseVisualStyleBackColor = false;
            iconbtnLimpiarBuscarHoteles.Click += iconbtnLimpiarBuscarHoteles_Click;
            // 
            // lblFechaHastaHoteles
            // 
            lblFechaHastaHoteles.AutoSize = true;
            lblFechaHastaHoteles.ForeColor = Color.White;
            lblFechaHastaHoteles.Location = new Point(494, 28);
            lblFechaHastaHoteles.Name = "lblFechaHastaHoteles";
            lblFechaHastaHoteles.RightToLeft = RightToLeft.Yes;
            lblFechaHastaHoteles.Size = new Size(71, 15);
            lblFechaHastaHoteles.TabIndex = 15;
            lblFechaHastaHoteles.Text = "Fecha Hasta";
            // 
            // lblUbicacionHoteles
            // 
            lblUbicacionHoteles.AutoSize = true;
            lblUbicacionHoteles.ForeColor = Color.White;
            lblUbicacionHoteles.Location = new Point(26, 29);
            lblUbicacionHoteles.Name = "lblUbicacionHoteles";
            lblUbicacionHoteles.Size = new Size(60, 15);
            lblUbicacionHoteles.TabIndex = 16;
            lblUbicacionHoteles.Text = "Ubicación";
            // 
            // dtpFechaHastaHoteles
            // 
            dtpFechaHastaHoteles.Format = DateTimePickerFormat.Short;
            dtpFechaHastaHoteles.Location = new Point(494, 47);
            dtpFechaHastaHoteles.Name = "dtpFechaHastaHoteles";
            dtpFechaHastaHoteles.RightToLeft = RightToLeft.No;
            dtpFechaHastaHoteles.Size = new Size(150, 23);
            dtpFechaHastaHoteles.TabIndex = 14;
            dtpFechaHastaHoteles.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtpFechaHastaHoteles.ValueChanged += dtpFechaHastaHoteles_ValueChanged;
            // 
            // txtUbicacionHoteles
            // 
            txtUbicacionHoteles.Location = new Point(26, 47);
            txtUbicacionHoteles.Name = "txtUbicacionHoteles";
            txtUbicacionHoteles.Size = new Size(150, 23);
            txtUbicacionHoteles.TabIndex = 15;
            txtUbicacionHoteles.TextChanged += txtUbicacionHoteles_TextChanged;
            // 
            // lblFechaDesdeHoteles
            // 
            lblFechaDesdeHoteles.AutoSize = true;
            lblFechaDesdeHoteles.ForeColor = Color.White;
            lblFechaDesdeHoteles.Location = new Point(338, 29);
            lblFechaDesdeHoteles.Name = "lblFechaDesdeHoteles";
            lblFechaDesdeHoteles.Size = new Size(73, 15);
            lblFechaDesdeHoteles.TabIndex = 13;
            lblFechaDesdeHoteles.Text = "Fecha Desde";
            // 
            // lblCantHabitacionesHoteles
            // 
            lblCantHabitacionesHoteles.AutoSize = true;
            lblCantHabitacionesHoteles.ForeColor = Color.White;
            lblCantHabitacionesHoteles.Location = new Point(650, 28);
            lblCantHabitacionesHoteles.Name = "lblCantHabitacionesHoteles";
            lblCantHabitacionesHoteles.Size = new Size(123, 15);
            lblCantHabitacionesHoteles.TabIndex = 13;
            lblCantHabitacionesHoteles.Text = "Cant. de Habitaciones";
            // 
            // dtpFechaDesdeHoteles
            // 
            dtpFechaDesdeHoteles.Format = DateTimePickerFormat.Short;
            dtpFechaDesdeHoteles.Location = new Point(338, 47);
            dtpFechaDesdeHoteles.Name = "dtpFechaDesdeHoteles";
            dtpFechaDesdeHoteles.Size = new Size(150, 23);
            dtpFechaDesdeHoteles.TabIndex = 12;
            dtpFechaDesdeHoteles.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dtpFechaDesdeHoteles.ValueChanged += dtpFechaDesdeHoteles_ValueChanged;
            // 
            // cmbCalificacionHoteles
            // 
            cmbCalificacionHoteles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCalificacionHoteles.FormattingEnabled = true;
            cmbCalificacionHoteles.Items.AddRange(new object[] { "★", "★★", "★★★", "★★★★", "★★★★★" });
            cmbCalificacionHoteles.Location = new Point(182, 47);
            cmbCalificacionHoteles.Name = "cmbCalificacionHoteles";
            cmbCalificacionHoteles.Size = new Size(150, 23);
            cmbCalificacionHoteles.TabIndex = 14;
            cmbCalificacionHoteles.TextChanged += cmbCalificacionHoteles_TextChanged;
            // 
            // txtHabitacionesHoteles
            // 
            txtHabitacionesHoteles.Location = new Point(650, 47);
            txtHabitacionesHoteles.Name = "txtHabitacionesHoteles";
            txtHabitacionesHoteles.Size = new Size(150, 23);
            txtHabitacionesHoteles.TabIndex = 12;
            txtHabitacionesHoteles.TextChanged += txtHabitacionesHoteles_TextChanged;
            // 
            // lblCalificacionHoteles
            // 
            lblCalificacionHoteles.AutoSize = true;
            lblCalificacionHoteles.ForeColor = Color.White;
            lblCalificacionHoteles.Location = new Point(182, 29);
            lblCalificacionHoteles.Name = "lblCalificacionHoteles";
            lblCalificacionHoteles.Size = new Size(69, 15);
            lblCalificacionHoteles.TabIndex = 13;
            lblCalificacionHoteles.Text = "Calificación";
            // 
            // lsvHoteles
            // 
            lsvHoteles.BackColor = Color.FromArgb(156, 184, 205);
            lsvHoteles.Columns.AddRange(new ColumnHeader[] { hdCodHotel, hdNombre, hdCalificacion, hdCiudad, hdHabitacion, hdTarifa, hdCapacidad, hdCodigoDisponibilidad });
            lsvHoteles.FullRowSelect = true;
            lsvHoteles.Location = new Point(10, 40);
            lsvHoteles.MultiSelect = false;
            lsvHoteles.Name = "lsvHoteles";
            lsvHoteles.Size = new Size(459, 261);
            lsvHoteles.TabIndex = 22;
            lsvHoteles.UseCompatibleStateImageBehavior = false;
            lsvHoteles.View = View.Details;
            lsvHoteles.ColumnWidthChanged += lsvHoteles_ColumnWidthChanged_1;
            lsvHoteles.SelectedIndexChanged += lsvHoteles_SelectedIndexChanged;
            // 
            // hdCodHotel
            // 
            hdCodHotel.Width = 1;
            // 
            // hdNombre
            // 
            hdNombre.Text = "Nombre";
            hdNombre.Width = 125;
            // 
            // hdCalificacion
            // 
            hdCalificacion.Text = "Calificacion";
            hdCalificacion.Width = 75;
            // 
            // hdCiudad
            // 
            hdCiudad.Text = "Ciudad";
            hdCiudad.Width = 55;
            // 
            // hdHabitacion
            // 
            hdHabitacion.Text = "Tipo Hab.";
            hdHabitacion.Width = 80;
            // 
            // hdTarifa
            // 
            hdTarifa.Text = "Tarifa";
            hdTarifa.Width = 54;
            // 
            // hdCapacidad
            // 
            hdCapacidad.Text = "Capac.";
            hdCapacidad.Width = 48;
            // 
            // hdCodigoDisponibilidad
            // 
            hdCodigoDisponibilidad.Width = 1;
            // 
            // btnAgregarItinerarioHoteles
            // 
            btnAgregarItinerarioHoteles.BackColor = Color.FromArgb(8, 32, 50);
            btnAgregarItinerarioHoteles.Enabled = false;
            btnAgregarItinerarioHoteles.FlatAppearance.BorderSize = 0;
            btnAgregarItinerarioHoteles.FlatStyle = FlatStyle.Flat;
            btnAgregarItinerarioHoteles.ForeColor = Color.White;
            btnAgregarItinerarioHoteles.Location = new Point(489, 120);
            btnAgregarItinerarioHoteles.Name = "btnAgregarItinerarioHoteles";
            btnAgregarItinerarioHoteles.Size = new Size(102, 26);
            btnAgregarItinerarioHoteles.TabIndex = 25;
            btnAgregarItinerarioHoteles.Text = "Agregar >>>";
            btnAgregarItinerarioHoteles.UseVisualStyleBackColor = false;
            btnAgregarItinerarioHoteles.Click += btnAgregarItinerarioHoteles_Click;
            // 
            // lblItinerarioActivo
            // 
            lblItinerarioActivo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblItinerarioActivo.ForeColor = Color.White;
            lblItinerarioActivo.Location = new Point(854, 11);
            lblItinerarioActivo.Name = "lblItinerarioActivo";
            lblItinerarioActivo.RightToLeft = RightToLeft.No;
            lblItinerarioActivo.Size = new Size(213, 18);
            lblItinerarioActivo.TabIndex = 26;
            lblItinerarioActivo.Text = "NO HAY ITINERARIO ACTIVO";
            lblItinerarioActivo.TextAlign = ContentAlignment.TopRight;
            // 
            // btnQuitarItinerarioHotel
            // 
            btnQuitarItinerarioHotel.BackColor = Color.FromArgb(8, 32, 50);
            btnQuitarItinerarioHotel.Enabled = false;
            btnQuitarItinerarioHotel.FlatAppearance.BorderSize = 0;
            btnQuitarItinerarioHotel.FlatStyle = FlatStyle.Flat;
            btnQuitarItinerarioHotel.ForeColor = Color.White;
            btnQuitarItinerarioHotel.Location = new Point(489, 175);
            btnQuitarItinerarioHotel.Name = "btnQuitarItinerarioHotel";
            btnQuitarItinerarioHotel.Size = new Size(102, 26);
            btnQuitarItinerarioHotel.TabIndex = 28;
            btnQuitarItinerarioHotel.Text = "<<< Eliminar";
            btnQuitarItinerarioHotel.UseVisualStyleBackColor = false;
            btnQuitarItinerarioHotel.Click += btnQuitarItinerarioHotel_Click;
            // 
            // lsvHotelesAgregados
            // 
            lsvHotelesAgregados.BackColor = Color.FromArgb(156, 184, 205);
            lsvHotelesAgregados.Columns.AddRange(new ColumnHeader[] { hdCodHotelItinerario, hdNombreHotelItinerario, hdCalificacionItinerario, hdCiudadHotelItinerario, hdTipoHabItinerario, hdTarifaHotelItinerario, hdCapacidadHotelItinerario, hdCodigoDisponibilidadItinerario });
            lsvHotelesAgregados.FullRowSelect = true;
            lsvHotelesAgregados.Location = new Point(610, 40);
            lsvHotelesAgregados.MultiSelect = false;
            lsvHotelesAgregados.Name = "lsvHotelesAgregados";
            lsvHotelesAgregados.Size = new Size(459, 261);
            lsvHotelesAgregados.TabIndex = 29;
            lsvHotelesAgregados.UseCompatibleStateImageBehavior = false;
            lsvHotelesAgregados.View = View.Details;
            lsvHotelesAgregados.ColumnWidthChanged += lsvHotelesAgregados_ColumnWidthChanged;
            lsvHotelesAgregados.SelectedIndexChanged += lsvHotelesAgregados_SelectedIndexChanged;
            // 
            // hdCodHotelItinerario
            // 
            hdCodHotelItinerario.Width = 1;
            // 
            // hdNombreHotelItinerario
            // 
            hdNombreHotelItinerario.Text = "Nombre";
            hdNombreHotelItinerario.Width = 125;
            // 
            // hdCalificacionItinerario
            // 
            hdCalificacionItinerario.Text = "Calificacion";
            hdCalificacionItinerario.Width = 75;
            // 
            // hdCiudadHotelItinerario
            // 
            hdCiudadHotelItinerario.Text = "Ciudad";
            hdCiudadHotelItinerario.Width = 55;
            // 
            // hdTipoHabItinerario
            // 
            hdTipoHabItinerario.Text = "Tipo Hab.";
            hdTipoHabItinerario.Width = 80;
            // 
            // hdTarifaHotelItinerario
            // 
            hdTarifaHotelItinerario.Text = "Tarifa";
            hdTarifaHotelItinerario.Width = 54;
            // 
            // hdCapacidadHotelItinerario
            // 
            hdCapacidadHotelItinerario.Text = "Capac.";
            hdCapacidadHotelItinerario.Width = 48;
            // 
            // hdCodigoDisponibilidadItinerario
            // 
            hdCodigoDisponibilidadItinerario.Width = 1;
            // 
            // lblHotelEnItinerario
            // 
            lblHotelEnItinerario.AutoSize = true;
            lblHotelEnItinerario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHotelEnItinerario.ForeColor = Color.White;
            lblHotelEnItinerario.Location = new Point(610, 7);
            lblHotelEnItinerario.Name = "lblHotelEnItinerario";
            lblHotelEnItinerario.Size = new Size(146, 30);
            lblHotelEnItinerario.TabIndex = 31;
            lblHotelEnItinerario.Text = "En el itinerario";
            // 
            // lblSubTotal
            // 
            lblSubTotal.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTotal.ForeColor = Color.White;
            lblSubTotal.Location = new Point(854, 302);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.RightToLeft = RightToLeft.No;
            lblSubTotal.Size = new Size(213, 15);
            lblSubTotal.TabIndex = 32;
            lblSubTotal.Text = "Subtotal: -";
            lblSubTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // Hoteles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 124, 153);
            ClientSize = new Size(1078, 420);
            Controls.Add(lblSubTotal);
            Controls.Add(lblHotelEnItinerario);
            Controls.Add(lsvHotelesAgregados);
            Controls.Add(btnQuitarItinerarioHotel);
            Controls.Add(lblItinerarioActivo);
            Controls.Add(btnAgregarItinerarioHoteles);
            Controls.Add(lsvHoteles);
            Controls.Add(grpHoteles);
            Controls.Add(lblHoteles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Hoteles";
            Text = "Hoteles Disponibles";
            FormClosed += Hoteles_FormClosed;
            Load += Hoteles_Load;
            grpHoteles.ResumeLayout(false);
            grpHoteles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoteles;
        private GroupBox grpHoteles;
        private Label lblFechaHastaHoteles;
        private Label lblUbicacionHoteles;
        private DateTimePicker dtpFechaHastaHoteles;
        private TextBox txtUbicacionHoteles;
        private Label lblFechaDesdeHoteles;
        private Label lblCantHabitacionesHoteles;
        private DateTimePicker dtpFechaDesdeHoteles;
        private ComboBox cmbCalificacionHoteles;
        private TextBox txtHabitacionesHoteles;
        private Label lblCalificacionHoteles;
        public ListView lsvHoteles;
        private Button btnAgregarItinerarioHoteles;
        private Label lblItinerarioActivo;
        private ColumnHeader hdNombre;
        private ColumnHeader hdCalificacion;
        private ColumnHeader hdCiudad;
        private ColumnHeader hdHabitacion;
        private ColumnHeader hdTarifa;
        private ColumnHeader hdCapacidad;
        private Button btnQuitarItinerarioHotel;
        private ColumnHeader hdCodHotel;
        public ListView lsvHotelesAgregados;
        private ColumnHeader hdCodHotelItinerario;
        private ColumnHeader hdNombreHotelItinerario;
        private ColumnHeader hdCalificacionItinerario;
        private ColumnHeader hdCiudadHotelItinerario;
        private ColumnHeader hdTipoHabItinerario;
        private ColumnHeader hdTarifaHotelItinerario;
        private ColumnHeader hdCapacidadHotelItinerario;
        private Label lblHotelEnItinerario;
        private FontAwesome.Sharp.IconButton iconbtnLimpiarBuscarHoteles;
        private Label lblTipoHabitacion;
        private ComboBox cmbTipoHabitacion;
        private ColumnHeader hdCodigoDisponibilidad;
        private ColumnHeader hdCodigoDisponibilidadItinerario;
        private Label lblSubTotal;
    }
}