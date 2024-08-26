using System.IO;
using System.Windows.Forms;

namespace Prototipo_CAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            subpaneles();
            Size = new System.Drawing.Size(360, 410);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void subpaneles()
        {
            panelSubmenu.Visible = false;
            iconbtnVolver.Visible = false;
        }

        private void esconderPaneles()
        {
            if (panelSubmenu.Visible == true)
            {
                iconbtnReservas.Visible = false;
                iconbtnProductosDisponibles.Visible = false;
                iconbtnItinerario.Visible = false;
            }
        }

        private void mostrarSubpaneles(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                Size = new System.Drawing.Size(360, 410);
                submenu.Visible = true;
                iconbtnVolver.Visible = true;
            }
        }

        private void iconbtnItinerario_Click(object sender, EventArgs e)
        {
            Itinerarios itinerario = new();
            itinerario.ShowDialog();
        }

        private void iconbtnProductosDisponibles_Click(object sender, EventArgs e)
        {
            mostrarSubpaneles(panelSubmenu);
            esconderPaneles();
        }

        private void iconbtnReservas_Click(object sender, EventArgs e)
        {
            Reservas reservas = new();
            reservas.ShowDialog();
        }

        private void iconbtnVolver_Click(object sender, EventArgs e)
        {
            iconbtnReservas.Visible = true;
            iconbtnProductosDisponibles.Visible = true;
            iconbtnItinerario.Visible = true;
            iconbtnVolver.Visible = false;
            panelSubmenu.Visible = false;
        }

        private void iconbtnAereos_Click(object sender, EventArgs e)
        {
            Aereos clasesVuelo = new Aereos();
            clasesVuelo.ShowDialog();
        }

        private void iconbtnHoteles_Click(object sender, EventArgs e)
        {
            Hoteles hoteles = new Hoteles();
            hoteles.ShowDialog();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}