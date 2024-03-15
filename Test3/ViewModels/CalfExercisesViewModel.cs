using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3.ViewModels
{
    internal class CalfExercisesViewModel
    {
        public List<Models.Exercise> Calves { get; set; }

        public CalfExercisesViewModel()
        {
            Calves = new List<Models.Exercise>();

            Calves.Add(new Models.Exercise
            {
                Name = "Calf press",
                Equipment = "Equipment: Leg press machine.",
                Description = "How to do it: \nSit on a leg press machine with your back against the backrest and your feet flat on the footplate. Position your feet at hip-width apart or slightly wider on the footplate. \nPerform a regular leg press by pushing the footplate away from you using your legs. Once your legs are fully extended, transition into a calf raise by pushing through the balls of your feet. \nLift your heels as high as you can, emphasizing the contraction of your calf muscles. Lower your heels back down, keeping control of the movement. \nBend your knees to return to the starting position.",
                ImageSource = "calfraises.gif"
            });

            Calves.Add(new Models.Exercise
            {
                Name = "Single leg calf raises",
                Equipment = "Equipment: No equipment requiered.",
                Description = "How to do it: \nStand upright with your feet hip-width apart, near a wall or any stable surface for support. Lift one foot off the ground, keeping the knee slightly bent for balance. \nHold onto the wall or a sturdy surface for support if needed. Rise onto the ball of your standing foot by pushing through your toes. \nLift your heel as high as you can, contracting your calf muscles at the top. Lower your heel back down, controlling the descent. \nPerform the desired number of repetitions on one leg before switching to the other.",
                ImageSource = "singlelegcalfraises.gif"
            });
        }
    }
}
