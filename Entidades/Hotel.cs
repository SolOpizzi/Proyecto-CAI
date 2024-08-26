using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI;

public class Hotel
{
    public string CodigoHotel { get; set; }
    public int Calificacion { get; set; }
    public string CodigoCiudad { get; set; }
    public string Direccion { get; set; }
    public List<Disponibilidad> Disponibilidades { get; set; }
    public string Nombre { get; set; }
}