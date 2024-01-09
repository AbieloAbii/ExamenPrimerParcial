namespace aaguirreexamen.Vistas;

public partial class resumen : ContentPage
{
    public resumen(
        string usuario,
        DateTime fecha,
        string pais,
        string ciudad,
        double montoInicial,
        double pagoMensual,
        string nombre,
        string apellido,
        string edad)
    {
        InitializeComponent();

        lblUsuario.Text = usuario;
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblEdad.Text = edad;
        lblFecha.Text = fecha.ToString("MM/dd/yyyy");
        lblCiudad.Text = ciudad;
        lblPais.Text = pais;
        lblMontoInicial.Text = montoInicial.ToString();
        lblPagoMensual.Text = pagoMensual.ToString();

        // Calcular el pago total
        double porcentajeAdicional = 0.04;
        double costoCurso = 1500;
        double montoRestante = costoCurso - montoInicial;
        double montoAdicionalPorCuota = costoCurso * porcentajeAdicional;
        double totalPagosMensuales = montoRestante + (montoAdicionalPorCuota * 4);
        lblPagoTotal.Text = (montoInicial + totalPagosMensuales).ToString();
    }

    private void btnCerrarSesion_Clicked(object sender, EventArgs e)
    {
        // Volver a la página de inicio (login)
        Navigation.PopToRootAsync();

        // Limpiar campos de usuario y contraseña en la página de inicio (login)
        if (Application.Current.MainPage is NavigationPage navigationPage)
        {
            if (navigationPage.RootPage is login loginPage)
            {
                loginPage.LimpiarCampos();
            }
        }
    }
}
