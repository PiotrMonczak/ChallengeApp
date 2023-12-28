using ChallengeApp;
using System;

Console.WriteLine("Witamy w programie oceny pracownika");
Console.WriteLine("------------------------------------");
Console.WriteLine();

var employee = new EmployeeInMemory("Ania", "AniaAnia");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano ocenę");
}


employee.AddGrade(34);
employee.AddGrade(12);
employee.AddGrade(21);
employee.AddGrade(0.5f);

//while (true)
//{
//    Console.WriteLine("Podaj ocenę pracownika");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        employee.AddGrade(input);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exeption catched: {e.Message}");
//    }
//}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average =  {statistics.Average}");
Console.WriteLine($"Min =  {statistics.Min}");
Console.WriteLine($"Max =  {statistics.Max}");
Console.WriteLine($"Averade by Letter = {statistics.AverageLetter}");

// 1 - dziaaljąca aplikacja do oceny pracownika
// 2 - działające testy jednostwoe wraz ze sprawdzeniem liter A/B/C
// 3 wysłac na GutHub




