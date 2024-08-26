using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



using FontAwesome.Sharp; //nuevo 
using System.Drawing.Text;
using System.Windows.Media;

namespace Prototipo_CAI;

public partial class Itinerarios : Form
{
    private IconButton botonActual; //boton en el que estamos
    private Panel bordeIzquierdo; // para poner un borde izquierdo al boton
    public Itinerarios()
    {
        InitializeComponent();
        bordeIzquierdo = new Panel(); // inicializo lo de arriba
        bordeIzquierdo.Size = new Size(7, 60); //el 60 es igual al tamaño del boton
        panelMenuItinerario.Controls.Add(bordeIzquierdo); //lo agregamos al panel
        Size = new Size(740, 346);
    }

    #region Boton Activado/Desactivado
    private void botonActivado(object sender, System.Drawing.Color color)
    {
        if (sender != null)
        {
            BotonDesactivado();
            //boton
            botonActual = (IconButton)sender; // asignamos el boton actual al boton remitente 
            botonActual.BackColor = System.Drawing.Color.FromArgb(36, 72, 100);
            botonActual.ForeColor = color;
            //botonActual.TextAlign = ContentAlignment.MiddleCenter;
            botonActual.IconColor = color;
            //botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
            //botonActual.ImageAlign = ContentAlignment.MiddleRight;

            //ahora el borde del boton
            bordeIzquierdo.BackColor = color;
            bordeIzquierdo.Location = new Point(0, botonActual.Location.Y);
            bordeIzquierdo.Visible = true;
            bordeIzquierdo.BringToFront();
        }
    }

    private void BotonDesactivado()
    {
        if (botonActual != null)
        {
            botonActual.BackColor = System.Drawing.Color.FromArgb(8, 32, 50);
            botonActual.ForeColor = System.Drawing.Color.White;
            //botonActual.TextAlign = ContentAlignment.MiddleLeft;
            botonActual.IconColor = System.Drawing.Color.White;
            //botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
            //botonActual.ImageAlign = ContentAlignment.MiddleLeft;
        }
    }

    #endregion

    #region Extension Submenu

    private void mostrarDatos()
    {
        Size = new Size(1050, 346);
        iconbtnNuevoItinerario.Enabled = false;
        //iconbtnNuevoItinerario.ForeColor = System.Drawing.Color.White;
        iconbtnDatosCliente.Enabled = false;
        //iconbtnDatosCliente.ForeColor = System.Drawing.Color.White;
        iconbtnEstItinerarioActivo.Enabled = false;
        //iconbtnEstItinerarioActivo.ForeColor = System.Drawing.Color.White;
        iconbtnEliminarItinerario.Enabled = false;
        //iconbtnEliminarItinerario.ForeColor= System.Drawing.Color.White;
        iconbtnCrearReservaItinerario.Enabled = false;
        //iconbtnCrearReservaItinerario.ForeColor = System.Drawing.Color.White;
    }

    private void esconderDatos()
    {
        Size = new Size(740, 346);
        txtNombreCliente.Clear();
        txtCuilCuit.Clear();
        iconbtnNuevoItinerario.Enabled = true;
        iconbtnDatosCliente.Enabled = true;
        iconbtnEstItinerarioActivo.Enabled = true;
        iconbtnEliminarItinerario.Enabled = true;
        iconbtnCrearReservaItinerario.Enabled = true;
        lsvItinerario.Enabled = true;

    }

    #endregion

    #region Cargar lista
    ItinerariosModel model = new();

    private void Itinerarios_Load(object sender, EventArgs e)
    {
        foreach (ListViewItem item in model.FormatoItinerarios())
        {
            lsvItinerario.Items.Add(item);
        }
    }
    #endregion

