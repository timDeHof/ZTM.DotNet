﻿Console.WriteLine("Arithmetic Operators");
Console.WriteLine();
Console.WriteLine("  Increment and decrement");
int a = 7;
int b = a++;
Console.WriteLine($"  a: {a}, b: {b}");

int c = 7;
int d = --c;
Console.WriteLine($"  C: {c}, d: {d}");

Console.WriteLine();
Console.WriteLine("  Plus, minus, multiplication, division");
int e = 2 + 7;
int f = 9 - 3;
int g = 10 * 4;
int h = 16 / 2;
Console.WriteLine($"  e: {e}, f: {f}, g: {g}, h: {h}");

int i = 2 + 16 / 2;
int j = (2 + 16) / 2;
Console.WriteLine($"  i: {i}, j: {j}");

Console.WriteLine();
Console.WriteLine("Comparsion operators");
int k = 17;
int l = 15;
Console.WriteLine(k > l);  // True
Console.WriteLine(k < l);  // False
Console.WriteLine(k >= l); // True
Console.WriteLine(k <= l); // False

Console.WriteLine();
Console.WriteLine("Boolean logical operators");

bool isRegistered = false;
Console.WriteLine($"isRegistered: {isRegistered}"); // False
Console.WriteLine($"isRegistered Not: {!isRegistered}"); // True

bool isWednesday = true;
bool isWeekend = false;
Console.WriteLine(isWednesday && isWeekend); // False
Console.WriteLine(isWednesday || isWeekend); // True

Console.WriteLine();
Console.WriteLine("Equality operators");
string myName = "Tim";
string myCountry = "USA";
int myluckyNumber = 7;

Console.WriteLine(myluckyNumber != 5);  // True
Console.WriteLine(myluckyNumber == 7);  // True
Console.WriteLine(myName == myCountry); // False