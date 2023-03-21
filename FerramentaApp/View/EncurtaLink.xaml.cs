namespace FerramentaApp.View;

public partial class EncurtaLink : ContentPage
{
	public EncurtaLink()
	{
		InitializeComponent();

        this.BindingContext = this;
        this.IsBusy = false;

        WebEncurta();
    }

    public async void WebEncurta()
	{
        this.IsBusy = true;
        // aqui ficaria o seu código
        // para fazer o login 
        await DandoUmTempo(2000);
        WebLink.Source = "https://short.u2b.eu/";
        ActProgresso.IsVisible = false;
    }

    async Task DandoUmTempo(int valor)
    {
        await Task.Delay(valor);
    }
}