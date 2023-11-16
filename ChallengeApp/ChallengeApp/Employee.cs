
namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string name, string surname, string age)  // konstruktor
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;

        }
        public string Name { get; set; } // property, pola
        public string Surname { get; set; }
        public string Age { get; set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number) // metoda
        {
            this.score.Add(number);
        }
    }
}
