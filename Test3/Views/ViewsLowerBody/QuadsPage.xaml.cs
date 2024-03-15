namespace Test3.Views.ViewsLowerBody;

public partial class QuadsPage : ContentPage
{
	public QuadsPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.QuadExercisesViewModel();
    }
    private async void OnListViewExerciseSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var exercise = ((ListView)sender).SelectedItem as Models.Exercise;
        if (exercise != null)
        {
            var page = new QuadsDetailsPage();
            page.BindingContext = exercise;
            await Navigation.PushAsync(page);
        }
    }
    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.LowerBodyPage());
    }
    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}