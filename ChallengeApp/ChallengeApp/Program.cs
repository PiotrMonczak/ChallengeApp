

using ChallengeApp;

Employee user1 = new Employee("Ania", "AniaAnia", "35");
Employee user2 = new Employee("Tomek", "TomekTomek", "40");
Employee user3 = new Employee("Kasia", "KasiaKasia", "25");

user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(4);

user2.AddScore(9);
user2.AddScore(2);
user2.AddScore(5);

user3.AddScore(4);
user3.AddScore(8);
user3.AddScore(7);

List<Employee> Workers = new List<Employee>() 
{
    user1, user2, user3
};

int MaxResult = -1;
Employee userWithMaxResult = null;

foreach (var worker in Workers)
{
    if ( worker.Result > MaxResult) 
    {
        userWithMaxResult = worker;
        MaxResult = worker.Result;
    }
}


Console.WriteLine(userWithMaxResult.Name);

