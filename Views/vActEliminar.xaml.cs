using jtoapantaS6.Models;
using System.Net;

namespace jtoapantaS6.Views;

public partial class vActEliminar : ContentPage
{
	public vActEliminar(Estudiante datos)
	{
		InitializeComponent();
		txtCodigo.Text= datos.codigo.ToString();
		txtNombre.Text = datos.nombre;
		txtApellido.Text = datos.apellido;
		txtEdad.Text= datos.edad.ToString();
	}

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            parametros.Add("nombre", txtNombre.Text);
            parametros.Add("apellido", txtApellido.Text);
            parametros.Add("edad", txtEdad.Text);

            cliente.UploadValues("http://192.168.56.1/semana6/estudiantews.php", "PUT", parametros);
            Navigation.PushAsync(new vEstudiante());
        }
        catch (Exception ex)
        {

            DisplayAlert("Alerta", ex.Message, "Ok");
        }
    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {
		try
		{

		}
		catch (Exception)
		{

			throw;
		}
    }
}