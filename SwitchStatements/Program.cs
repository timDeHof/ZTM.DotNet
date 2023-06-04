Console.WriteLine("Enter your age: ");
string? input = Console.ReadLine();
int age = int.Parse(input);

switch (age)
{
    case < 10:
        Console.WriteLine("you're a child");
        break;
    case < 20:
        Console.WriteLine("you're a teenager");
        break;
    case < 30:
        Console.WriteLine("you're a young adult");
        break;
    case < 40:
        Console.WriteLine("you're an adult");
        break;
    case < 50:
        Console.WriteLine("you're still an adult");
        break;
    default:
        Console.WriteLine("you're a wise person");
        break;
}


Console.WriteLine();
switch (age)
{
    case 10:
    case 20:
    case 30:
    case 40:
    case 50:
    case 60:
        Console.WriteLine("You just had a round birthday");
        break;
    default:
        Console.WriteLine("you just had a normal birthday");
        break;
}