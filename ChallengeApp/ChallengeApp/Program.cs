var name = "Ewa";
var sex = "Mężczyzna";
var age = 17;

if (sex == "Kobieta")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }

    else if (age > 30)
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }

    if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }

}

else if (sex == "Mężczyzna")
{
    if (age >= 18)
    {
        Console.WriteLine("Pelnoletni Mężczyzna");
    }

    else
    {
        Console.WriteLine("Niepelnoletni Mężczyzna");
    }
}
