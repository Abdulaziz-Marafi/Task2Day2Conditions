// Reading name and language from user

Console.WriteLine("Please enter your name: ");
Console.WriteLine("----------------------- ");
string name = Console.ReadLine();

Console.WriteLine("Please enter your language: ");
Console.WriteLine("--------------------------- ");
string language  = Console.ReadLine();

// Display 
if (language == "en")
{
    Console.WriteLine("Hello " + name);
}else if (language == "es")
{
    Console.WriteLine("Hola " + name);
}
else if (language == "fr")
{
    Console.WriteLine("Bonjour " + name);
}
else
{
    Console.WriteLine("Merhaba " + name);
}

// Max Number

Console.WriteLine("Please enter a number: ");
Console.WriteLine("--------------------- ");
double num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter another number: ");
Console.WriteLine("--------------------- ");
double num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num1+ " is larger than "+ num2);
}
else
{
    Console.WriteLine(num2+ " is larger than "+ num1);
}


// Mark
Console.WriteLine("Please enter your mark: ");
Console.WriteLine("---------------------- ");
var mark = Convert.ToInt32(Console.ReadLine());

if (mark >= 88)
{
    Console.WriteLine("You got an A.");
}else if (mark >= 70)
{
    Console.WriteLine("You got a B.");
}else if (mark >= 60)
{
    Console.WriteLine("You got a C.");
}else if (mark >= 50)
{
    Console.WriteLine("You got a D.");
}else
{
    Console.WriteLine("You got an F.");
}
