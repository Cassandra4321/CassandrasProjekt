namespace Test3.Views.ViewsUpperBody;

public partial class ShouldersPage : ContentPage
{

    public ShouldersPage()
    {
        InitializeComponent();
        BindingContext = new ViewModels.ShoulderExercisesViewModel();
    }

    private async void OnListViewExerciseSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var exercise = ((ListView)sender).SelectedItem as Models.Exercise;
        if (exercise != null)
        {
            var page = new ShouldersDetailsPage();
            page.BindingContext = exercise;
            await Navigation.PushAsync(page);
        }
    }

    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.UpperBodyPage());
    }
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}