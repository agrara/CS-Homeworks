internal class Program
{
    private static void Main(string[] args)
    {
        int arrDim;
        if (int.TryParse(Console.ReadLine(), out arrDim))
        {
            int[] arr = new int[arrDim];
            Array.Copy(Console.ReadLine().Split(",").Select(int.Parse).ToArray(), 0, arr, 0, arrDim);
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmpVal;
                tmpVal = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tmpVal;
            }
            foreach (int el in arr)
            {
                Console.Write($"{el} ");
            }
        }

    }
}