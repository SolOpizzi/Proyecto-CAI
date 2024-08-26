using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

public class Itinerario
{
    public int CodigoItinerario { get; set; }
    public string CUILCUIT { get; set; }
    public List<ItinerarioHotel> Disponibilidades { get; set; }
    public bool EstaReservado { get; set; }
    public string NombreCliente { get; set; }
    public List<TarifaVuelo> TarifasVuelos { get; set; }
    public decimal PrecioTotal { get; set; }
}
