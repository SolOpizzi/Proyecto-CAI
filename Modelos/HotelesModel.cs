using Prototipo_CAI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_CAI;

internal class HotelesModel
{
    public List<ListViewItem> FormatoHoteles(List<Hotel> listHotel)
    {
        HotelesModel model = new HotelesModel();
        List<ListViewItem> listViewItem = new List<ListViewItem>();
        foreach (Hotel hotel in listHotel)
        {
            foreach (Disponibilidad disp in hotel.Disponibilidades)
            {
                ListViewItem item = new ListViewItem(hotel.CodigoHotel);
                item.SubItems.Add(hotel.Nombre);
                item.SubItems.Add(model.ConversorCalificacion(hotel.Calificacion));
                item.SubItems.Add(hotel.CodigoCiudad);
                item.SubItems.Add(disp.Nombre);
                item.SubItems.Add($"${Convert.ToString(disp.TarifaDiaria)}");
                item.SubItems.Add(Convert.ToString(disp.Capacidad));
                item.SubItems.Add(Convert.ToString(disp.CodigoDisponibilidad));
                listViewItem.Add(item);
            }
        }
        return listViewItem;
    }

    public List<ListViewItem> FormatoItinerarioHoteles(List<ItinerarioHotel> listDisponibilidades)
    {
        HotelesModel model = new HotelesModel();
        List<ListViewItem> listViewItem = new List<ListViewItem>();
        foreach (var itiHotel in listDisponibilidades)
        {
            var disp = itiHotel.Disponibilidad;
            Hotel hotel = ModuloHoteles.ObtenerInfoHotel(Convert.ToString(disp.CodigoHotel));
            ListViewItem item = new ListViewItem(hotel.CodigoHotel);
            item.SubItems.Add(hotel.Nombre);
            item.SubItems.Add(model.ConversorCalificacion(hotel.Calificacion));
            item.SubItems.Add(hotel.CodigoCiudad);
            item.SubItems.Add(disp.Nombre);
            item.SubItems.Add($"${Convert.ToString(disp.TarifaDiaria)}");
            item.SubItems.Add(Convert.ToString(disp.Capacidad));
            item.SubItems.Add(Convert.ToString(disp.CodigoDisponibilidad));
            //item.SubItems.Add(disp.DiasDisponibles);
            item.Tag = new DesdeHasta { Desde = itiHotel.Desde, Hasta = itiHotel.Hasta };
            listViewItem.Add(item);
        }
        return listViewItem;
    }

    public List<ListViewItem> CargarHoteles()
    {
        List<Hotel> listHotel = ModuloHoteles.CargarListaHoteles();
        List<ListViewItem> list = FormatoHoteles(listHotel);
        return list;
    }

    public List<ListViewItem> CargarHotelesItinerarioActivo()
    {
        var itinerarioHotel = ModuloItinerarios.ItinerarioActivo.Disponibilidades;
        List<ListViewItem> list = FormatoItinerarioHoteles(itinerarioHotel);
        return list;
    }

    public bool GuardarItemsItinerarioActivo(List<ListViewItem> list)
    {
        return true;
    }

    public string ValidarNumeroEntero(string numero)
    {
        int salida;
        if (!int.TryParse(numero, out salida))
        {
            return "El dato ingresado debe ser un número entero.\n";
        }
        else if (salida <= 0)
        {
            return "El número ingresado debe ser mayor a 0.\n";
        }
        return "";
    }

    public string ConversorCalificacion(int calificacion)
    {
        string estrellas = "";
        for (int i = 1; i <= calificacion; i++)
        {
            estrellas += "★";
        }
        return estrellas;
    }

    public void ActualizarHotelesItinerarioActivo(List<ListViewItem> list)
    {
        List<Disponibilidad> disp = ModuloHoteles.ObtenerDisponibilidadesItinerarioActivo(list);
        var itinerarioHotel = new List<ItinerarioHotel>();
        for (int i = 0; i < list.Count; i++)
        {
            var fechasReserva = (DesdeHasta)list[i].Tag;
            itinerarioHotel.Add(new ItinerarioHotel { Disponibilidad = disp[i], Desde = fechasReserva.Desde, Hasta = fechasReserva.Hasta });
        }

        ModuloItinerarios.AgregarDisponibilidadesAItinerarioActivo(itinerarioHotel);
        ModuloItinerarios.CalcularPrecioTotalItinerarioActivo();
    }

    public List<string> FiltrarDisponibilidad(DateTime fechaDesde, DateTime fechaHasta, string cantHabitaciones)
    {
        List<Disponibilidad> disp = ModuloHoteles.FiltrarDisponibilidadesPorFecha(fechaDesde, fechaHasta, cantHabitaciones);
        List<string> items = new();
        foreach (Disponibilidad item in disp)
        {
            items.Add(item.CodigoDisponibilidad.ToString());
        }
        return items;
    }

    public decimal CalcularTotal(List<ListViewItem> list)
    {
        decimal total = 0;
        foreach (ListViewItem item in list)
        {
            string precioLimpio = Regex.Replace(item.SubItems[5].Text, "\\$", "");
            total += Convert.ToDecimal(precioLimpio);
        }
        return total;
    }
}