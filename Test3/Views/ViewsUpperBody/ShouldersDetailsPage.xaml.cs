namespace Test3.Views.ViewsUpperBody;

public partial class ShouldersDetailsPage : ContentPage
{
	public ShouldersDetailsPage()
	{
		InitializeComponent();
	}

    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsUpperBody.ShouldersPage());
    }
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}