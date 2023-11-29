using ChallengeApp;
using System;

Console.WriteLine("Witamy w programie oceny pracownika");
Console.WriteLine("------------------------------------");
Console.WriteLine();

var employee = new Employee();

var YesOrNot = true;

while (YesOrNot)
{
    Console.WriteLine("Czy chcesz dodać nową ocenę pracownika T/N: ");
    
    var YoN = Console.ReadLine();
    if (YoN == "T" || YoN == "t")
    {
        Console.WriteLine("Podaj ocenę pracownika: ");
        var input = Console.ReadLine();
        employee.AddGrade(input);
    }
    else if (YoN == "n" || YoN == "N")
    {
        YesOrNot = false;
    }
    else 
    {
        Console.WriteLine("Niewłasciwa litera, spróbuj jeszcze raz: ");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average =  {statistics.Average}");
Console.WriteLine($"Min =  {statistics.Min}");
Console.WriteLine($"Max =  {statistics.Max}");
Console.WriteLine($"Averade by Letter = {statistics.AverageLetter}");

// 1 - dziaaljąca aplikacja do oceny pracownika
// 2 - działające testy jednostwoe wraz ze sprawdzeniem liter A/B/C
// 3 wysłac na GutHub




