namespace aaguirreexamen.Vistas;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        //Creación de los usuarios
        string[] usuarios = { "estudiante2024", "examen1", "NombreEstudiante" };
        string[] contrasenas = { "uisrael2024", "parcial1", "2024" };

        string usuario = entryUsuario.Text;
        string contrasena = entryContrasena.Text;

        bool verificar = false;

        //Recorrer los usuarios 
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuario == usuarios[i] && contrasena == contrasenas[i])
            {
                verificar = true;
                break; //Salimos del bucle si encontró coincidencias
            }
        }


        //Verificamos credenciales
        if (verificar == true)
        {
            Navigation.PushAsync(new registro(usuario));
            entryUsuario.Text = "";
            entryContrasena.Text = "";
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "Cancelar");
        }

    }
    public void LimpiarCampos()
    {
        entryUsuario.Text = string.Empty;
        entryContrasena.Text = string.Empty;
    }
    private void btnIniciar_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new acercaDe());
    }
}