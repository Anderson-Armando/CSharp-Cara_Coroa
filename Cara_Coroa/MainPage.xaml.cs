namespace Cara_Coroa;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
}
/*
    private void SortedCoinButton_Clicked(object sender, EventArgs e)
    {
		Random random = new Random();

        int DescCoin = random.Next(1, 3);

		if (DescCoin == 1)
		{
			ImageCoin.Source = "cara.png";

			int selectSides = SidesCoin.SelectedIndex;

            if (selectSides == 1)
			{
				LabelResult.Text = "Você Ganhou!";
			}
			else
			{
				LabelResult.Text = "Você Perdeu! ;-;";
			}
		}
		else
		{
			ImageCoin.Source = "coroa.png";

			int selectSides = SidesCoin.SelectedIndex;

            if (selectSides == 0)
            {
                LabelResult.Text = "Você Ganhou!";
            }
            else
            {
                LabelResult.Text = "Você Perdeu! ;-;";
            }
        }
    }
}

*/