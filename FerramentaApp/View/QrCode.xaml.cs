using Microsoft.Maui.Controls;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace FerramentaApp.View;

public partial class QrCode : ContentPage
{
    public QrCode()
	{
		InitializeComponent();
    }

    public void OnClickGerarLink(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(EntryTitulo.Text) || string.IsNullOrEmpty(EntryLink.Text))
            {
                LblDesc.Text = "Título ou link não inserido";
            }
            else
            {
                QrDescricao.Value = EntryLink.Text;
                StkQr.IsVisible = true;
                LblDesc.Text = EntryTitulo.Text;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
}