

namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase // : IEmployee
    {


        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname) //konstruktor
            : base(name, surname)
        {
            
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)     
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalide grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradesAsFloat = (float)grade;
            this.AddGrade(gradesAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradesAsFloat = grade;
            this.AddGrade(gradesAsFloat);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char char_result))
            {
                this.AddGrade(char_result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.AddGrade(grade);
                }
            }

                        
            return statistics;
        }
    }
}
