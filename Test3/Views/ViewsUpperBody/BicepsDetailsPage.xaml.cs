namespace Test3.Views.ViewsUpperBody;

public partial class BicepsDetailsPage : ContentPage
{
	public BicepsDetailsPage()
	{
		InitializeComponent();
	}
    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsUpperBody.BicepsPage());
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}