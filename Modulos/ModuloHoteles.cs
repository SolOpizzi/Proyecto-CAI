using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class ModuloHoteles
{
    public static List<Hotel> Hoteles = HotelesAlmacen.Hoteles;
    public static List<Hotel> list = new List<Hotel>();

    public static List<Hotel> CargarListaHoteles()
    {
        return Hoteles;
    }

    public static Hotel ObtenerInfoHotel(string codHotel)
    {
        foreach (Hotel hotel in Hoteles)
        {
            if (codHotel == hotel.CodigoHotel)
            {
                return hotel;
            }
        }

        return null;
    }

    public static Disponibilidad ObtenerInfoDisponibilidad(string codHotel, string codDisponibilidad)
    {
        foreach (Hotel hotel in Hoteles)
        {
            if (codHotel == hotel.CodigoHotel)
            {
                foreach (Disponibilidad disp in hotel.Disponibilidades)
                {
                    if (codDisponibilidad == Convert.ToString(disp.CodigoDisponibilidad))
                    {
                        return disp;
                    }
                }
            }
        }
        return null;
    }

    public static bool ObtenerDispFecha(Disponibilidad disp, DateTime fechaDesde, DateTime fechaHasta, int cantHabitaciones)
    {

        for (DateTime date = fechaDesde; date <= fechaHasta; date = date.AddDays(1.0))
        {
            int salida = 0;
            if (!disp.DiasDisponibles.TryGetValue(date, out salida) || salida < cantHabitaciones)
            {
                return false;
            }
        }
        return true;
    }

    public static List<Disponibilidad> ObtenerDisponibilidadesItinerarioActivo(List<ListViewItem> list)
    {
        //OJO: devolver las disponibilidades en el mismo orden que los items de la lista.

        List<Disponibilidad> disponibilidadesItinerarioActivo = new();
        foreach (ListViewItem item in list)
        {
            foreach (Hotel hotel in Hoteles)
            {
                if (hotel.CodigoHotel == item.Text)
                {
                    foreach (Disponibilidad disp in hotel.Disponibilidades)
                    {
                        if (disp.Nombre == item.SubItems[4].Text)
                        {
                            disponibilidadesItinerarioActivo.Add(disp);
                        }
                    }
                }
            }
        }
        return disponibilidadesItinerarioActivo;
    }

    public static List<Disponibilidad> FiltrarDisponibilidadesPorFecha(DateTime fechaDesde, DateTime fechaHasta, string cantHabitaciones)
    {
        List<Disponibilidad> disponibilidadesFiltradas = new();
        DateTime fechaPredeterminada = new DateTime(1999, 1, 1);
        if (fechaDesde != fechaPredeterminada && fechaHasta != fechaPredeterminada && fechaDesde <= fechaHasta)
        {
            foreach (Hotel hotel in Hoteles)
            {
                foreach (Disponibilidad disp in hotel.Disponibilidades)
                {
                    if (ObtenerDispFecha(disp, fechaDesde, fechaHasta, Convert.ToInt32(cantHabitaciones)))
                    {
                        disponibilidadesFiltradas.Add(disp);
                    }
                }

            }
        }
        return disponibilidadesFiltradas;
    }

    public static string ValidarDisponibilidadHoteles(ItinerarioHotel itinerarioHotel, int cantReservada)
    {
        Disponibilidad disponibilidad = null;
        foreach (Hotel hotel in Hoteles)
        {
            foreach (Disponibilidad disp in hotel.Disponibilidades)
            {
                if (ObtenerDispFecha(itinerarioHotel.Disponibilidad, itinerarioHotel.Desde, itinerarioHotel.Hasta, cantReservada))
                {
                    disponibilidad = disp;
                }
            }
        }
        if (disponibilidad == null)
        {
            return $"No hay {cantReservada} habitaciones '{itinerarioHotel.Disponibilidad.Nombre}' disponibles en el hotel {itinerarioHotel.Disponibilidad.CodigoHotel} entre el {itinerarioHotel.Desde.ToString("dd-MM-yyyy")} y el {itinerarioHotel.Hasta.ToString("dd-MM-yyyy")}.";
        }
        return "";
    }

    public static void ReducirDisponibilidadHotel(ItinerarioHotel dispIti)
    {
        foreach (Hotel hotel in Hoteles)
        {
            foreach (Disponibilidad disp in hotel.Disponibilidades)
            {
                if (dispIti.Disponibilidad.CodigoDisponibilidad == disp.CodigoDisponibilidad)
                {
                    for (DateTime i = dispIti.Desde.Date; i <= dispIti.Hasta.Date; i = i.AddDays(1))
                    {
                        disp.DiasDisponibles[i]--;
                    }
                }
            }
        }
    }

    public static void AumentarDisponibilidadHotel(ItinerarioHotel dispIti)
    {
        foreach (Hotel hotel in Hoteles)
        {
            foreach (Disponibilidad disp in hotel.Disponibilidades)
            {
                if (dispIti.Disponibilidad.CodigoDisponibilidad == disp.CodigoDisponibilidad)
                {
                    for (DateTime i = dispIti.Desde.Date; i <= dispIti.Hasta.Date; i = i.AddDays(1))
                    {
                        disp.DiasDisponibles[i]++;
                    }
                }
            }
        }
    }
}
