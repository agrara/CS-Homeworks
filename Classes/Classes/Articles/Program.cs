namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Article article = new Article(Console.ReadLine().Split(", ").Select(e => e).ToArray());

            int n = 0;
            getN(ref n);

            for (int i = 0; i < n; i++)
            {

                    KeyValuePair<string, string> commandPair = getCommand(Console.ReadLine());

                switch (commandPair.Key) {
                    case "Edit":
                        article.EditContent(commandPair.Value);
                        break;
                    case "ChangeAuthor":
                        article.changeAuthor(commandPair.Value);
                        break;
                    case "Rename":
                        article.rename(commandPair.Value);
                        break;

                }

            }

            Console.WriteLine(article);
        }

        static void getN(ref int n) {


            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {

                Console.WriteLine("Please enter valid number!");

            }

        }

        static KeyValuePair<string, string> getCommand(string input) {

            string[] inputArr =  input.Split(": ").ToArray();
            return new KeyValuePair<string, string>(inputArr[0], inputArr[1]);
        
        }

    }

}

