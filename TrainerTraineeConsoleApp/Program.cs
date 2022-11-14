namespace TrainerTraineeConsoleApp
{
    internal class Program // UI
    {
        static void Main(string[] args)
        {
            Training training = new Training();
            Organization org = new Organization();
            org.Name = "Pratian";
            Trainer trainer = new Trainer();
            trainer.Name = "Venkat";

            trainer.Organization = org;
            training.Trainer = trainer;

            Trainee t1 = new Trainee();
            training.Trainees.Add(t1);
            Trainee t2 = new Trainee();
            training.Trainees.Add(t2);

            string orgName = training.GetTrainingOrgName();
            Console.WriteLine($"Training Org Name: {orgName}");

            Console.WriteLine($"Trainer Name: {training.GetTrainerName()}");

            int traineesCount = training.GetTraineesCount();

            Console.WriteLine($"Trainess count : {traineesCount}");

            Unit u1 = new Unit { Duration = 60 };
            Unit u2 = new Unit { Duration = 30 };
            Unit u3 = new Unit { Duration = 120 };
            Unit u4 = new Unit { Duration = 30 };

            Module m1 = new Module();
            m1.Units.Add(u1);
            m1.Units.Add(u2);

            Module m2 = new Module();
            //m2.Units.Add(u3);
            //m2.Units.Add(u4);

            Course c1 = new Course();
            c1.Modules.Add(m1);
            c1.Modules.Add(m2);

            training.Course = c1;
            Console.WriteLine($"Total Duration : {training.GetTrainingDuration()}");




        }
    }

    class Organization
    {
        public string Name { get; set; }
    }

    class Trainer
    {
        public string Name { get; set; }
        public Organization Organization { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public List<Training> Trainings { get; set; } = new List<Training>();

    }

    class Trainee
    {
        public Trainer Trainer { get; set; }
        public List<Training> Trainings { get; set; } = new List<Training>();
    }

    class Training
    {
        public Trainer Trainer { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public Course Course { get; set; }

        public string GetTrainingOrgName()
        {
            return Trainer.Organization.Name;
        }

        public int GetTraineesCount()
        {
            return Trainees.Count;
        }

        public int GetTrainingDuration()
        {
            int duration = 0;

            // TODO: calculate the total duration

            // iterate each moudle
            //for (int i = 0; i < Course.Modules.Count; i++)
            //{
            //    Module m = Course.Modules[i];
            //    // Iterate each unit
            //    for (int j = 0; j < m.Units.Count; j++)
            //    {
            //        Unit u = m.Units[j];
            //        duration += u.Duration;
            //    }
            //}

            foreach (Module module in Course.Modules)
            {
                foreach (Unit unit in module.Units)
                {
                    duration += unit.Duration;
                }
            }

            return duration;
        }

        public string GetTrainerName()
        {
            return Trainer.Name;
        }

        public string GetLongestDurationUnitName()
        {
            string unitName = null;
            //return unit
            return unitName;
        }

    }

    class Course
    {
        public List<Module> Modules { get; set; } = new List<Module>();
        public List<Training> Trainings { get; set; } = new List<Training>();

    }
    class Module
    {
        public List<Unit> Units { get; set; } = new List<Unit>();
    }
    class Unit
    {
        public int Duration { get; set; }
        public string Name { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
    class Topic
    {
        public string Name { get; set; }
    }
}