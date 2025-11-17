namespace MauiAppEvento.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    public async void OnBtnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}