namespace Test3.Views.ViewsLowerBody;

public partial class GlutesDetailsPage : ContentPage
{
	public GlutesDetailsPage()
	{
		InitializeComponent();
	}
    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsLowerBody.GlutesPage());
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}