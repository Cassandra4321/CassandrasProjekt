namespace Test3.Views.ViewsLowerBody;

public partial class CalvesDetailsPage : ContentPage
{
	public CalvesDetailsPage()
	{
		InitializeComponent();
	}
    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsLowerBody.CalvesPage());
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}