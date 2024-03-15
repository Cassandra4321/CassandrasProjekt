using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.ViewModels
{
    internal class HamstringExercisesViewModel
    {
        public List<Models.Exercise> Hamstrings { get; set; }

        public HamstringExercisesViewModel()
        {
            Hamstrings = new List<Models.Exercise>();

            Hamstrings.Add(new Models.Exercise
            {
                Name = "Lying leg curl",
                Equipment = "Equipment: Lying leg curl machine.",
                Description = "How to do it: \nLie face down on the leg curl machine. Place ankles under the padded lever. \nGrasp handles for stability. Exhale, lift lever by flexing knees. Squeeze hamstrings at the top. \nInhale, lower the lever to starting position. Repeat for desired reps, maintaining control. Adjust weight as needed.",
                ImageSource = "lyinglegcurl.gif"
            });

            Hamstrings.Add(new Models.Exercise
            {
                Name = "Seated leg curl",
                Equipment = "Equipment: Seated leg curl machine.",
                Description = "How to do it: \nSit with back against the backrest, legs extended, knees aligned with the machine's pivot. \nPlace lower legs under the padded lever, knees slightly off the seat edge. Grasp handles for stability, maintain good posture. \nBend knees, bringing heels toward buttocks with controlled movements. Continue until legs are fully bent, machine pad close to glutes. \nPause, squeezing hamstrings. Inhale, slowly lower weight by extending legs to starting position. \nRepeat for desired reps, ensuring controlled movements. Adjust weight as needed.",
                ImageSource = "seatedlegcurl.gif"
            });

            Hamstrings.Add(new Models.Exercise
            {
                Name = "Dumbbell good morning",
                Equipment = "Equipment: A dumbbell.",
                Description = "How to do it: \nStand with feet shoulder-width apart. Hold one dumbbell in both hands or one in each hand, based on preference. \nKeep back straight and chest up. Engage core muscles for spine stabilization. \nHinge at your hips, bending forward with a straight back. Hips move backward as upper body moves forward. \nLower torso until you feel a hamstring stretch, stopping when back is parallel to the ground or slightly above it. Maintain the natural arch in your lower back. \nDrive hips forward to return to the upright position. Squeeze glutes at the top to engage hip extensors.",
                ImageSource = "goodmornings.gif"
            });

            Hamstrings.Add(new Models.Exercise
            {
                Name = "Straight leg deadlift",
                Equipment = "Equipment: Dumbbells or a barbell.",
                Description = "How to do it: \nStand with feet hip-width apart, holding a dumbbell in each hand with a neutral grip (palms facing your body). Keep your back straight, chest up, and shoulders back. \nHinge at your hips while maintaining a slight bend in your knees. Lower the dumbbells towards the ground, keeping them close to your legs. \nLower until you feel a stretch in your hamstrings, maintaining a straight back. Engage your hamstrings and glutes to stand back up, pushing through your heels. \nStand upright with the dumbbells hanging in front of your body. Repeat for the desired number of repetitions, focusing on the controlled movement. \nWith a barbell: the technique is similar, but instead of holding dumbbells, hold a barbell with a shoulder-width or slightly wider grip.",
                ImageSource = "straightlegdeadlift.gif"
            });
        }
    }
}
