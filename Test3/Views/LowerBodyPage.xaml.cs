namespace Test3.Views;

public partial class LowerBodyPage : ContentPage
{
	public LowerBodyPage()
	{
		InitializeComponent();
	}

    private async void OnQuadsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsLowerBody.QuadsPage());
    }
    private async void OnHamstringsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsLowerBody.HamstringsPage());
    }
    private async void OnGlutesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsLowerBody.GlutesPage());
    }
    private async void OnCalvesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsLowerBody.CalvesPage());
    }

    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.ExercisesPage());
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}