namespace csharp_cource25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<int> list = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("Угадай число");
            int countOfTry = 3;
            Console.WriteLine(string.Join(" ", list));
			int randomNumber = list[new Random().Next(list.Count)];
            bool winFlag = false;
            while (countOfTry > 0)
            {
                Console.WriteLine("Введите число");
                var userInput = Console.ReadLine();
                int userParsedInp;
                try
                {
                    userParsedInp = Convert.ToInt32(userInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                if (userParsedInp == randomNumber)
                {
                    winFlag = true;
                    break;
                }
                else if (userParsedInp < randomNumber)
                {
                    Console.WriteLine("Загаданное число больше");
                }
                else
                {
					Console.WriteLine("Загаданное число меньше");
				}
                countOfTry++;
			}
            if (!winFlag)
            {
                Console.WriteLine("Game over");
            }
            else
            {
				Console.WriteLine("Your super puper mega ultra");
			}
        }
    }
}
