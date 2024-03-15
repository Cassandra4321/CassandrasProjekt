namespace Test3.Views;

public partial class UpperBodyPage : ContentPage
{
    public UpperBodyPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsUpperBody.BackPage());
    }

    private async void OnShouldersClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsUpperBody.ShouldersPage());
    }

    private async void OnBicepsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsUpperBody.BicepsPage());
    }

    private async void OnTricepsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsUpperBody.TricepsPage());
    }

    private async void OnChestClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewsUpperBody.ChestPage());
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.ExercisesPage());
    }
}