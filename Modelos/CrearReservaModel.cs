using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Prototipo_CAI;

internal class CrearReservaModel
{
    public string ValidarCampos(string nombreApellido, string dni, DateTime fechaNac, string nacionalidad, string genero)
    {
        string errores = "";

        //Nombre y Apellido
        if (string.IsNullOrWhiteSpace(nombreApellido))
        {
            errores += "El Nombre y Apellido no debe estar vacío.\n";
        }
        else if (!(Regex.IsMatch(nombreApellido, @"^[a-zA-Z\s]+$")))
        {
            errores += "El Nombre y Apellido no debe contener caracteres numéricos o símbolos.\n";
            
        }
        if (nombreApellido.Length > 45)
        {
            errores += "El Nombre y Apellido no puede tener más de 45 caracteres.\n";
        }
        //DNI
        if (string.IsNullOrWhiteSpace(dni))
        {
            errores += "El DNI no debe estar vacío.\n";
        }
        if (!int.TryParse(dni, out int salida))
        {
            errores += "El DNI debe ser numérico.\n";
        }
        if (dni.Length < 7 || dni.Length > 8)
        {
            errores += "El DNI debe tener entre 7 y 8 dígitos.\n";
        }
        //Fecha de Nacimiento
        if (fechaNac > DateTime.Now)
        {
            errores += "La Fecha de Nacimiento debe ser menor a la fecha actual.";
        }
        //Nacionalidad
        if(string.IsNullOrWhiteSpace(nacionalidad))
        {
            errores += "La Nacionalidad no debe estar vacía.\n";
        }
        //Género
        if (string.IsNullOrWhiteSpace(genero))
        {
            errores += "El Género no debe estar vacío.\n";
        }

        return errores;
    }

    public Itinerario ObtenerItinerarioActivo()
    {
        return ModuloItinerarios.ItinerarioActivo;
    }

    public Hotel ObtenerInfoHotel(string codHotel)
    {
        Hotel hotel = ModuloHoteles.ObtenerInfoHotel(codHotel);
        return hotel;
    }

    public Vuelo ObtenerInfoVuelo(string codVuelo)
    {
        Vuelo vuelo = ModuloVuelos.ObtenerInfoVuelo(codVuelo);
        return vuelo;
    }

    public string ValidarPasajeroTarifas(List<ItemCheckBox> list)
    {
        string cosa = string.Empty;
        foreach (ItemCheckBox item in list)
        {
            if (item.Hotel == null)
            {
                cosa+="vuelo;";
            }
            if (item.Vuelo == null)
            {
                cosa+="hotel";
            }
        }
        return cosa;
    }

    public ListViewItem FormatoPasajeroReserva(string nombreApellido, string dni, DateTime fechaNac, string nacionalidad, string genero, string tarifasAsociadas)
    {
        ListViewItem item = new ListViewItem(nombreApellido);
        item.SubItems.Add(dni);
        item.SubItems.Add(nacionalidad);
        item.SubItems.Add(genero);
        item.SubItems.Add(fechaNac.ToString("dd-MM-yyyy"));
        item.SubItems.Add(tarifasAsociadas);
        return item;

    }

    public bool ValidarUsoTarifas(List<ItemCheckBox> listcb, List<ListViewItem> listlsv)
    {
        // crear lista con todas las tarifas usadas

        List<int> CodigosTarifas = new();
        foreach (ListViewItem item in listlsv)
        {
            string[] vector = item.SubItems[5].Text.Split(';');
            foreach (string s in vector)
            {
                if (!CodigosTarifas.Contains(Convert.ToInt32(s)))
                {
                    CodigosTarifas.Add(Convert.ToInt32(s));
                }
            }
        }

        // comparar listas 1 y 2

        foreach (ItemCheckBox item in listcb)
        {
            if (!CodigosTarifas.Contains(item.CodTarifa))
            {
                return false;
            }
        }

        return true;
    }

    public string ValidarRepetidos(string dni, List<ListViewItem> list)
    {
        foreach (ListViewItem item in list)
        {
            if (item.SubItems[1].Text == dni)
            {
                return "No puede haber 2 pasajeros con el mismo DNI.";
            }
        }
        return "";
    }

