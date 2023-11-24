using ChallengeApp;

var emp = new Employee("Ania", "AniaAnia");
emp.AddGrade(3.14);
emp.AddGrade(4);
emp.AddGrade(9223372036854775907);
emp.AddGrade(5);
var statistics  = emp.GetStatistics();

// Console.WriteLine("Max =" + statistics.Max);
// Console.WriteLine("Min =" + statistics.Min);
// Console.WriteLine("Average =" + statistics.Average);

Console.WriteLine($"Max = { statistics.Max}");
Console.WriteLine($"Min = { statistics.Min}");
Console.WriteLine($"Average = { statistics.Average:N2}");