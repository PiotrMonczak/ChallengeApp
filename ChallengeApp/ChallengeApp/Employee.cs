
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

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("Invalide grade value");
            }
                // var value = float.Parse(grade);
                // this.AddGrade(value);
        }

        public void AddGrade(double grade)
        {
            float valueInDouble = (float)grade;  
            if (valueInDouble >= 0 && valueInDouble <= 100 ) 
            {
                this.grades.Add(valueInDouble);
            }
            else
            {
                Console.WriteLine("Double variable above range");
            }
        }

        public void AddGrade(long grade)
        {
            float valueInLong = (float)grade;
            if (valueInLong >= 0 && valueInLong <= 100)
            {
                this.grades.Add(valueInLong);
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
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average = statistics.Average + grade;
                // mozna zapisać statistics.Average += grade;

            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
    }
}
