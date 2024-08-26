using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

public class TarifaPasajero
{
    public string Nombre { get; set; }
    public int DNI { get; set; }    
    // public string Pasaporte { get; set; }      //Son de 3 letras y 6 números.
    public DateTime FechaNacimiento { get; set; }
    public string Nacionalidad { get; set; }
    public string Genero { get; set; }
    public List<DisponibilidadItinerario> DisponibilidadesAsociadas { get; set; }
    public List<TarifaVueloItinerario> TarifasVuelosAsociadas { get; set; }
}