    public string ValidarDisponibilidadTarifas(List<ItemCheckBox> list)
    {
        Dictionary<TarifaVuelo,int> listTarifaVuelos = new();
        List<ItinerarioHotel> temp = new();
        Dictionary<ItinerarioHotel, int> listItinerarioHotel = new();
        string errores = string.Empty;

        // LLENO LISTA DE TARIFAVUELO ACUMULADOS POR MISMA TARIFAVUELO

        foreach (ItemCheckBox item in list)
        {
            if (item.Hotel == null)
            {
                if (!listTarifaVuelos.TryGetValue(item.Vuelo, out int salida))
                {
                    listTarifaVuelos.Add(item.Vuelo, 1);
                }
                else
                {
                    listTarifaVuelos[item.Vuelo]++;
                }
            }
            if (item.Vuelo == null)
            {
                temp.Add(item.Hotel);
            }
        }

        // LISTA TEMPORAL PARA SEPARAR HOTELES DE VUELOS Y ACUMULAR HABITACIONES EN NUEVA LISTA

        foreach (ItinerarioHotel itinerarioHotel in temp)
        {
            bool flag = false;

            foreach (KeyValuePair<ItinerarioHotel, int> item in listItinerarioHotel)
            {
                if (itinerarioHotel.Disponibilidad == item.Key.Disponibilidad && itinerarioHotel.Desde == item.Key.Desde && itinerarioHotel.Hasta == item.Key.Hasta)
                {
                    listItinerarioHotel[item.Key]++;
                    flag = true;
                }
            }
            if (!flag)
            {
                listItinerarioHotel.Add(itinerarioHotel, 1);
            }
            flag = false;
        }

        // DEBUG, IGNORAR

        /*foreach (KeyValuePair<ItinerarioHotel, int> item in listItinerarioHotel)
        {
            MessageBox.Show($"Veces que uso este tipo habitación: {item.Value}");
        }
        foreach (KeyValuePair<TarifaVuelo,int> item in listTarifaVuelos)
        {
            MessageBox.Show($"Veces que uso este asiento: {item.Value}");
        }*/

        // FUNCIONES PARA VALIDAD DISPONIBILIDAD

        foreach (KeyValuePair<TarifaVuelo,int> kvp in listTarifaVuelos)
        {
            errores += ModuloVuelos.ValidarDisponibilidadVuelo(kvp.Key,kvp.Value);
        }
        foreach (KeyValuePair<ItinerarioHotel, int> kvp in listItinerarioHotel)
        {
            errores += ModuloHoteles.ValidarDisponibilidadHoteles(kvp.Key, kvp.Value);
        }

        return errores;

        // NO LA PROBE MUCHO, HAY QUE FORZAR BASTANTE ESTA FUNCION A VER SI SE ROMPE
    }

    public char CalcularTipoPasajero(DateTime fechaNacimiento)
    {

        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - fechaNacimiento.Year;

        if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
        {
            edad--;
        }
        if (edad < 2)
        {
            return 'I';
        }
        else if (edad < 12)
        {
            return 'M';
        }
        else
        {
            return 'A';
        }
    }

    public int CalcularEdad(DateTime fechaNacimiento)
    {

        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - fechaNacimiento.Year;

        if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
        {
            edad--;
        }
        return edad;
    }

    public string ValidarPasajerosTarifas(List<ItemCheckBox> listcb, List<ListViewItem> listlsv)
    {
        string errores = "";
        foreach (ItemCheckBox item in listcb)
        {
            if (item.Hotel == null)
            {
                int contador = 0;
                foreach (ListViewItem lsvitem in listlsv)
                {
                    string[] vector = lsvitem.SubItems[5].Text.Split(';');
                    List<int> list = new();
                    char tipoPasajero = CalcularTipoPasajero(Convert.ToDateTime(lsvitem.SubItems[4].Text));
                    foreach (string s in vector)
                    {
                        list.Add(int.Parse(s));
                    }
                    if (list.Contains(item.CodTarifa))
                    {
                        contador++;
                        if (tipoPasajero != item.Vuelo.TipoPasajero)
                        {
                            errores += $"No puede asignar un pasajero tipo '{tipoPasajero}' a la tarifa {item.CodTarifa} (Debe ser '{item.Vuelo.TipoPasajero}').\n";
                        }
                    }
                }
                if (contador > 1)
                {
                    errores += $"No puede asignar la tarifa {item.CodTarifa} a 2 o más pasajeros distintos.\n";
                }
            }

            if (item.Vuelo == null)
            {
                int contadorAdulto = 0;
                int contadorMenor = 0;
                int contadorInfante = 0;
                foreach (ListViewItem lsvitem in listlsv)
                {
                    string[] vector = lsvitem.SubItems[5].Text.Split(';');
                    List<int> list = new();
                    int edad = CalcularEdad(Convert.ToDateTime(lsvitem.SubItems[4].Text));
                    foreach (string s in vector)
                    {
                        list.Add(int.Parse(s));
                    }
                    if (list.Contains(item.CodTarifa))
                    {
                        if (edad < 2) { contadorInfante++; }
                        else if (edad < 12) { contadorMenor++; }
                        else { contadorAdulto++; }
                    }
                }
                if (contadorAdulto == 0)
                {
                    errores += $"La tarifa {item.CodTarifa} no puede tener 0 adultos asignados.\n";
                }
                if ((contadorAdulto+contadorInfante+contadorMenor)>item.Hotel.Disponibilidad.Capacidad)
                {
                    errores += $"La cantidad de huéspedes asignados a la tarifa {item.CodTarifa} supera la capacidad máxima de esta.\n";
                }
                if (contadorAdulto > item.Hotel.Disponibilidad.Adultos)
                {
                    errores += $"La cantidad de adultos asignados a la tarifa {item.CodTarifa} supera la capacidad máxima de adultos de esta.\n";
                }
                if (contadorMenor > item.Hotel.Disponibilidad.Menores)
                {
                    errores += $"La cantidad de menores asignados a la tarifa {item.CodTarifa} supera la capacidad máxima de menores de esta.\n";
                }
                if (contadorInfante > item.Hotel.Disponibilidad.Infantes)
                {
                    errores += $"La cantidad de infantes asignados a la tarifa {item.CodTarifa} supera la capacidad máxima de infantes de esta.\n";
                }
            }
        }
        return errores;
    }

