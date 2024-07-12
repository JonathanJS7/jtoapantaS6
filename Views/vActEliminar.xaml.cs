using jtoapantaS6.Models;
using System.Net;
using System.Text;

namespace jtoapantaS6.Views;

public partial class vActEliminar : ContentPage
{

    private static readonly HttpClient client = new HttpClient();

    public vActEliminar(Estudiante datos)
    {
        InitializeComponent();
        txtCodigo.Text = datos.codigo.ToString();
        txtNombre.Text = datos.nombre;
        txtApellido.Text = datos.apellido;
        txtEdad.Text = datos.edad.ToString();
    }

    private async void btnActualizar_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            parametros.Add("codigo", txtCodigo.Text);
            parametros.Add("nombre", txtNombre.Text);
            parametros.Add("apellido", txtApellido.Text);
            parametros.Add("edad", txtEdad.Text);

            string url = "http://192.168.56.1/semana6/estudiantews.php";
            string query = $"?codigo={txtCodigo.Text}&nombre={txtNombre.Text}&apellido={txtApellido.Text}&edad={txtEdad.Text}";

            cliente.UploadValues(url + query, "PUT", parametros);
            await DisplayAlert("Éxito", "Estudiante actualizado correctamente", "Ok");
            await Navigation.PushAsync(new vEstudiante());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alerta", ex.Message, "Ok");
        }
    }

    private async void btnEliminar_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient cliente = new WebClient();
            string url = "http://192.168.56.1/semana6/estudiantews.php";
            string query = $"?codigo={txtCodigo.Text}";

            cliente.UploadValues(url + query, "DELETE", new System.Collections.Specialized.NameValueCollection());
            await DisplayAlert("Éxito", "Estudiante eliminado correctamente", "Ok");
            await Navigation.PushAsync(new vEstudiante());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Alerta", ex.Message, "Ok");
        }
    }
}
