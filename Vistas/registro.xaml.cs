namespace aaguirreexamen.Vistas;

public partial class registro : ContentPage
{
	public registro( string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = "Usuario conectado:" + usuario;
		//pendiente
    }


    private void btnCalcular_Clicked_1(object sender, EventArgs e)
    {
        // Validar si la entrada es un número válido y está en el rango especificado
        if (double.TryParse(entryMontoInicial.Text, out double montoInicial) && montoInicial > 0 && montoInicial < 1500)
        {
            // Asignar las variables correspondientes a los Entry
            string nombre = entryNombre.Text;
            string apellido = entryApellido.Text;
            string edad = entryEdad.Text;

            // Calcular el monto restante después del pago inicial
            double montoRestante = 1500 - montoInicial;

            // Calcular el monto adicional por cuota (4% del costo original)
            double porcentajeAdicional = 0.04;
            double montoAdicionalPorCuota = 1500 * porcentajeAdicional;

            // Calcular el pago mensual (restante + adicional por cuota dividido entre 4)
            double pagoMensual = (montoRestante + (montoAdicionalPorCuota * 4)) / 4;

            // Mostrar el resultado en el Entry correspondiente
            entryPagoMensual.Text = pagoMensual.ToString();
        }
        else
        {
            // Mostrar una alerta si la entrada no es un número válido o está fuera del rango
            DisplayAlert("Error", "Ingrese un monto inicial válido (mayor a 0 y menor a 1500).", "OK");
        }
    }



    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        DateTime fechaSeleccionada = dpFecha.Date;
        string paisSeleccionado = pkPaises.SelectedItem?.ToString();
        string ciudadSeleccionada = pkCiudades.SelectedItem?.ToString();
        double montoInicial = 0;
        double.TryParse(entryMontoInicial.Text, out montoInicial);
        double pagoMensual = Convert.ToDouble(entryPagoMensual.Text);
        string nombre = entryNombre.Text;
        string apellido = entryApellido.Text;
        string edad = entryEdad.Text;

        Navigation.PushAsync(new Vistas.resumen(
            lblUsuario.Text,
            fechaSeleccionada,
            paisSeleccionado,
            ciudadSeleccionada,
            montoInicial,
            pagoMensual,
            nombre,
            apellido,
            edad));
    }

}