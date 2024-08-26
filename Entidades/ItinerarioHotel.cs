namespace Prototipo_CAI;

public class ItinerarioHotel
{
    public Disponibilidad Disponibilidad { get; set; } //lo que el hotel tiene disponible.
    public DateTime Desde { get; set; } //dias que quiero reservar en el filtro
    public DateTime Hasta { get; set; }
}
