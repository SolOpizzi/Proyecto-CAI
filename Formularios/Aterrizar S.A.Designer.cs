namespace Prototipo_CAI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenuPrincipal = new Panel();
            iconbtnVolver = new FontAwesome.Sharp.IconButton();
            iconbtnReservas = new FontAwesome.Sharp.IconButton();
            panelSubmenu = new Panel();
            iconbtnHoteles = new FontAwesome.Sharp.IconButton();
            iconbtnAereos = new FontAwesome.Sharp.IconButton();
            iconbtnProductosDisponibles = new FontAwesome.Sharp.IconButton();
            iconbtnItinerario = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            panelMenuPrincipal.SuspendLayout();
            panelSubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuPrincipal
            // 
            panelMenuPrincipal.AutoScroll = true;
            panelMenuPrincipal.BackColor = Color.FromArgb(8, 32, 50);
            panelMenuPrincipal.Controls.Add(iconbtnVolver);
            panelMenuPrincipal.Controls.Add(iconbtnReservas);
            panelMenuPrincipal.Controls.Add(panelSubmenu);
            panelMenuPrincipal.Controls.Add(iconbtnProductosDisponibles);
            panelMenuPrincipal.Controls.Add(iconbtnItinerario);
            panelMenuPrincipal.Controls.Add(panelLogo);
            panelMenuPrincipal.Dock = DockStyle.Top;
            panelMenuPrincipal.Location = new Point(0, 0);
            panelMenuPrincipal.Name = "panelMenuPrincipal";
            panelMenuPrincipal.Size = new Size(344, 400);
            panelMenuPrincipal.TabIndex = 3;
            // 
            // iconbtnVolver
            // 
            iconbtnVolver.FlatAppearance.BorderSize = 0;
            iconbtnVolver.FlatStyle = FlatStyle.Flat;
            iconbtnVolver.IconChar = FontAwesome.Sharp.IconChar.House;
            iconbtnVolver.IconColor = Color.White;
            iconbtnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnVolver.Location = new Point(267, 317);
            iconbtnVolver.Name = "iconbtnVolver";
            iconbtnVolver.Size = new Size(65, 42);
            iconbtnVolver.TabIndex = 2;
            iconbtnVolver.UseVisualStyleBackColor = true;
            iconbtnVolver.Click += iconbtnVolver_Click;
            // 
            // iconbtnReservas
            // 
            iconbtnReservas.FlatAppearance.BorderSize = 0;
            iconbtnReservas.FlatStyle = FlatStyle.Flat;
            iconbtnReservas.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            iconbtnReservas.ForeColor = Color.White;
            iconbtnReservas.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconbtnReservas.IconColor = Color.White;
            iconbtnReservas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnReservas.Location = new Point(0, 215);
            iconbtnReservas.Name = "iconbtnReservas";
            iconbtnReservas.Size = new Size(345, 65);
            iconbtnReservas.TabIndex = 4;
            iconbtnReservas.Text = "Reservas";
            iconbtnReservas.TextAlign = ContentAlignment.MiddleRight;
            iconbtnReservas.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnReservas.UseVisualStyleBackColor = true;
            iconbtnReservas.Click += iconbtnReservas_Click;
            // 
            // panelSubmenu
            // 
            panelSubmenu.BackColor = Color.FromArgb(27, 106, 167);
            panelSubmenu.Controls.Add(iconbtnHoteles);
            panelSubmenu.Controls.Add(iconbtnAereos);
            panelSubmenu.Location = new Point(0, 117);
            panelSubmenu.Name = "panelSubmenu";
            panelSubmenu.Size = new Size(345, 130);
            panelSubmenu.TabIndex = 3;
            // 
            // iconbtnHoteles
            // 
            iconbtnHoteles.BackColor = Color.FromArgb(13, 50, 78);
            iconbtnHoteles.Dock = DockStyle.Top;
            iconbtnHoteles.FlatAppearance.BorderSize = 0;
            iconbtnHoteles.FlatStyle = FlatStyle.Flat;
            iconbtnHoteles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconbtnHoteles.ForeColor = Color.White;
            iconbtnHoteles.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            iconbtnHoteles.IconColor = Color.White;
            iconbtnHoteles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnHoteles.Location = new Point(0, 65);
            iconbtnHoteles.Name = "iconbtnHoteles";
            iconbtnHoteles.Size = new Size(345, 65);
            iconbtnHoteles.TabIndex = 1;
            iconbtnHoteles.Text = "Hoteles";
            iconbtnHoteles.TextAlign = ContentAlignment.MiddleRight;
            iconbtnHoteles.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnHoteles.UseVisualStyleBackColor = false;
            iconbtnHoteles.Click += iconbtnHoteles_Click;
            // 
            // iconbtnAereos
            // 
            iconbtnAereos.BackColor = Color.FromArgb(13, 50, 78);
            iconbtnAereos.Dock = DockStyle.Top;
            iconbtnAereos.FlatAppearance.BorderSize = 0;
            iconbtnAereos.FlatStyle = FlatStyle.Flat;
            iconbtnAereos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconbtnAereos.ForeColor = Color.White;
            iconbtnAereos.IconChar = FontAwesome.Sharp.IconChar.PlaneDeparture;
            iconbtnAereos.IconColor = Color.White;
            iconbtnAereos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnAereos.Location = new Point(0, 0);
            iconbtnAereos.Name = "iconbtnAereos";
            iconbtnAereos.Size = new Size(345, 65);
            iconbtnAereos.TabIndex = 0;
            iconbtnAereos.Text = "Áereos";
            iconbtnAereos.TextAlign = ContentAlignment.MiddleRight;
            iconbtnAereos.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnAereos.UseVisualStyleBackColor = false;
            iconbtnAereos.Click += iconbtnAereos_Click;
            // 
            // iconbtnProductosDisponibles
            // 
            iconbtnProductosDisponibles.FlatAppearance.BorderSize = 0;
            iconbtnProductosDisponibles.FlatStyle = FlatStyle.Flat;
            iconbtnProductosDisponibles.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            iconbtnProductosDisponibles.ForeColor = Color.White;
            iconbtnProductosDisponibles.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            iconbtnProductosDisponibles.IconColor = Color.White;
            iconbtnProductosDisponibles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnProductosDisponibles.Location = new Point(0, 150);
            iconbtnProductosDisponibles.Name = "iconbtnProductosDisponibles";
            iconbtnProductosDisponibles.Size = new Size(345, 65);
            iconbtnProductosDisponibles.TabIndex = 2;
            iconbtnProductosDisponibles.Text = "Productos Disponibles";
            iconbtnProductosDisponibles.TextAlign = ContentAlignment.MiddleRight;
            iconbtnProductosDisponibles.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnProductosDisponibles.UseVisualStyleBackColor = true;
            iconbtnProductosDisponibles.Click += iconbtnProductosDisponibles_Click;
            // 
            // iconbtnItinerario
            // 
            iconbtnItinerario.FlatAppearance.BorderSize = 0;
            iconbtnItinerario.FlatStyle = FlatStyle.Flat;
            iconbtnItinerario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            iconbtnItinerario.ForeColor = Color.White;
            iconbtnItinerario.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            iconbtnItinerario.IconColor = Color.White;
            iconbtnItinerario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnItinerario.Location = new Point(0, 85);
            iconbtnItinerario.Name = "iconbtnItinerario";
            iconbtnItinerario.Size = new Size(345, 65);
            iconbtnItinerario.TabIndex = 1;
            iconbtnItinerario.Text = "Itinerario";
            iconbtnItinerario.TextAlign = ContentAlignment.MiddleRight;
            iconbtnItinerario.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconbtnItinerario.UseVisualStyleBackColor = true;
            iconbtnItinerario.Click += iconbtnItinerario_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(8, 32, 50);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(345, 85);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 371);
            Controls.Add(panelMenuPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Aterrizar S.A.";
            panelMenuPrincipal.ResumeLayout(false);
            panelSubmenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenuPrincipal;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconbtnItinerario;
        private FontAwesome.Sharp.IconButton iconbtnProductosDisponibles;
        private Panel panelSubmenu;
        private FontAwesome.Sharp.IconButton iconbtnHoteles;
        private FontAwesome.Sharp.IconButton iconbtnAereos;
        private FontAwesome.Sharp.IconButton iconbtnReservas;
        private FontAwesome.Sharp.IconButton iconbtnVolver;
    }
}