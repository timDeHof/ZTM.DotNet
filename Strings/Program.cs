string message = "Hello World";
Console.WriteLine(message);

// empty string
string emptyMessage = string.Empty;

string stringWithDoubleQuote = "This is a string with a double quote: \" ";
Console.WriteLine(stringWithDoubleQuote);

string filePath = "C:\\temp";
Console.WriteLine(filePath);

string filePath2 = @"C:\temp";
Console.WriteLine(filePath2);

// string length
Console.WriteLine(filePath2.Length);

// string concatenation
string firstName = "Tim";
string lastName = "DeHof";

string fullName = firstName + " " +  lastName;
Console.WriteLine(fullName);

// string interploation
string fullNameInterpolate = $"{firstName} {lastName}";
Console.WriteLine(fullNameInterpolate);
Console.WriteLine($"The result is: {5 * 7}");

// Substrings
string first5characters = fullName.Substring(0, 5);
Console.WriteLine(first5characters);