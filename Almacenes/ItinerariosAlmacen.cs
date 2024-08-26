using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class ItinerariosAlmacen
{
    public readonly static List<Itinerario> Itinerarios;

    static ItinerariosAlmacen()
    {
        var itinerariosJson = File.ReadAllText("Itinerarios.json");
        Itinerarios = JsonConvert.DeserializeObject<List<Itinerario>>(itinerariosJson);
    }

    public static void Grabar()
    {
        var itinerariosJson = JsonConvert.SerializeObject(Itinerarios);
        File.WriteAllText("Itinerarios.json", itinerariosJson);
    }
}
