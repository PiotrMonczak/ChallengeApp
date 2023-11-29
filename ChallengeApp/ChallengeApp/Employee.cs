
namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)  // konstruktor
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Employee()  // konstruktor
        {
        }

        public string Name { get; private set; } // property, pola
        public string Surname { get; private set; }
        
        public void AddGrade(float grade) 
        {
            if(grade >=0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else 
            {
                Console.WriteLine("Invalide grade value");
            }
        }

        public void AddGrade(int grade)
        {
            float gradesAsFloat = grade;
            this.AddGrade(gradesAsFloat);
        }

        public void AddGrade(char grade)
        {
            switch(grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Invalide grade value");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average = statistics.Average + grade;
                }
            }

            statistics.Average = statistics.Average / this.grades.Count;

            switch (statistics.Average) 
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;

            }
                

            return statistics;
        }

    }
}
