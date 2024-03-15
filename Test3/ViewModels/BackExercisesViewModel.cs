namespace Test3.ViewModels
{
    internal class BackExercisesViewModel
    {
        public List<Models.Exercise> Back { get; set; }

        public BackExercisesViewModel()
        {
            Back = new List<Models.Exercise>();

            Back.Add(new Models.Exercise
            {
                Name = "Lat pulldown",
                Equipment = "Equipment: Lat pulldown station/cable machine.",
                Description = "How to do it: \n1. Set yourself up with your legs under the pad and hands grasping the bar attachment slightly wider than shoulder-width with a pronated (palms facing away) grip. \n2. With the core tight and the torso upright — or even a little arched — pull the bar down to your chin. \n3. Slowly resist the weight as you return to the starting position.",
                ImageSource = "latpulldown.gif"
            });

            Back.Add(new Models.Exercise
            {
                Name = "Dumbbell row",
                Equipment = "Equipment: Dumbbells.",
                Description = "How to do it: \n1. Stand next to a bench so that it’s parallel to you. \n2. Place the same-side hand and knee on it, and firmly plant your other foot onto the floor. \n3. Reach down with your free hand and grab a dumbbell. \n4. Keep your back flat and your head in a neutral position. \n5. Row the dumbbell to your side until your elbow passes your torso.",
                ImageSource = "dumbbellrow.gif"
            });

            Back.Add(new Models.Exercise
            {
                Name = "Face pulls",
                Equipment = "Equipment: Cable machine and a rope attachment.",
                Description = "How to do it: \n1. Clip a rope attachment to a cable pulley set to the highest setting. \n2. Grab the rope with both hands, palms facing each other. \n3. Take a few steps back so there’s tension in the rope. \n4. Raise your hands so the rope is level with your face. \n5. Simultaneously pull the rope toward your face and flare your elbows out and back. The movement should look like a front double biceps pose.",
                ImageSource = "facepull.gif"
            });

            Back.Add(new Models.Exercise
            {
                Name = "Deadlift",
                Equipment = "Equipment: Barebell and weight plates.",
                Description = "How to do it: \n1. Stand in front of a loaded barbell with your feet shoulder-width apart, hips back, and back flat. \n2. The knees should be bent slightly to allow you to grip the bar tightly, slightly wider than shoulder-width. \n3. Keeping your back flat and chest up, tighten the back muscles, and straighten your arms as you load the pull. \n4. With everything locked, aggressively push your legs into the floor as you simultaneously pull your chest and shoulders upwards, lifting the bar to the hip.",
                ImageSource = "deadlift.gif"
            }); 

            Back.Add(new Models.Exercise
            {
                Name = "Pull up",
                Equipment = "Equipment: A stable pull up bar.",
                Description = "How to do it: \n1. Assume an overhead grip on the bar, slightly wider than shoulder-width. \n2. With the arms relaxed and shoulders elevated up to the ears, contract the core and upper back as you initiate the pull-up. \n3. Aim to pull your chin to or above the bar level, driving your shoulders away from your ears.",
                ImageSource = "pullup.gif"
            });

            Back.Add(new Models.Exercise
            {
                Name = "Back extension",
                Equipment = "Equipment: Back extension bench/hyperextension bench.",
                Description = "How to do it: \n1. Place your things against the pads of a back extension machine, and ensure that your Achilles tendon is right under the ankle pad. \n2. Cross your arms. Slowly hinge forward until your body forms a 90-degree angle. \n3. Contract your glutes and hamstrings to come back to the starting position.",
                ImageSource = "backextension.gif"
            });
        }
    }
}
