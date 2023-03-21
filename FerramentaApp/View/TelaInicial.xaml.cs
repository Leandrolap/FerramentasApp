namespace FerramentaApp.View;

public partial class TelaInicial : ContentPage
{
	public TelaInicial()
	{
		InitializeComponent();
	}

    private async void OnClickCriarQr(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QrCode());
        //Navigation.PopAsync = new NavigationPage QrCode());
    }

    private async void OnClickLerQr(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LerQrCode());
    }

    private async void OnClickELink(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EncurtaLink());
    }

    private async void OnClickSobre(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}