using Test3.Views;

namespace Test3
{
    // Den här applikationen använder inte singleton, då jag inte direkt har något som behöver vara unikt på det sättet, t.ex. databas, login. 
    // Jag tänker att singleton säkert kan användas för API anrop, men det känns lite onödigt och jag tycker det fungerar bra med en enkel metod för det. 
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnExercisesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExercisesPage());
        }

        private async void OnCalorieCalculatorClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.CalorieCalculatorPage());
        }
    }

}
