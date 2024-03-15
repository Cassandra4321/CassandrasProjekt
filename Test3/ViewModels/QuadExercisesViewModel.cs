using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.ViewModels
{
    internal class QuadExercisesViewModel
    {
        public List<Models.Exercise> Quads { get; set; }

        public QuadExercisesViewModel()
        {
            Quads = new List<Models.Exercise>();

            Quads.Add(new Models.Exercise
            {
                Name = "Walking lunges",
                Equipment = "Equipment: Dumbbells.",
                Description = "How to do it: \nStand straight with a dumbbell in each hand. Take a step forward, ensuring both knees form 90-degree angles. \nLower your body into a lunge, maintaining proper posture. Push through the front heel to stand up, bringing the back foot forward. \nContinue walking lunges, alternating legs with each step.",
                ImageSource = "walkinglunges.gif"
            });
            Quads.Add(new Models.Exercise
            {
                Name = "Barbell squat",
                Equipment = "Equipment: Barbell and weight plates",
                Description = "How to do it: \nStand with feet shoulder-width apart, barbell on upper back. Grasp the bar with hands slightly wider than shoulder-width, elbows pointing down. \nTake a deep breath, brace core, squat by pushing hips back and bending knees. \nKeep chest up, back straight, and heels planted on the ground. \nLower until thighs are parallel or comfortably low while maintaining form. Drive through heels to stand up, exhaling.",
                ImageSource = "barbellsquat.gif"
            });
            Quads.Add(new Models.Exercise
            {
                Name = "Leg press",
                Equipment = "Equipment: Leg press machine",
                Description = "How to do it: \nSit with back against the backrest, feet flat on the platform, knees bent at 90 degrees. \nPosition feet hip-width apart on the platform, toes forward or slightly outward, ensuring a secure footing. \nGrip handles for stability, take a deep breath, and engage core muscles. \nPush against the platform, extending legs while keeping back against the seat. Avoid locking knees at the top. \nBend knees, slowly lower the weight, allowing knees to reach a 90-degree angle without letting the weight touch down completely. \n",
                ImageSource = "legpress.gif"
            });
            Quads.Add(new Models.Exercise
            {
                Name = "Leg extension",
                Equipment = "Equipment: Leg extension machine",
                Description = "How to do it: \nSit with back against the backrest, feet firmly on the footpad, knees aligned with the machine's pivot point. \nPosition legs under the padded lever or roller, against the front of your ankles. Grasp handles for stability, maintain good posture with a relaxed upper body. \nExhale, contract quadriceps, and extend legs by pushing feet forward. Continue until legs are fully extended, avoiding locking knees at the top. \nPause briefly, focusing on squeezing quadriceps. \nInhale, slowly lower the weight by bending knees, controlling the descent. Repeat for desired repetitions, maintaining control throughout.",
                ImageSource = "legextension.gif"
            });
            Quads.Add(new Models.Exercise
            {
                Name = "Pistol squat",
                Equipment = "Equipment: No equipment needed.",
                Description = "How to do it: \nStand on one leg, keeping your chest up and shoulders back. Extend the other leg straight in front of you, parallel to the ground. \nLower your body by bending the knee of the supporting leg. Keep your back straight and chest up as you lower yourself down. \nAim to lower your body until your raised leg is parallel to the ground or as low as flexibility allows. Push through the heel of the supporting leg to return to the starting position.",
                ImageSource = "pistolsquat.gif"

            });
        }
    }
}
