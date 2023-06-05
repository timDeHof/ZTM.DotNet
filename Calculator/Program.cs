string value;
do
{
    float result;
    Console.WriteLine("+---------------------------+");
    Console.WriteLine("|      Calculator           |");
    Console.WriteLine("+---------------------------+");
    Console.WriteLine();
    Console.Write("What is the first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("What is the second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Select a Calculation Method");
    Console.WriteLine("---------------------------");
    Console.WriteLine("1.     Addition (+)        ");
    Console.WriteLine("2.     Subtraction (-)     ");
    Console.WriteLine("3.     Multiplication (*)  ");
    Console.WriteLine("4.     Division (/)        ");
    Console.WriteLine("5.     Module (%)          ");
    Console.Write("     Enter Choice (1-5):");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine($"result: {firstNumber + secondNumber}"); break;
        case "2":
            Console.WriteLine($"result: {firstNumber - secondNumber}"); break;
        case "3":
            Console.WriteLine($"result: {firstNumber * secondNumber}"); break;
        case "4":
            Console.WriteLine($"result: {firstNumber / secondNumber}"); break;
        case "5":
            Console.WriteLine($"result: {firstNumber % secondNumber}"); break;
        default:
            Console.WriteLine("Invalid Choice"); break;
    }
    Console.Write("Do you want to continue(y/n):");
    value = Console.ReadLine();
}
while (value == "y" || value == "Y");
