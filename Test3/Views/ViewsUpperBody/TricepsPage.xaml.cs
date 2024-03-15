namespace Test3.Views.ViewsUpperBody;

public partial class TricepsPage : ContentPage
{
	public TricepsPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.TricepExercisesViewModel();
    }

    private async void OnListViewExerciseSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var exercise = ((ListView)sender).SelectedItem as Models.Exercise;
        if (exercise != null)
        {
            var page = new TricepsDetailsPage();
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