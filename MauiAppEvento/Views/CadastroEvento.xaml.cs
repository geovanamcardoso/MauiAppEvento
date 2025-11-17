using MauiAppEvento.Models;

namespace MauiAppEvento.Views;

public partial class CadastroEvento : ContentPage
{
    App PropriedadesApp;
    public CadastroEvento()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        dtpck_inicio.MinimumDate = DateTime.Today;
        dtpck_inicio.MaximumDate = DateTime.Today.AddMonths(6);

        dtpck_termino.MinimumDate = dtpck_inicio.MinimumDate;
        dtpck_termino.MaximumDate = dtpck_inicio.MaximumDate;
    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Evento evento = new Evento
            {
                nomeEvento = txt_nome.Text,
                localEvento = txt_local.Text,
                QntPartici = Convert.ToInt32(stp_partici.Value),
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
                valorPartici = Convert.ToDouble(txt_preco.Text)

            };

           
            await Navigation.PushAsync(new EventoCriado()
            {
                BindingContext = evento
            });

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DateTime inicio = e.NewDate;

        dtpck_termino.MinimumDate = inicio;
        dtpck_termino.MaximumDate = inicio.AddMonths(6);

        if (dtpck_termino.Date < dtpck_termino.MinimumDate)
            dtpck_termino.Date = dtpck_termino.MinimumDate;
    }

    private async void OnBtnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Sobre());
    }
}
