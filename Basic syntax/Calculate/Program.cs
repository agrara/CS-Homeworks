int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());

Console.WriteLine("The sum is: {0}", numOne + numTwo);
Console.WriteLine("The difference is: {0}", numOne - numTwo);
Console.WriteLine("The product is: {0}", numOne * numTwo);
Console.WriteLine("The average is: {0:f6}", ((double)numOne + (double)numTwo) / 2);
