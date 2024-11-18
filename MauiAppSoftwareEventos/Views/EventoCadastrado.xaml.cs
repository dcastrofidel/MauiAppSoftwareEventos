namespace MauiAppSoftwareEventos.Views;

public partial class EventoCadastrado : ContentPage
{
	public EventoCadastrado()
	{
		InitializeComponent();
	}

    private void btn_voltar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops!", ex.Message, "Ok");
        }   
    }
}