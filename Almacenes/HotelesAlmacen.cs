using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal static class HotelesAlmacen
{
    public readonly static List<Hotel> Hoteles;

    static HotelesAlmacen()
    {
        var hotelesJson = File.ReadAllText("Hoteles.json");
        Hoteles = JsonConvert.DeserializeObject<List<Hotel>>(hotelesJson);
    }

    public static void Grabar()
    {
        var hotelesJson = JsonConvert.SerializeObject(Hoteles);
        File.WriteAllText("Hoteles.json", hotelesJson);
    }
}
