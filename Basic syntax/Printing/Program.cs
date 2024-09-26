string text = Console.ReadLine();
char symbol = char.Parse(Console.ReadLine());
int integer = int.Parse(Console.ReadLine());
double realNum = double.Parse(Console.ReadLine());

Console.WriteLine(text);
Console.WriteLine(symbol);
Console.WriteLine(integer);
Console.WriteLine(realNum);

Console.WriteLine($"{text} {symbol} {integer} {realNum}");