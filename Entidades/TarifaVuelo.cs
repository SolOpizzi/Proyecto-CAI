using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototipo_CAI;   

public class TarifaVuelo
{
    public int CodigoTarifaVuelo { get; set; }
    public char Clase { get; set; }
    public string CodigoVuelo { get; set; }
    public decimal Precio { get; set; }
    public int TarifasVuelosDisponibles { get; set; }
    public char TipoPasajero { get; set; }
}