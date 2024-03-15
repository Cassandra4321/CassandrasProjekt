namespace Test3.Views.ViewsUpperBody;

public partial class BackDetailsPage : ContentPage
{
	public BackDetailsPage()
	{
		InitializeComponent();
	}
    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsUpperBody.BackPage());
    }
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}