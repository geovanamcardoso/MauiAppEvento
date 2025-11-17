namespace MauiAppEvento.Views;

public partial class TelaInicial : ContentPage
{
	public TelaInicial()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        {
            try
            {   //Método que me permite navegar para a próxima página
                Navigation.PushAsync(new CadastroEvento());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}