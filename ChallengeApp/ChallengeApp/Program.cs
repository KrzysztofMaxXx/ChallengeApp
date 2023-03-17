using ChalangeApp;


Employee eployee1 = new Employee(" Adam", " Kowalski", 48);
Employee eployee2 = new Employee(" Piotr", " Walczowski", 39);
Employee eployee3 = new Employee(" Roman", " Zając", 35);




Console.WriteLine("NAME " + eployee1.Name);
Console.WriteLine("SURNAME " + eployee1.Surname);
Console.WriteLine("AGE " + eployee1.age);
eployee1.ADDPOINT(1);
eployee1.ADDPOINT(2);
eployee1.ADDPOINT(3);
eployee1.ADDPOINT(13);
eployee1.ADDPOINT(3);
Console.WriteLine("POINT " + eployee1.Result + "\n");

Console.WriteLine("NAME " + eployee2.Name);
Console.WriteLine("SURNAME " + eployee2.Surname);
Console.WriteLine("AGE " + eployee2.age);
eployee2.ADDPOINT(2);
eployee2.ADDPOINT(3);
eployee2.ADDPOINT(13);
eployee2.ADDPOINT(3);
eployee2.ADDPOINT(3);
Console.WriteLine("POINT " + eployee2.Result + "\n");

Console.WriteLine("NAME " + eployee3.Name);
Console.WriteLine("SURNAME " + eployee3.Surname);
Console.WriteLine("AGE " + eployee3.age);
eployee3.ADDPOINT(22);
eployee3.ADDPOINT(8);
eployee3.ADDPOINT(11);
eployee3.ADDPOINT(6);
eployee3.ADDPOINT(1);
Console.WriteLine("POINT " + eployee3.Result + "\n");



List<Employee> emploers = new List<Employee>()
{
    eployee1,eployee2,eployee3
};
int maxResult = -1;


Employee? userWithMaxResult = null;

foreach (var emp in emploers)
{
    if (emp.Result >= maxResult)
    {
        userWithMaxResult = emp;
        maxResult = userWithMaxResult.Result;

    }

}


if (eployee1.Result == maxResult)
{

    Console.WriteLine("\t" + " najwiecej punktow mają ");
    Console.WriteLine(eployee1.Name); ;
    Console.WriteLine(eployee1.Surname);
    Console.WriteLine(eployee1.age);
    Console.WriteLine(eployee1.Result);
    if (eployee1 != userWithMaxResult)
    {
        Console.WriteLine(userWithMaxResult.Name);
        Console.WriteLine(userWithMaxResult.Surname);
        Console.WriteLine(userWithMaxResult.age);
        Console.WriteLine(userWithMaxResult.Result);
    }
}
else if (eployee2.Result == eployee3.Result)
{
    Console.WriteLine("\t" + " najwiecej punktow mają ");
    Console.WriteLine(eployee2.Name); ;
    Console.WriteLine(eployee2.Surname);
    Console.WriteLine(eployee2.age);
    Console.WriteLine(eployee2.Result);

    Console.WriteLine("\t" + " I równierz ");
    Console.WriteLine(eployee3.Name); ;
    Console.WriteLine(eployee3.Surname);
    Console.WriteLine(eployee3.age);
    Console.WriteLine(eployee3.Result);

}
else
{
    Console.WriteLine("\t" + " najwiecej punktow ma ");
    Console.WriteLine(userWithMaxResult.Name);
    Console.WriteLine(userWithMaxResult.Surname);
    Console.WriteLine(userWithMaxResult.age);
    Console.WriteLine(userWithMaxResult.Result);
}