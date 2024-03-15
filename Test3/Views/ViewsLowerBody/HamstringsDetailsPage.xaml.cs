namespace Test3.Views.ViewsLowerBody;

public partial class HamstringsDetailsPage : ContentPage
{
	public HamstringsDetailsPage()
	{
		InitializeComponent();
	}
    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsLowerBody.HamstringsPage());
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}