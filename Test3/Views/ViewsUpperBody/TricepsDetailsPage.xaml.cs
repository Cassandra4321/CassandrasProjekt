namespace Test3.Views.ViewsUpperBody;

public partial class TricepsDetailsPage : ContentPage
{
	public TricepsDetailsPage()
	{
		InitializeComponent();
	}
    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsUpperBody.TricepsPage());
    }
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}