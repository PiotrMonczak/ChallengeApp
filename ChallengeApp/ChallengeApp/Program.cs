
string name = "Ania";
var wiek = 25;
string gender = "kobieta";

if (gender == "kobieta" && wiek < 30)
{
    Console.WriteLine(" (1) - Kobieta poniżej 30 lat");
}
else if ( name == "Ewa" && wiek == 33)
{
    Console.WriteLine(" (2) - Ewa lat 33");
}
else if ( gender == "mezczyzna" && wiek < 18)
{
    Console.WriteLine(" (3) - Niepełnelotni mężczyzna");
}
else 
{
    Console.WriteLine(" (4) Warunki nie spełnione ");
}