    #region Nuevo itinerario
    private void iconbtnNuevoItinerario_Click(object sender, EventArgs e)
    {
        botonActivado(sender, System.Drawing.Color.FromArgb(255, 255, 255));
        btnModificar.Enabled = false;
        btnAceptar.Enabled = true;
        lblNombreSubmenu.Text = "Nuevo cliente";

        var r = MessageBox.Show("Desea agregar datos de cliente?", "Crear Itinerario", MessageBoxButtons.YesNoCancel);
        if (r == DialogResult.Yes)
        {
            mostrarDatos();
        }
        if (r == DialogResult.No)
        {
            int ultimoCodigo = 0;
            if (ItinerariosAlmacen.Itinerarios.Count > 0)
            {
                ultimoCodigo = ItinerariosAlmacen.Itinerarios.Last().CodigoItinerario;
            }
            int codigoSiguiente = ultimoCodigo + 1;
            model.AgregarItinerario(codigoSiguiente, "", "");

            lsvItinerario.Items.Clear();
            foreach (ListViewItem item in model.FormatoItinerarios())
            {
                lsvItinerario.Items.Add(item);
            }

            MessageBox.Show($"Se ha creado el itinerario correctamente. Su código de itinerario es {codigoSiguiente}.", "Itinerario Creado");
        }
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
        string nombreRZ = txtNombreCliente.Text;
        string cuilcuit = txtCuilCuit.Text;
        string errores = model.ValidarCampos(nombreRZ, cuilcuit);

        if (string.IsNullOrWhiteSpace(errores))
        {
            var ultimoCodigo = 0;
            if (ItinerariosAlmacen.Itinerarios.Count > 0)
            {
                ultimoCodigo = ItinerariosAlmacen.Itinerarios.Last().CodigoItinerario;
            }
            int codigoSiguiente = ultimoCodigo + 1;
            model.AgregarItinerario(codigoSiguiente, cuilcuit, nombreRZ);

            var item = new ListViewItem();
            item.Text = codigoSiguiente.ToString();
            item.SubItems.Add(cuilcuit);
            item.SubItems.Add(nombreRZ);
            item.SubItems.Add("False");

            lsvItinerario.Items.Add(item);

            MessageBox.Show($"Se ha creado el itinerario correctamente. Su código de itinerario es {codigoSiguiente}.", "Itinerario Creado");
            esconderDatos();


        }
        else
        {
            MessageBox.Show(errores, "Error");
        }
        //Se debería agregar los datos del cliente en la lista del formulario "Itinerario".
    }

    #endregion

    #region Modificar Datos

