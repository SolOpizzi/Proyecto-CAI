using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal class ReservasModel
{
    public List<ListViewItem> FormatoReservas()
    {
        List<ListViewItem> listViewItems = new List<ListViewItem>();
        List<Reserva> listReservas = ModuloReservas.CargarListaReservas();
        List<Itinerario> listItinerarios = ModuloItinerarios.CargarListaItinerarios();

        foreach (Reserva reserva in listReservas)
        {
            Itinerario itinerario = reserva.ItinerarioAsociado;

            if (itinerario != null)
            {
                ListViewItem item = new ListViewItem(reserva.CodigoReserva.ToString());
                item.SubItems.Add(itinerario.NombreCliente.ToString());
                item.SubItems.Add(reserva.FechaReserva.ToString());
                item.SubItems.Add(reserva.EstadoReserva);
                listViewItems.Add(item);
            }
            else
            {
                ListViewItem item = new ListViewItem(reserva.CodigoReserva.ToString());
                item.SubItems.Add("test");
                item.SubItems.Add(reserva.FechaReserva.ToString());
                item.SubItems.Add(reserva.EstadoReserva);
                listViewItems.Add(item);
            }
        }

        return listViewItems;
    }

    public static void BorrarReserva(string CodigoReserva)
    {
        ModuloReservas.EliminarReserva(CodigoReserva);
    }

    public static void BuscarReserva(ListView listView, string codReserva)
    {
        ModuloReservas.BuscarReserva(listView, codReserva);
    }

    public static void ActualizarListView(ListView listView, ReservasModel model, int indiceSeleccionado)
    {

    }

    public static void CancelarReserva(ListView listView)
    {
        ModuloReservas.CancelarReservas(listView);
    }

    public static void ConfirmarReserva(ListView listView)
    {
        ModuloReservas.ConfirmarReserva(listView);
    }

    public static void Actualizar(ListView listView)
    {
        ModuloReservas.CargarReservas(listView);
    }
}
