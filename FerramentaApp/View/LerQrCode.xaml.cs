using System.Windows.Input;
using ZXing;
using ZXing.Net.Maui;

namespace FerramentaApp.View;

public partial class LerQrCode : ContentPage
{
    Uri uri;
    public LerQrCode()
	{
		InitializeComponent();
    }

    private void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        Dispatcher.Dispatch(() =>
        {
            DescQr.Text = $"{e.Results[0].Value}{e.Results[0].Format}";
            FPopup.IsVisible = true;
        });
    }

    private async void OnClickAbrir(object sender, EventArgs e)
    {
        try
        {
            uri = new Uri(DescQr.Text);
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception)
        {
            await DisplayAlert("Atenção", "Link indisponível", "OK");
        }
    }
}