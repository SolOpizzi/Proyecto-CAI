using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototipo_CAI;

//ver lo de serializable

internal static class ReservasAlmacen
{

    public readonly static List<Reserva> Reservas;

    static ReservasAlmacen()
    {
        try
        {
            var reservasJson = File.ReadAllText("Reservas.json");
            Reservas = JsonConvert.DeserializeObject<List<Reserva>>(reservasJson);
        }
        catch (JsonSerializationException ex)
        {
            MessageBox.Show($"Error de carga JSON: {ex.Message}");
            if (ex.InnerException != null)
            {
                MessageBox.Show($"Excepción: {ex.InnerException.Message}");
            }
            Reservas = new List<Reserva>();
        }
        catch (Exception ex)
        {
            {
                MessageBox.Show($"Error desconocido: {ex.Message}");
                Reservas = new List<Reserva>();
            }
        }
    }

    public static void Grabar()
    {
        var reservasJson = JsonConvert.SerializeObject(Reservas);
        File.WriteAllText("Reservas.json", reservasJson);
    }

    /*static ReservasAlmacen()
   {
       var reservasJson = File.ReadAllText("Reservas.json");
       Reservas = JsonConvert.DeserializeObject<List<Reserva>>(reservasJson);
   }*/

}