    public void CrearReserva(List<ItemCheckBox> listcb, List<ListViewItem> listlsv)
    {
        Itinerario itinerarioActivo = ModuloItinerarios.LlamarItinerarioActivo();
        Itinerario itinerarioAsociado = ModuloItinerarios.DevolverItinerarioActivo(itinerarioActivo);
        List<TarifaPasajero> pasajeros = new();
        string estadoReserva = "Pendiente";
        DateTime fechaReserva = DateTime.Now;
        int codReserva = ModuloReservas.ObtenerUltimoCodigoReserva() + 1;
        foreach (ListViewItem lsvitem in listlsv)
        {
            List<DisponibilidadItinerario> listDisp = new();
            List<TarifaVueloItinerario> listTarifa = new();
            string nombre = lsvitem.Text;
            string dni = lsvitem.SubItems[1].Text;
            string nacionalidad = lsvitem.SubItems[2].Text;
            string genero = lsvitem.SubItems[3].Text;
            DateTime fechaNac = Convert.ToDateTime(lsvitem.SubItems[4].Text);
            string[] vector = lsvitem.SubItems[5].Text.Split(';');
            List<int> list = new();
            foreach (string s in vector)
            {
                list.Add(int.Parse(s));
            }
            foreach (ItemCheckBox item in listcb)
            {
                if (list.Contains(item.CodTarifa) && item.Hotel == null)
                {
                    TarifaVueloItinerario tarifa = new();
                    tarifa.CodigoVuelo = item.Vuelo.CodigoVuelo;
                    tarifa.CodigoTarifa = item.CodTarifa;
                    listTarifa.Add(tarifa);
                }
                if (list.Contains(item.CodTarifa) && item.Vuelo == null)
                {
                    DisponibilidadItinerario disp = new();
                    disp.CodigoDisponiblidad = item.Hotel.Disponibilidad.CodigoDisponibilidad;
                    disp.FechaDesde = item.Hotel.Desde;
                    disp.FechaHasta = item.Hotel.Hasta;
                    listDisp.Add(disp);
                }
            }
            TarifaPasajero pasajero = new();
            pasajero.Nombre = nombre;
            pasajero.DNI = Convert.ToInt32(dni);
            pasajero.Nacionalidad = nacionalidad;
            pasajero.Genero = genero;
            pasajero.DisponibilidadesAsociadas = listDisp;
            pasajero.TarifasVuelosAsociadas = listTarifa;
            pasajeros.Add(pasajero);
        }

        Reserva reserva = new();
        reserva.CodigoReserva = codReserva;
        reserva.FechaReserva = fechaReserva;
        reserva.EstadoReserva = estadoReserva;
        reserva.ItinerarioAsociado = itinerarioAsociado;
        reserva.TarifasPasajeros = pasajeros;
        ModuloReservas.AgregarReserva(reserva);
        foreach (ItemCheckBox itemcb in listcb)
        {
            if (itemcb.Vuelo == null)
            {
                ModuloHoteles.ReducirDisponibilidadHotel(itemcb.Hotel);
            }
            if (itemcb.Hotel == null)
            {
                ModuloVuelos.ReducirDisponibilidadVuelo(itemcb.Vuelo);
            }
        }
        MessageBox.Show($"Se ha creado una pre-reserva exitósamente. Su código de reserva es {codReserva}.");

        ModuloItinerarios.ItinerarioReservadoTrue(itinerarioAsociado);
    }

    public string ValidarVuelosRepetidos(List<ItemCheckBox> list)
    {
        List<string> codVuelos = new();
        foreach (ItemCheckBox itemcb in list)
        {
            if (itemcb.Hotel == null)
            {
                if (codVuelos.Contains(itemcb.Vuelo.CodigoVuelo))
                {
                    return $"No puede asignar más de un asiento del vuelo {itemcb.Vuelo.CodigoVuelo} al pasajero.";
                }
                else
                {
                    codVuelos.Add(itemcb.Vuelo.CodigoVuelo);
                }
            }
        }
        return "";
    }

}
