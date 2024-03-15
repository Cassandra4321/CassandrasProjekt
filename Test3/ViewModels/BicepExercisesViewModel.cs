using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.ViewModels
{
    internal class BicepExercisesViewModel
    {
        public List<Models.Exercise> Biceps { get; set; }

        public BicepExercisesViewModel()
        {
            Biceps = new List<Models.Exercise>();

            Biceps.Add(new Models.Exercise
            {
                Name = "Dumbbell curl",
                Equipment = "Equipment: Dumbbells.",
                Description = "How to do it: \nStand up straight with your feet shoulder-width apart and your shoulders back. This will help to maintain proper alignment and engage your core. \nHold the dumbbells with a neutral grip (palms facing inward) and keep your wrists straight. \nKeep your elbows close to your sides throughout the movement. This will help to isolate the biceps and prevent swinging.\nStart by curling one dumbbell towards your shoulder, keeping your elbow close to your side. Lower the weight back down in a controlled manner, making sure to keep your elbow close to your side. \nOnce you have completed a full rep with one arm, switch to the other arm and repeat the exercise.",
                ImageSource = "dumbbellcurl.gif"
            });

            Biceps.Add(new Models.Exercise
            {
                Name = "Barbell curl",
                Equipment = "Equipment: A barbell and weight plates.",
                Description = "How to do it: \nStand up straight with your feet shoulder-width apart and grasp the barbell with an underhand grip, with your hands shoulder-width apart. \nKeep your elbows close to your sides and lift the barbell towards your chest, while contracting your biceps. \nSlowly lower the barbell back to the starting position, keeping your biceps engaged throughout the movement.",
                ImageSource = "barbellcurl.gif"
            });

            Biceps.Add(new Models.Exercise
            {
                Name = "Hammer curl",
                Equipment = "Equipment: Dumbbells.",
                Description = "How to do it: \nStand or sit with good posture: Hold a weight in each hand with a neutral grip, palms facing each other. Your arms should be fully extended and hanging by your sides. \nCurl one arm at a time: Exhale and curl one weight towards your shoulder, while keeping the other weight extended and hanging by your side. \nAt the top of the movement, squeeze your biceps to fully contract the muscles. \nInhale and slowly lower the weight back to the starting position, keeping your elbow close to your body and maintaining control throughout the movement. \nRepeat the movement with your other arm, curling the weight towards your shoulder while keeping the other arm extended and hanging by your side.",
                ImageSource = "hammercurl.gif"
            });


        }
    }
}