    private void iconbtnDatosCliente_Click(object sender, EventArgs e)
    {
        botonActivado(sender, System.Drawing.Color.FromArgb(255, 255, 255));
        btnAceptar.Enabled = false;
        btnModificar.Enabled = true;
        lblNombreSubmenu.Text = "Editar cliente";

        if (lsvItinerario.SelectedItems.Count == 0)
        {
            MessageBox.Show("Selecciona un itinerario de la lista.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var ItinerarioSeleccionado = lsvItinerario.SelectedItems[0].SubItems;

        txtNombreCliente.Text = ItinerarioSeleccionado[2].Text;
        txtCuilCuit.Text = ItinerarioSeleccionado[1].Text;

        mostrarDatos();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
        model.ModificarItinerario(lsvItinerario.SelectedItems[0].Text, txtNombreCliente.Text, txtCuilCuit.Text);


        var error = model.ModificarCliente(txtNombreCliente.Text, txtCuilCuit.Text);
        if (error != null)
        {
            MessageBox.Show(error, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        lsvItinerario.Items.Clear();
        foreach (ListViewItem item in model.FormatoItinerarios())
        {
            lsvItinerario.Items.Add(item);
        }

        lsvItinerario.Enabled = true;
        esconderDatos();
    }

    #endregion

    #region Itinerario activo
    private void iconbtnEstItinerarioActivo_Click(object sender, EventArgs e)
    {
        botonActivado(sender, System.Drawing.Color.FromArgb(255, 255, 255));

        if (lsvItinerario.SelectedItems.Count == 0)
        {
            MessageBox.Show("Seleccione un itinerario.", "Error");
        }
        else
        {
            var item = lsvItinerario.SelectedItems[0];
            if (item.SubItems[3].Text.ToLower() == "true")
            {
                MessageBox.Show("El itinerario seleccionado ya está reservado.", "Error");
            }
            else
            {
                string codItinerario = lsvItinerario.SelectedItems[0].Text;
                model.CambiarItinerarioActivo(codItinerario);
                MessageBox.Show($"Se ha establecido el itinerario {codItinerario} como activo.");
            }
        }
    }
    #endregion

    #region Eliminar itinerario
    private void iconbtnEliminarItinerario_Click(object sender, EventArgs e)
    {
        botonActivado(sender, System.Drawing.Color.FromArgb(255, 255, 255));
        if (lsvItinerario.SelectedItems.Count == 0)
        {
            MessageBox.Show("Debe seleccionar un itinerario de la lista.", "Error");
        }
        else
        {
            var item2 = lsvItinerario.SelectedItems[0];
            if (ModuloItinerarios.ItinerarioActivo != null && Convert.ToInt32(item2.Text) == ModuloItinerarios.ItinerarioActivo.CodigoItinerario)
            {
                MessageBox.Show("No puede eliminar el itinerario activo.", "Error");
                return;
            }
            if (item2.SubItems[3].Text.ToLower() == "true")
            {
                MessageBox.Show("No puede eliminar un itinerario reservado.", "Error");
                return;
            }
            var r = MessageBox.Show("Desea eliminar datos de cliente?", "Eliminar itinerario", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                model.EliminarItinerario(lsvItinerario.SelectedItems[0].Text);
                lsvItinerario.Items.Clear();
                foreach (ListViewItem item in model.FormatoItinerarios())
                {
                    lsvItinerario.Items.Add(item);
                }
            }

        }
    }
    #endregion

    #region Crear reserva
    private void iconbtnCrearReservaItinerario_Click(object sender, EventArgs e)
    {
        botonActivado(sender, System.Drawing.Color.FromArgb(255, 255, 255));

        if (lsvItinerario.SelectedItems.Count > 0)
        {
            var item = lsvItinerario.SelectedItems[0];
            if (item.SubItems[3].Text.ToLower() == "true")
            {
                MessageBox.Show("El itinerario seleccionado ya está reservado.", "Error");
            }
            else
            {
                string codItinerario = item.Text;
                model.CambiarItinerarioActivo(codItinerario);
                CrearReserva crearReserva = new();
                crearReserva.ShowDialog();
                lsvItinerario.Items.Clear();
                foreach (ListViewItem item2 in model.FormatoItinerarios())
                {
                    lsvItinerario.Items.Add(item2);
                }
            }
        }
        else
        {
            MessageBox.Show("Seleccione un itinerario.", "Error");
        }
    }


    #endregion

    #region Filtrar 

    /*Esto se puede mejorar con una función y llamar a la función directamente esto es una *****. También se puede agregar la función de 
    presionar enter y buscar*/

    private void iconbtnBuscarItinerario_Click(object sender, EventArgs e)
    {
        BuscarItinerario(txtBuscarItinerario.Text);
    }

    private void iconbtnLimpiarBuscarItinerario_Click(object sender, EventArgs e)
    {
        lsvItinerario.Items.Clear();
        foreach (ListViewItem item in model.FormatoItinerarios())
        {
            lsvItinerario.Items.Add(item);
        }
        txtBuscarItinerario.Clear();
    }


    public void BuscarItinerario(string textoBuscador)
    {
        if (!string.IsNullOrWhiteSpace(textoBuscador))
        {
            var contador = 0;

            foreach (ListViewItem item in lsvItinerario.Items)
            {
                string codigo = item.Text;
                string cuit = item.SubItems[1].Text;
                string razonsocial = item.SubItems[2].Text;

                if (codigo.Equals(textoBuscador, StringComparison.OrdinalIgnoreCase))
                {
                    if (contador == 0)
                        lsvItinerario.Items.Clear();

                    lsvItinerario.Items.Add(item);
                    contador++;

                }
                else if (cuit.Equals(textoBuscador, StringComparison.OrdinalIgnoreCase))
                {
                    if (contador == 0)
                        lsvItinerario.Items.Clear();

                    lsvItinerario.Items.Add(item);
                    contador++;
                }
                else if (razonsocial.ToLower().Contains(textoBuscador.ToLower()))
                {
                    if (contador == 0)
                        lsvItinerario.Items.Clear();

                    lsvItinerario.Items.Add(item);
                    contador++;
                }
                else if (contador == 0)
                {
                    lsvItinerario.Items.Clear();
                }
            }
        }
        else
        {
            MessageBox.Show("Debe indicar el itinerario a buscar.");
        }
    }

    private void txtBuscarItinerario_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            BuscarItinerario(txtBuscarItinerario.Text);
        }
    }
    #endregion

    #region Boton cancelar
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        esconderDatos();
        lsvItinerario.Enabled = true;
    }
    #endregion

    private void lsvItinerario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    #region Tamaño

    private void lsvItinerario_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
    {
        if (lsvItinerario.Columns[e.ColumnIndex].Width < 50)
        {
            lsvItinerario.Columns[e.ColumnIndex].Width = 50;
        }
        if (lsvItinerario.Columns[e.ColumnIndex].Width > 180)
        {
            lsvItinerario.Columns[e.ColumnIndex].Width = 180;
        }
    }

    #endregion

}
