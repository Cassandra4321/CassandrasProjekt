namespace Test3.Views;

public partial class CalorieCalculatorPage2 : ContentPage
{
    public string selectedExercise;

    public CalorieCalculatorPage2(string exercise)
    {
        InitializeComponent();
        selectedExercise = exercise;
    }

    private async void OnCalculateClicked(object sender, EventArgs e)
    {
        try
        {
            if (int.TryParse(duration_minutes.Text, out int minutes))
            {
                var result = await ViewModels.CalorieCalculatorPageViewModel.GetCalculatorAsync(selectedExercise, minutes);

                resultListView.ItemsSource = result;

                errorLabel.Text = "";
            }
            else
            {
                errorLabel.Text = "Invalid input. Enter a valid number of minutes.";
            }
        }
        catch (Exception ex)
        {
            errorLabel.Text = $"An error occurred: {ex.Message}";
        }
    }

    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.CalorieCalculatorPage());
    }

    private async void OnHomeClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}