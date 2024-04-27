using System;

Console.WriteLine("Hello Prep2 World!");

Console.Write("Please enter your grade: ");
string UserValue = Console.ReadLine();

int Grade = int.Parse(UserValue);

string Letter = "";

if (Grade >= 90)
{
    Letter = "A";

}
else if (Grade >= 80)
{
    Letter = "B";

}
else if (Grade >= 70)
{
    Letter = "C";
}
else if (Grade >= 60)
{
    Letter = "D";
}
else
{
    Letter = "F";
}
Console.WriteLine($"Your grade is: {Grade}");

if (Grade >= 70)
{
    Console.WriteLine("Congratulations! You passed.");
}
else
{
    Console.WriteLine("Goodluck next next!");
}
