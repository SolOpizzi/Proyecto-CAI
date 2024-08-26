using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI
{
    public class ItemCheckBox
    {
        public ItinerarioHotel Hotel { get; set; } //uno de los es nulo
        public TarifaVuelo Vuelo { get; set; }
        public string Descripcion { get; set; }
        public int CodTarifa { get; set; } //identificador en la pantalla crearreserva

        public override string ToString() //crear una descripcion para el item
        {
            return Descripcion;
        }
    }
}
