using System.Xml.Serialization;
using Cara_Coroa.Moedas;

namespace Cara_Coroa.Views;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
	}

	private void SortedCoinButton_Clicked(object sender, EventArgs e)
	{
		string ladoSelecionado = SidesCoin.SelectedItem.ToString();

		Coins coin = new Coins();

		string resultado = coin.Jogar(ladoSelecionado);

		LabelResult.Text = resultado;
	}
}