using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.ViewModels
{
    internal class ChestExercisesViewModel
    {
        public List<Models.Exercise> Chest { get; set; }

        public ChestExercisesViewModel()
        {
            Chest = new List<Models.Exercise>();

            Chest.Add(new Models.Exercise
            {
                Name = "Barebell bench press",
                Equipment = "Equipment: Bench press setup.",
                Description = "How to do it: \nSet up bench securely. Feet flat, back flat, shoulder blades together. \nGrip bar, palms away, thumbs around, shoulder-width apart. Engage core by bracing, preventing spine movement. \nLower bar with controlled descent, elbows at 45-degree angle. Press explosively, drive feet for stability. \nKeep shoulders down, breathe deeply, exhale on the press. Maintain elbows close, prevent flaring.",
                ImageSource = "benchpress.gif"
            });
            Chest.Add(new Models.Exercise
            {
                Name = "Chest fly",
                Equipment = "Equipment: Dumbbells and a bench.",
                Description = "How to do it: \nLie on a flat bench, hold dumbbells above chest with a slight bend in elbows. Lower arms out to sides, maintaining slight bend. Keep control, feeling stretch in chest. \nBring arms back up, squeezing chest muscles. Maintain a slight bend in elbows throughout.",
                ImageSource = "chestfly.gif"
            });
            Chest.Add(new Models.Exercise
            {
                Name = "Cable crossover",
                Equipment = "Equipment: A cable machine.",
                Description = "How to do it: \nStand between cable machines, set handles at chest height. Grab handles, step forward with one foot. Keep slight bend in elbows, initiate with chest, cross hands in front. \nFeel chest contraction, return arms with control. Maintain stable stance throughout the movement.",
                ImageSource = "cablecrossover.gif"
            });
            Chest.Add(new Models.Exercise
            {
                Name = "Upper cable crossover",
                Equipment = "Equipment: A cable machine.",
                Description = "How to do it: \nTake one handle in each hand. Take a step forward with one foot, keeping a slight bend in the knees. \nKeeping your elbows slightly bent and your chest up, slowly cross your arms up and in front of your head. \nSqueeze your chest muscles at the top of the movement and slowly spread the arms apart. Slowly lower the handles back to the starting position.",
                ImageSource = "uppercablecrossover.gif"
            });
        }
    }
}
