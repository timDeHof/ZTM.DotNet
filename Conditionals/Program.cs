// if
int myLuckyNumber = 15;

if (myLuckyNumber == 16)
{
    Console.WriteLine("You're lucky!");
}

Console.WriteLine("Conditionals are cool!");

Console.WriteLine();
// if - else
if (myLuckyNumber < 16)
{
    Console.WriteLine("Your lucky number is lower than 16.");
}
else
{
    Console.WriteLine("Your lucky number is 16 or higher.");
}

Console.WriteLine();
// if - else if - else
string name = "Tim";

if(name == "Tim")
{
    Console.WriteLine("hi, Tim!");
}
else if (name == "John")
{
    Console.WriteLine("Hi, John!");
}
else
{
    Console.WriteLine("Hi, nice to meet you!");
}

Console.WriteLine();
Console.WriteLine("ternary operator");
int version = 4;
string productVersion = version == 4 ? "4.0" : "3.0";
Console.WriteLine(productVersion);