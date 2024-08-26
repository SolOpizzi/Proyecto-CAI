using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI;

public class Disponibilidad
{
    public int CodigoDisponibilidad { get; set; }
    public string CodigoHotel { get; set; }
    public string Nombre { get; set; }
    public int Capacidad { get; set; }
    public int Adultos { get; set; }
    public int Infantes { get; set; }
    public int Menores { get; set; }
    public Dictionary<DateTime, int> DiasDisponibles { get; set; }
    public decimal TarifaDiaria { get; set; }

}