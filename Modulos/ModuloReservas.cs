using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Prototipo_CAI;

internal class ModuloReservas
{
    public static List<Reserva> Reservas = ReservasAlmacen.Reservas;

    public static List<Reserva> CargarListaReservas()
    {
        return Reservas;
    }

    public static void EliminarReserva(string codReserva)
    {
        foreach (Reserva reserva in Reservas)
        {
            if (string.Equals(reserva.CodigoReserva.ToString(), codReserva))
            {
                Reservas.Remove(reserva);
                return;
            }
        }
    }

    public static void BuscarReserva(ListView listView, string textoBusqueda)
    {
        bool encontrada = false;

        foreach (ListViewItem item in listView.Items)
        {
            if (item.SubItems.Count > 0 && item.SubItems[0].Text.Equals(textoBusqueda))
            {
                item.BackColor = Color.Orange;
                item.ForeColor = Color.White;

                item.EnsureVisible();

                encontrada = true;
            }
            else
            {
                item.BackColor = System.Drawing.Color.FromArgb(156, 184, 205);
                item.ForeColor = SystemColors.WindowText;
            }
        }

        if (!encontrada)
        {
            MessageBox.Show("No se encontraron reservas con ese código.");
        }
    }

    public static int ActualizarListView(ListView listView, ReservasModel model, int indiceSeleccionado)
    {
        if (listView.SelectedItems.Count > 0)
        {
            indiceSeleccionado = listView.SelectedItems[0].Index;
        }
        else
        {
            indiceSeleccionado = -1;
        }

        listView.Items.Clear();

        foreach (ListViewItem item in model.FormatoReservas())
        {
            listView.Items.Add(item);
        }

        if (indiceSeleccionado >= 0 && indiceSeleccionado < listView.Items.Count)
        {
            listView.Items[indiceSeleccionado].Selected = true;
        }

        return indiceSeleccionado;
    }

    public static void CancelarReservas(ListView listView)
    {
        if (listView.SelectedItems.Count > 0)
        {
            int indiceSeleccionado = listView.SelectedItems[0].Index;
            List<Reserva> listReservas = CargarListaReservas();

            if (indiceSeleccionado >= 0 && indiceSeleccionado < listReservas.Count)
            {
                Reserva reservaSeleccionada = listReservas[indiceSeleccionado];

                if (reservaSeleccionada.EstadoReserva.Equals("Cancelado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Esta reserva ya ha sido cancelada.");
                }
                else if (reservaSeleccionada.EstadoReserva.Equals("Confirmado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Esta reserva ya ha sido confirmada y no se puede cancelar.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Desea cancelar esta reserva?", "Cancelar reserva", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        reservaSeleccionada.EstadoReserva = "Cancelado";
                        foreach (ItinerarioHotel itinerarioHotel in reservaSeleccionada.ItinerarioAsociado.Disponibilidades)
                        {
                            ModuloHoteles.AumentarDisponibilidadHotel(itinerarioHotel);
                        }
                        foreach (TarifaVuelo tarifa in reservaSeleccionada.ItinerarioAsociado.TarifasVuelos)
                        {
                            ModuloVuelos.AumentarDisponibilidadVuelo(tarifa);
                        }
                        ModuloItinerarios.ItinerarioReservadoFalse(reservaSeleccionada.ItinerarioAsociado);
                    }
                    
                    // No es necesario manejar el caso de DialogResult.No o DialogResult.Cancel en este contexto
                }
            }
            else
            {
                MessageBox.Show("Seleccione una reserva válida.");
            }
        }
        else
        {
            MessageBox.Show("Seleccione una reserva antes de confirmar.");
        }
    }


    public static void ConfirmarReserva(ListView listView)
    {
        if (listView.SelectedItems.Count > 0)
        {
            int indiceSeleccionado = listView.SelectedItems[0].Index;
            List<Reserva> listReservas = CargarListaReservas();

            if (indiceSeleccionado >= 0 && indiceSeleccionado < listReservas.Count)
            {
                Reserva reservaSeleccionada = listReservas[indiceSeleccionado];

                if (reservaSeleccionada.EstadoReserva.Equals("Cancelado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Esta reserva está cancelada y no se puede confirmar.");
                }
                else if (reservaSeleccionada.EstadoReserva.Equals("Confirmado", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Esta reserva ya ha sido confirmada.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Desea confirmar esta reserva?", "Confirmar Reserva", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        reservaSeleccionada.EstadoReserva = "Confirmado";
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una reserva válida.");
            }
        }
        else
        {
            MessageBox.Show("Seleccione una reserva antes de confirmar.");
        }
    }

    public static void CargarReservas(ListView listView)
    {
        ReservasModel model = new ReservasModel();

        listView.Items.Clear();

        foreach (ListViewItem item in model.FormatoReservas())
        {
            listView.Items.Add(item);
        }
    }

    public static int ObtenerUltimoCodigoReserva()
    {
        if (Reservas.Count == 0)
        {
            return 0;
        }
        return Reservas.Last().CodigoReserva;

    }

    public static void AgregarReserva(Reserva reserva)
    {
        Reservas.Add(reserva);
    }
}
