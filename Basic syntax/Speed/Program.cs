double meters = double.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
int seconds = int.Parse(Console.ReadLine());

Console.WriteLine("{0:f6}", meters/(hours * 3600 + minutes * 60 + seconds));
