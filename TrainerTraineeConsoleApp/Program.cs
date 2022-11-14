namespace TrainerTraineeConsoleApp
{
    internal class Program // UI
    {
        static void Main(string[] args)
        {
            // Static Arrays
            // store 10 int numbers
            int[] n = new int[10];
            n[0] = 10;

            int a;

            // Dynamic Arrays
            // store n number of ints and process
            List<int> numbers = new List<int>();

        }
    }

    class Organization
    {
        public string Name { get; set; }
    }

    class Trainer
    {
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
        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
    class Topic
    {
        public string Name { get; set; }
    }
}