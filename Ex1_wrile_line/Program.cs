Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("This is a red text.");
Console.ResetColor();


Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("This text has a yellow background.");
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Cyan;
string name = "John";
int age = 30;
double height = 1.75;
Console.WriteLine("Name: {0}, Age: {1}, Height: {2:F2}", name, age, height);

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("******************************");
Console.WriteLine("   Welcome to My Console App   ");
Console.WriteLine("******************************");
Console.ResetColor();
