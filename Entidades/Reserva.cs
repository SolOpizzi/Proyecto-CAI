using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

public class Reserva
{
    public int CodigoReserva { get; set; }
    public string EstadoReserva { get; set; }
    public DateTime FechaReserva { get; set; }
    public Itinerario ItinerarioAsociado { get; set; }
    public List<TarifaPasajero> TarifasPasajeros { get; set; }
}
