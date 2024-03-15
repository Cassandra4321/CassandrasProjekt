namespace Test3.Views;

public partial class ExercisesPage : ContentPage
{
	public ExercisesPage()
	{
		InitializeComponent();
	}

    private async void OnUpperBodyClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UpperBodyPage());
    }

    private async void OnLowerBodyClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LowerBodyPage());
    }

    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}