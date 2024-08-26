using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class VuelosAlmacen
{
    public readonly static List<Vuelo> Vuelos;

    static VuelosAlmacen()
    {
        var vuelosJson = File.ReadAllText("Vuelos.json");
        Vuelos = JsonConvert.DeserializeObject<List<Vuelo>>(vuelosJson);
    }

    public static void Grabar()
    {
        var vuelosJson = JsonConvert.SerializeObject(Vuelos);
        File.WriteAllText("Vuelos.json", vuelosJson);
    }
}
