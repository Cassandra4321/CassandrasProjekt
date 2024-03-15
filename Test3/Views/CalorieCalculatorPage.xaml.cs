namespace Test3.Views;

public partial class CalorieCalculatorPage : ContentPage
{
    public CalorieCalculatorPage()
    {
        InitializeComponent();
        BindingContext = new ViewModels.CalorieCalculatorPageViewModel();
    }

    private async void OnExerciseClicked(object sender, EventArgs e)
    {
        var selectedExercise = (sender as Button).Text;   
        await Navigation.PushAsync(new Views.CalorieCalculatorPage2(selectedExercise));
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