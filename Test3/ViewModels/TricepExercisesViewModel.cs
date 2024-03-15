using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.ViewModels
{
    internal class TricepExercisesViewModel
    {
        public List<Models.Exercise> Triceps { get; set; }

        public TricepExercisesViewModel()
        {
            Triceps = new List<Models.Exercise>();

            Triceps.Add(new Models.Exercise
            {
                Name = "Tricep push-down",
                Equipment = "Equipment: Cable machine and a straight bar.",
                Description = "How to do it: \nGrab the straight bar or rope handle with an overhand grip (palms facing down). \nPosition your feet shoulder-width apart, and slightly bend your knees for stability. Keep your back straight, and engage your core throughout the exercise. \nStart with your elbows bent at your sides and your forearms parallel to the ground, pointing down towards the floor. \nEngage your triceps and push the bar or handle down towards your thighs, fully extending your arms. \nSlowly and in a controlled manner, let the bar or handle return to the starting position, keeping tension on the triceps.",
                ImageSource = "pushdown.gif"
            });
            Triceps.Add(new Models.Exercise
            {
                Name = "Tricep dips",
                Equipment = "Equipment: Tricep dip machine.",
                Description = "How to do it: \nInhale and bend your elbows to slowly lower your body towards the floor. Lean your body forward very slightly as you lower. \nHold for a brief second at the bottom and then exhale and straighten your elbows to go back to the starting position. \nUse a comfortable range of motion. You don’t need to lower as low as possible. Bend your elbows and shoulders to about 90 degrees.",
                ImageSource = "tricepdips.gif"
            });
            Triceps.Add(new Models.Exercise
            {
                Name = "Lying tricep extension/skull crusher",
                Equipment = "Equipment: A bench and a dumbbell.",
                Description = "How to do it: \nLie on a bench with one dumbbell in your hand. Use your opposite hand as a cue for the correct position for your shoulder and elbow. \nHold the dumbbell in your hand so that it is pointing towards the ceiling. \nInhale as you lower the dumbbell towards the side of your head. Hold for a brief second and then exhale and return to the starting position. \nKeep your shoulders steady, only your elbow should be moving during this exercise.",
                ImageSource = "skullcrusher.gif"
            });
            Triceps.Add(new Models.Exercise
            {
                Name = "Overhead tricep extension",
                Equipment = "Equipment: Cable machine.",
                Description = "How to do it: \nYou can stand shoulder-width apart, either with your feet parrallell or with one foot in front of the other. \nLean forward slightly, from your hips. Your back should remain straight, and make sure to keep a slight tension in your core throughout the entire movement. \nStand with your back against the pulley, with a slight forward lean, and hold the rope behind your head and your upper arms next to your ears. \nStraighten your elbows until your arms are fully extended. Reverse the motion by bending your arms again.",
                ImageSource = "overheadtricep.gif"
            });
        }
    }
}
