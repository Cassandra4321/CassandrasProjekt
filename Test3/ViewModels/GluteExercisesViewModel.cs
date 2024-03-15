using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.ViewModels
{
    internal class GluteExercisesViewModel
    {
        public List<Models.Exercise> Glutes { get; set; }

        public GluteExercisesViewModel()
        {
            Glutes = new List<Models.Exercise>();

            Glutes.Add(new Models.Exercise
            {
                Name = "Barbell sumo squat",
                Equipment = "Equipment: A barbell with weight plates.",
                Description = "How to do it: \nStand with feet wider than shoulder-width, toes angled out at 45 degrees. Place a barbell on your shoulders, gripping with hands slightly wider than shoulder-width. \nKeep chest up, engage core, and maintain a straight back. Bend at the knees and hips, descending into a squat with knees tracking in line with toes. \nLower until thighs are parallel to the ground or as low as flexibility allows. Pause briefly, then push through heels to return to the starting position. \nRepeat for desired repetitions, focusing on maintaining proper form throughout.",
                ImageSource = "sumosquat.gif"
            });

            Glutes.Add(new Models.Exercise
            {
                Name = "Romanian deadlift",
                Equipment = "Equipment: Barbell or dumbbells.",
                Description = "How to do it: \nStand with feet shoulder-width apart for stability. Hinge at the hips with a slight knee bend, pushing hips back while keeping a straight back and neutral spine. \nTake an overhand grip on the barbell with hands shoulder-width apart, keeping the bar close to your shins. \nLift the bar by straightening hips and knees, maintaining control to avoid jerking. Squeeze glutes at the top, exhale, then reverse the movement by pushing hips back and bending knees slightly. \nKeep the barbell in contact with your body throughout for proper engagement and reduced risk of injury.",
                ImageSource = "romaniandeadlift.gif"
            });

            Glutes.Add(new Models.Exercise
            {
                Name = "Bulgarian split squat",
                Equipment = "Equipment: A bench and dumbbells.",
                Description = "How to do it: \nStart in a split stance with one foot forward and the other on a bench, ensuring a comfortable distance. Hold a dumbbell in each hand by your sides. \nMaintain chest up, shoulders back, and engage your core for stability. Bend your knees, lowering your body with the majority of weight on the front leg. \nDescend until your front thigh is parallel to the ground, or as low as flexibility allows, while ensuring proper form and balance. \nPause briefly at the bottom, then push through the heel of your front foot to return to the starting position. \nRepeat for the desired reps, then switch legs and repeat the exercise with the opposite leg forward.",
                ImageSource = "bulgariansplitsquat.gif"
            });

            Glutes.Add(new Models.Exercise
            {
                Name = "Cable goblet squat",
                Equipment = "Equipment: A cable machine.",
                Description = "How to do it: \nAttach a low pulley cable machine with a rope. Stand facing the machine, feet shoulder-width apart, holding the rope at chest level. \nKeep chest up, shoulders back, and core engaged. Squat by bending hips and knees, ensuring knees track with toes. \nDescend until thighs are parallel or as low as flexibility allows. Pause, then squeeze glutes and push through heels to return to start.",
                ImageSource = "cablesquat.gif"
            });
            Glutes.Add(new Models.Exercise
            {
                Name = "Hip abduction",
                Equipment = "Equipment: Hip abduction machine.",
                Description = "How to do it: \nSit on the machine with your back against the backrest and place your feet on the foot pads. Position your thighs against the machine's pads, just above your knees. \nHold onto the handles or grips on the sides of the machine for stability. Engage your core and ensure your back is firmly against the backrest. \nPush your legs outward, away from each other, against the resistance of the machine. Keep the movement controlled, avoiding jerky or sudden motions. \nAt the fully abducted position, squeeze your glutes and outer thighs. In a controlled manner, bring your legs back to the starting position.",
                ImageSource = "hipabduction.gif"
            });
        }
    }
}
