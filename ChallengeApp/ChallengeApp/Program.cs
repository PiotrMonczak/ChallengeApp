using ChallengeApp;

var emp = new Employee("Ania", "AniaAnia");
emp.AddGrade(3.14);
emp.AddGrade(4);
emp.AddGrade(12);
emp.AddGrade(5);
emp.AddGrade(25);
emp.AddGrade(16);

var statistics = emp.GetStatistics();

Console.WriteLine("Wynik dla GetStatistics = GetStatisticsForeach");
Console.WriteLine($"Max = {statistics.Max}");
Console.WriteLine($"Min = {statistics.Min}");
Console.WriteLine($"Average = {statistics.Average:N2}");

var statistics2 = emp.GetStatisticsWithFor();

Console.WriteLine("Wynik dla GetStatisticsWithFor");
Console.WriteLine($"Max = {statistics2.Max}");
Console.WriteLine($"Min = {statistics2.Min}");
Console.WriteLine($"Average = {statistics2.Average:N2}");

var statistics3 = emp.GetStatisticsWithDoWhile();

Console.WriteLine("Wynik dla GetStatisticsWithDoWhile");
Console.WriteLine($"Max = {statistics2.Max}");
Console.WriteLine($"Min = {statistics2.Min}");
Console.WriteLine($"Average = {statistics2.Average:N2}");

var statistics4 = emp.GetStatisticsWithWhile();

Console.WriteLine("Wynik dla GetStatisticsWithWhile");
Console.WriteLine($"Max = {statistics2.Max}");
Console.WriteLine($"Min = {statistics2.Min}");
Console.WriteLine($"Average = {statistics2.Average:N2}");





// Console.WriteLine("Max =" + statistics.Max);
// Console.WriteLine("Min =" + statistics.Min);
// Console.WriteLine("Average =" + statistics.Average);

