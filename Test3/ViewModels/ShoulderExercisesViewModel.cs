using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.ViewModels
{
    internal class ShoulderExercisesViewModel
    {
        public List<Models.Exercise> Shoulders { get; set; }

        public ShoulderExercisesViewModel()
        {
            Shoulders = new List<Models.Exercise>();

            Shoulders.Add(new Models.Exercise
            {
                Name = "Shoulder press", 
                Equipment = "Equipment: Dumbbells and a bench.",
                Description = "How to do it: \nSit upright on an incline bench. Lean the dumbbells so they are sitting more or less on your front delts. \nKeep your shoulders away from your ears. Sit tall. Brace your core. \nPress both dumbbells overhead until your elbows lock out. Carefully lower the dumbbells below shoulder height. Reset and repeat.",
                ImageSource = "shoulderpress.gif"
            });
            Shoulders.Add(new Models.Exercise
            {
                Name = "Bent over lateral raises",
                Equipment = "Equipment: Dumbbells.",
                Description = "How to do it: Bend forward from the hips and keep your lower back straight while holding dumbbells. \n Keep your elbows slightly bent. Exhale and raise your arms out to the sides. Hold for a brief second and then slowly lower to the starting position.",
                ImageSource = "bentoverlateralraises.gif"
            });
            Shoulders.Add(new Models.Exercise
            {
                Name = "Rear delt flies",
                Equipment = "Equipment: Cable machine.",
                Description = "How to do it: Position the cable arms so that they are at your shoulder height. \nGrab the left cable with your right hand and overlap your arms by grabbing the right cable with your left hand. \nExhale and while keeping your arms straight pull your shoulders out to the sides. Hold briefly and then slowly return to the starting position.",
                ImageSource = "reardeltflies.gif"
            });
            Shoulders.Add(new Models.Exercise
            {
                Name = "Upright row",
                Equipment = "Equipment: EZ bar.",
                Description = "How to do it: Begin my grabbing the barbell with your palms facing your body. Place your hands fairly close together– closer than shoulder width. \nExhale and raise your elbows and shoulders up to about 90 degrees. Hold just for a brief second and then slowly lower to the starting position.",
                ImageSource = "uprightrow.gif"
            });
        }
    }
}
