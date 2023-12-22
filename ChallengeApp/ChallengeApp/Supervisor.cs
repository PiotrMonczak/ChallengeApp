

namespace ChallengeApp
{
    internal class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)

        {
            this.Name = name;
            this.Surname = surname;

        }
        public string Name { get; set; }

        public string Surname { get; set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalide grade value");
            }
        }

        public void AddGrade(double grade)
        {
            float gradesAsFloat = (float)grade;
            this.AddGrade(gradesAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradesAsFloat = grade;
            this.AddGrade(gradesAsFloat);
        }

        public void AddGrade(char grade)
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

        public void AddGrade(string grade)
        {
            switch (grade)
            {                
                case "6":
                    this.AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    this.AddGrade(95);
                    break;
                case "+5":
                case "5+":
                    this.AddGrade(85);
                    break;
                case "-5":
                case "5-":
                    this.AddGrade(75);
                    break;
                case "+4":
                case "4+":
                    this.AddGrade(65);
                    break;
                case "-4":
                case "4-":
                    this.AddGrade(55);
                    break;
                case "+3":
                case "3+":
                    this.AddGrade(45);
                    break;
                case "-3":
                case "3-":
                    this.AddGrade(35);
                    break;
                case "+2":
                case "2+":
                    this.AddGrade(25);
                    break;
                case "-2":
                case "2-":
                    this.AddGrade(15);
                    break;
                case "+1":
                case "1+":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    if (float.TryParse(grade, out float result))
                    {
                        this.AddGrade(result);
                        break;
                    }
                    else if (char.TryParse(grade, out char char_result))
                    {
                        this.AddGrade(char_result);
                        break;
                    }
                    else
                    {
                        throw new Exception("String is not float");
                    }
                   
            }

        }

        public Statistics GetStatistics()
        {
            return new Statistics();    
        }
    }
}
