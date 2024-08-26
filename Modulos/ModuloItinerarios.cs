using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class ModuloItinerarios
{
    public static List<Itinerario> Itinerarios = ItinerariosAlmacen.Itinerarios;

    public static Itinerario ItinerarioActivo;

    public static List<Itinerario> CargarListaItinerarios()
    {
        return Itinerarios;
    }

    public static void EstablecerItinerarioActivo(Itinerario itinerario)
    {
        ItinerarioActivo = itinerario;
    }

    public static Itinerario BuscarItinerario(string codItinerario)
    {
        foreach (Itinerario itinerario in Itinerarios)
        {
            if (Convert.ToInt32(codItinerario) == itinerario.CodigoItinerario)
            {
                return itinerario;
            }
        }

        return null;
    }

    public static void GuardarDisponibilidadEnItinerarioActivo(List<Disponibilidad> disponibilidad, DateTime desde, DateTime hasta)
    {
        ItinerarioActivo.Disponibilidades.Clear();
        foreach (Disponibilidad disp in disponibilidad)
        {
            ItinerarioActivo.Disponibilidades.Add(new ItinerarioHotel{ Disponibilidad = disp, Desde = desde, Hasta = hasta });
        }
    }

    public static Itinerario LlamarItinerarioActivo()
    {
        return ItinerarioActivo;
    }

    public static void ModificarItinerario(string codItinerario, string nombre, string CUIL)
    {
        foreach (Itinerario itinerario in Itinerarios)
        {
            if (string.Equals(itinerario.CodigoItinerario.ToString(), codItinerario))
            {
                itinerario.NombreCliente = nombre;
                itinerario.CUILCUIT = CUIL;
                return;
            }
        }
    }

    public static void EliminarItinerario(string codItinerario)
    {
        foreach (Itinerario itinerario in Itinerarios)
        {
            if (string.Equals(itinerario.CodigoItinerario.ToString(), codItinerario))
            {
                Itinerarios.Remove(itinerario);
                return;
            }
        }

    }
    public static void AgregarItinerario(Itinerario itinerario)
    {
        Itinerarios.Add(itinerario);
    }

    public static void AgregarTarifasAItinerarioActivo(List<TarifaVuelo> tarifas)
    {
        ItinerarioActivo.TarifasVuelos = tarifas;
    }

    public static void AgregarDisponibilidadesAItinerarioActivo(List<ItinerarioHotel> disp)
    {
        ItinerarioActivo.Disponibilidades = disp;
    }

    public static Itinerario DevolverItinerarioActivo(Itinerario itinerarioActivo)
    {
        foreach (Itinerario itinerario in Itinerarios)
        {
            if (itinerarioActivo.CodigoItinerario == itinerario.CodigoItinerario)
            {
                return itinerario;
            }
        }
        return null;
    }

    public static void CalcularPrecioTotalItinerarioActivo()
    {
        decimal PrecioTotal = 0;
        foreach (ItinerarioHotel disp in ItinerarioActivo.Disponibilidades)
        {
            for (DateTime i = disp.Desde.Date; i < disp.Hasta.Date; i = i.AddDays(1.0))
            {
                PrecioTotal += disp.Disponibilidad.TarifaDiaria;
            }
        }
        foreach (TarifaVuelo tarifa in ItinerarioActivo.TarifasVuelos)
        {
            PrecioTotal += tarifa.Precio;
        }
        ItinerarioActivo.PrecioTotal = PrecioTotal;
    }

    public static void ItinerarioReservadoTrue(Itinerario itinerario)
    {
        Itinerario itinerarioAModificar = DevolverItinerarioActivo(itinerario);
        itinerarioAModificar.EstaReservado = true;
    }

    public static void ItinerarioReservadoFalse(Itinerario itinerario)
    {
        Itinerario itinerarioAModificar = DevolverItinerarioActivo(itinerario);
        itinerarioAModificar.EstaReservado = false;
    }
}
