using MauiAppSoftwareEventos.Models;

namespace MauiAppSoftwareEventos.Views;

public partial class ContratacaoDeEventos : ContentPage
{
	public ContratacaoDeEventos()
	{
		InitializeComponent();

        dtpck_inicio.MinimumDate = DateTime.Now;
        dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
        dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(6);
    }

    private async void btn_avancar_Clicked_1(object sender, EventArgs e)
    {

        try
        {
            Evento E = new Evento
            {
                NomeDoEvento = nome_evento.Text,
                DataInicio = dtpck_inicio.Date,
                DataTermino = dtpck_termino.Date,
                QntParticipantes = Convert.ToInt32(qnt_Participantes.Text),
                LocalEvento = local_evento.Text,
                CustoParticipante = Convert.ToInt32(custo_participante.Text),
            };

            await Navigation.PushAsync(new Views.EventoCadastrado()
            {
                BindingContext = E
            });
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops!", ex.Message, "Ok");
        }

    }
}