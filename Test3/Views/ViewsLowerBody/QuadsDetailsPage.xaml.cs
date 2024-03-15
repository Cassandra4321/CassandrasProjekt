namespace Test3.Views.ViewsLowerBody;

public partial class QuadsDetailsPage : ContentPage
{
	public QuadsDetailsPage()
	{
		InitializeComponent();
	}

    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsLowerBody.QuadsPage());
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}