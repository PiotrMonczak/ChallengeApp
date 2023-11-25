
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
            this.grades.Add(valueInDouble);
        }

        public void AddGrade(long grade)
        {
            float valueInLong = (float)grade;
            this.grades.Add(valueInLong);
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
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for( int i=0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average = statistics.Average + this.grades[i];
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int k = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[k]);
                statistics.Min = Math.Min(statistics.Min, grades[k]);
                statistics.Average = statistics.Average + grades[k];
                k++;
            } while (k < this.grades.Count);

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int n = 0;

            while (n < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[n]);
                statistics.Min = Math.Min(statistics.Min, grades[n]);
                statistics.Average = statistics.Average + grades[n];
                n++;
            } 

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }

    }
}
