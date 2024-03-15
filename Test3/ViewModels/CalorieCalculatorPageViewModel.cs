using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Test3.ViewModels
{
    public class CalorieCalculatorPageViewModel
    {

        public static async Task<List<Models.Calculator>> GetCalculatorAsync(string activity, int minutes)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://api.api-ninjas.com/");
                client.DefaultRequestHeaders.Add("X-Api-Key", "wg2yZlVbPW/aZSo7DDbgeA==kMYE8KVgJMLPhEud");

                HttpResponseMessage response = await client.GetAsync($"v1/caloriesburned?activity={activity}");

                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    var calculators = JsonSerializer.Deserialize<List<Models.Calculator>>(responseString);

                    foreach (var calculator in calculators)
                    {
                        calculator.duration_minutes = minutes;
                        calculator.total_calories = (int)Math.Round((double)(calculator.calories_per_hour * minutes) / 60);
                    }
                    return calculators;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
                
            }
            return null;
        }
    }
}