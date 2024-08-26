using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prototipo_CAI;
internal class AereosModel
{
    public List<ListViewItem> FormatoVuelos(List<Vuelo> list)
    {
        List<ListViewItem> listViewItems = new List<ListViewItem>();
        foreach (Vuelo vuelo in list)
        {
            foreach (TarifaVuelo tarifa in vuelo.Tarifas)
            {
                ListViewItem item = new ListViewItem(vuelo.CodigoVuelo.ToString());
                item.SubItems.Add(vuelo.Destino);
                item.SubItems.Add(vuelo.FechaHoraSalida.ToString()); // Formato de fecha y hora
                item.SubItems.Add(vuelo.Origen);
                item.SubItems.Add(tarifa.TipoPasajero.ToString());
                item.SubItems.Add(tarifa.Clase.ToString());
                item.SubItems.Add(tarifa.Precio.ToString());
                item.SubItems.Add(tarifa.TarifasVuelosDisponibles.ToString());
                item.SubItems.Add(vuelo.FechaHoraLlegada.ToString());
                item.SubItems.Add(vuelo.TiempoVuelo);
                item.SubItems.Add(vuelo.Aerolinea);
                item.SubItems.Add(tarifa.CodigoTarifaVuelo.ToString());

                listViewItems.Add(item);
            }

        }

        return listViewItems;
    }

    public List<ListViewItem> FormatoVuelosItinerarioActivo(List<TarifaVuelo> list)
    {
        List<ListViewItem> listViewItems = new List<ListViewItem>();

        foreach (TarifaVuelo tarifa in list)
        {
            Vuelo vuelo = ModuloVuelos.ObtenerInfoVuelo(Convert.ToString(tarifa.CodigoVuelo));
            ListViewItem item = new ListViewItem(vuelo.CodigoVuelo.ToString());
            item.SubItems.Add(vuelo.Destino);
            item.SubItems.Add(vuelo.FechaHoraSalida.ToString()); // Formato de fecha y hora
            item.SubItems.Add(vuelo.Origen);
            item.SubItems.Add(tarifa.TipoPasajero.ToString());
            item.SubItems.Add(tarifa.Clase.ToString());
            item.SubItems.Add(tarifa.Precio.ToString());
            item.SubItems.Add(tarifa.TarifasVuelosDisponibles.ToString());
            item.SubItems.Add(vuelo.FechaHoraLlegada.ToString());
            item.SubItems.Add(vuelo.TiempoVuelo);
            item.SubItems.Add(vuelo.Aerolinea);
            item.SubItems.Add(tarifa.CodigoTarifaVuelo.ToString());

            listViewItems.Add(item);
        }

        return listViewItems;
    }

    public List<ListViewItem> CargarVuelos()
    {
        List<Vuelo> listVuelo = ModuloVuelos.CargarListaVuelos();
        List<ListViewItem> list = FormatoVuelos(listVuelo);
        return list;
    }

    public void ActualizarVuelosItinerarioActivo(List<ListViewItem> list)
    {
        List<TarifaVuelo> tarifas = ModuloVuelos.ObtenerTarifasItinerarioActivo(list);
        ModuloItinerarios.AgregarTarifasAItinerarioActivo(tarifas);
        ModuloItinerarios.CalcularPrecioTotalItinerarioActivo();
    }

    public List<ListViewItem> CargarVuelosItinerarioActivo()
    {
        List<TarifaVuelo> listTarifas = ModuloItinerarios.ItinerarioActivo.TarifasVuelos;
        List<ListViewItem> list = FormatoVuelosItinerarioActivo(listTarifas);
        return list;
    }

    public decimal CalcularTotal(List<ListViewItem> list)
    {
        decimal total = 0;
        foreach (ListViewItem item in list)
        {
            string precioLimpio = Regex.Replace(item.SubItems[6].Text, "\\$", "");
            total += Convert.ToDecimal(precioLimpio);
        }
        return total;
    }
}
