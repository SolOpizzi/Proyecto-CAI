using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Prototipo_CAI
{
    public partial class CrearReserva : Form
    {
        CrearReservaModel model = new CrearReservaModel();
        public CrearReserva()
        {
            InitializeComponent();
        }

        private void CrearReserva_Load(object sender, EventArgs e)
        {
            CrearReservaModel model = new();
            Itinerario itinerarioActivo = model.ObtenerItinerarioActivo();
            int codTarifa = 0;
            foreach (var disp in itinerarioActivo.Disponibilidades)
            {
                codTarifa++;
                Hotel hotel = model.ObtenerInfoHotel(disp.Disponibilidad.CodigoHotel);
                var item = new ItemCheckBox();
                item.CodTarifa = codTarifa;
                item.Hotel = disp;
                //Crear una descripcion buscando los datos del hotel en el modulo, etc....
                item.Descripcion = $"{item.CodTarifa};{hotel.Nombre};{item.Hotel.Disponibilidad.Nombre};Capacidad:{item.Hotel.Disponibilidad.Capacidad},{item.Hotel.Disponibilidad.Menores},{item.Hotel.Disponibilidad.Infantes};{item.Hotel.Disponibilidad.TarifaDiaria}";
                this.chklbTarifasAsignadas.Items.Add(item);
            }

            foreach (var tarifaVuelo in itinerarioActivo.TarifasVuelos)
            {
                codTarifa++;
                Vuelo vuelo = model.ObtenerInfoVuelo(tarifaVuelo.CodigoVuelo);
                var item = new ItemCheckBox();
                item.CodTarifa = codTarifa;
                item.Vuelo = tarifaVuelo;
                item.Descripcion = $"{item.CodTarifa};{vuelo.CodigoVuelo};{vuelo.Origen};{vuelo.Destino};{tarifaVuelo.Clase};{tarifaVuelo.TipoPasajero};{tarifaVuelo.Precio};";
                this.chklbTarifasAsignadas.Items.Add(item);
            }

        }

        private void txtNombrePasajero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            CrearReservaModel model = new();
            string nombreApellido = txtNombrePasajero.Text;
            string dni = txtDNIPasajero.Text;
            DateTime fechaNac = dtpNacimientoP.Value.Date;
            string nacionalidad = cmbNacionalidad.Text;
            string genero = cmbGenero.Text;
            string tarifasAsociadas = "";
            foreach (ItemCheckBox item in this.chklbTarifasAsignadas.CheckedItems)
            {
                tarifasAsociadas += $"{item.CodTarifa};";
            }
            List<ListViewItem> list = new();
            foreach (ListViewItem item in lsvTarifasReserva.Items)
            {
                list.Add(item);
            }

            string errores = model.ValidarCampos(nombreApellido, dni, fechaNac, nacionalidad, genero);
            errores += model.ValidarRepetidos(dni, list);
            List<ItemCheckBox> listcb = new();
            foreach (ItemCheckBox item in this.chklbTarifasAsignadas.CheckedItems)
            {
                listcb.Add(item);
            }


            if (!string.IsNullOrWhiteSpace(errores))
            {
                MessageBox.Show(errores, "Error");
                return;
            }

            if (chklbTarifasAsignadas.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una tarifa.", "Error");
                return;
            }

            errores += model.ValidarVuelosRepetidos(listcb);

            if (!string.IsNullOrWhiteSpace(errores))
            {
                MessageBox.Show(errores, "Error");
                return;
            }

            tarifasAsociadas = tarifasAsociadas.Substring(0, tarifasAsociadas.Length - 1);

            ListViewItem itemlsv = new ListViewItem(nombreApellido);

            lsvTarifasReserva.Items.Add(model.FormatoPasajeroReserva(nombreApellido, dni, fechaNac, nacionalidad, genero, tarifasAsociadas));

            MessageBox.Show("Pasajero agregado correctamente.", "Éxito");
        }

        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            if (lsvTarifasReserva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un pasajero si quiere eliminarlo.", "Error");
            }
            else
            {
                lsvTarifasReserva.SelectedItems[0].Remove();
            }
        }

        private void btnLimpiarDatosPasajero_Click(object sender, EventArgs e)
        {
            txtNombrePasajero.Clear();
            txtDNIPasajero.Clear();
            cmbNacionalidad.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
            dtpNacimientoP.Value = DateTime.Now;
            for (int i = 0; i < chklbTarifasAsignadas.Items.Count; i++)
            {
                if (chklbTarifasAsignadas.GetItemChecked(i))
                {
                    chklbTarifasAsignadas.SetItemChecked(i, false);
                }
            }
        }

        private void btnCerrarCrearReserva_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearReserva_Click(object sender, EventArgs e)
        {
            if (lsvTarifasReserva.Items.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un pasajero para concretar una reserva.", "Error");
                return;
            }
            CrearReservaModel model = new();
            List<ItemCheckBox> list = new();
            foreach (ItemCheckBox cb in chklbTarifasAsignadas.Items)
            {
                list.Add(cb);
            }
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            foreach (ListViewItem lsvitem in lsvTarifasReserva.Items)
            {
                listViewItems.Add(lsvitem);
            }
            if (!model.ValidarUsoTarifas(list, listViewItems))
            {
                MessageBox.Show("No se han utilizado todas las tarifas correspondientes al itinerario.", "Error");
                return;
            }

            string errores = model.ValidarDisponibilidadTarifas(list);

            errores += model.ValidarPasajerosTarifas(list, listViewItems);

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores);
                return;
            }

            // CREACION DE RESERVA

            model.CrearReserva(list, listViewItems);

            ModuloItinerarios.ItinerarioActivo = null;

            this.Close();
        }



        #region Tamaño
        private void lsvTarifasReserva_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (lsvTarifasReserva.Columns[e.ColumnIndex].Width < 100)
            {
                lsvTarifasReserva.Columns[e.ColumnIndex].Width = 100;
            }
            if (lsvTarifasReserva.Columns[e.ColumnIndex].Width > 150)
            {
                lsvTarifasReserva.Columns[e.ColumnIndex].Width = 150;
            }
        }

        #endregion



    }
}
