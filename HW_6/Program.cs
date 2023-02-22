using HW_6.ValuesOperations;

int a = 5;
int b = 6;

var operations = new Operations();

Console.WriteLine($"Values before SWAP: a={a}, b={b}");

operations.Swap(ref a, ref b);

Console.WriteLine($"Values after SWAP: a={a}, b={b}");
Console.WriteLine();

int c = 123456;
int amount;

operations.CountFigures(c, out amount);
Console.WriteLine($"Amount of figures in number: {amount}");
Console.WriteLine();

string str = "Something";
int d = 5;
string symbol;

operations.ReturnSymbol(str,d,out symbol);
Console.WriteLine($"Word for work: {str}");
Console.WriteLine($"Number of searching symbol:{d}");
Console.WriteLine($"Symbol to Return: {symbol}");

