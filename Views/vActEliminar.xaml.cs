using jtoapantaS6.Models;

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

		}
		catch (Exception)
		{

			throw;
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