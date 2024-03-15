namespace Test3.Views.ViewsUpperBody;

public partial class ChestDetailsPage : ContentPage
{
	public ChestDetailsPage()
	{
		InitializeComponent();
	}
    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsUpperBody.ChestPage());
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}