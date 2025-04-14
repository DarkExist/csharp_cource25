namespace csharp_cource25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите верхний диапазон чисел");
            string upperBorderUserInput = Console.ReadLine();
            int upperBorderValue = 10;
            try
            {
                if (upperBorderUserInput != "")
                {
					upperBorderValue = Convert.ToInt32(upperBorderUserInput);
				}
            }
            catch (Exception ex)
            {
				Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Установлено значение по умолчанию 10");
			}

            
            List<int> list = new List<int>();
            for (int i = 0; i <= upperBorderValue; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("Угадай число");
            int countOfTry = (int)Math.Ceiling(Math.Log2(list.Count)) - 1;
            Console.WriteLine(string.Join(" ", list));
			int randomNumber = list[new Random().Next(list.Count)];
            List<int> userTries = new List<int>();
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

                if (!userTries.Contains(userParsedInp))
                {
                    userTries.Add(userParsedInp);
                }
                else
                {
                    Console.WriteLine("Программа уведомляет Вас, что вы лошара(число уже было введено Вами)");
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
