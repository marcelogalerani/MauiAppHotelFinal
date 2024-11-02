namespace MauiAppHotel;
public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}
    private async void bt_voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}