
namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string name, string surname, string age)  // konstruktor
        {
            this.name1 = name;
            this.surname1 = surname;
            this.age1 = age;

        }
        public string name1 { get; set; } // property, pola
        public string surname1 { get; set; }
        public string age1 { get; set; }

        public int Result1
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
