using System;
using System.Security.Cryptography.X509Certificates;

namespace GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string rules = default;
          
            Console.WriteLine("Добро пожаловать в игру. \n*Для того, чтобы узнать правила игры, напишите слово - ПРАВИЛА \n*Для того, чтобы начать игру, напишите слово - НАЧАТЬ");
            
            do
            {
             rules = Console.ReadLine();
                switch (rules)
                {
                    case "ПРАВИЛА":
                        Console.WriteLine("Правила игры: Вам будет загадано число в промежутке от -1000 до 1000. Также будут описаны свойства данного числа. Ваша задать отгадать данное число.\n*Для того, чтобы начать игру, напишите слово - НАЧАТЬ\"");
                        break;

                    case "НАЧАТЬ":
                        Console.WriteLine("Игра начинается");
                        break;

                    default:
                        Console.WriteLine("Ваша команда не понятна для меня. \n*Для того, чтобы узнать правила игры, напишите слово - ПРАВИЛА \n*Для того, чтобы начать игру, напишите слово - НАЧАТЬ\"");
                        break;
                }
            }
            while (rules != "НАЧАТЬ");
           // Console.WriteLine("Выбери уровень сложности: \n1. Легкий: диапазон значений от -100 до 100, количество попыток - 30 \n Средний: диапазон значений от -500 до 500, количество попыток - 20 \n Сложный: диапазон значений от -1000 до 1000, количество попыток - 10 \n Напишите цифру уровня сложности: ");
           // int complexity = Convert.ToInt32 (Console.ReadLine());

            while (true)
            {
                Random rand = new Random();
                int number = rand.Next(-1000, 1000);

                Console.WriteLine("Компьютер загадал число. Данное число: " + number);

                //1. Положительное или отрицательное
                 
                    if (number > 0)
                    {
                        Console.WriteLine("1. Число положительное");
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine("1. Число отрицательное");
                    }
                    else
                    {
                        Console.WriteLine("1. Число не положительное и не отрицательное");
                    }
                
                //2. Количество цифр в числе

                    bool negative = true; // КОЛИЧЕСТВО СИМВОЛОВ У ОТРИЦАТЕЛЬНОГО ЧИСЛА
                    string num = number.ToString();
                    int symbolsPlus = num.Length;
                    int symbolsMinus = symbolsPlus - 1;
                    if (number > 0)
                    {
                        Console.WriteLine("2. В данном числе " + symbolsPlus + " цифры");
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine("2. В данном числе " + symbolsMinus + " цифры");
                    }
                
                //3. Четное или нечетное
                 
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("3. Это четное число");
                    }
                    else
                    {
                        Console.WriteLine("3. Это нечетное число");
                    }

                //4. Сумма цифр
                
                    int amount = 0; //количество
                    if (negative == true)
                    {
                        amount = symbolsMinus;
                    }
                    else
                    {
                        amount = symbolsPlus;
                    }
                    int number1 = number;
                    number1 = Math.Abs(number);
                    int digit = 0; //цифра
                    int sum = 0;

                    while (amount > 0)
                    {
                        digit = number1 % 10;
                        sum = sum + digit;
                        number1 = number1 / 10;
                        amount--;
                    }
                    Console.WriteLine("4. Сумма цифр данного числа равна " + sum);
                
                
                // 5.Целое число
                Console.WriteLine("5. Это целое число");
                Console.WriteLine("Введите число для проверки:");

                int try1 = default;
                int numberАttempts = 10; // кол-во попыток
                int total;
                
                
                    for (total = numberАttempts; total > 0; total--)
                    {
                        while (true)
                        {
                            try
                            {
                                try1 = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("У меня не получается распознать ваше число. Попробуйте еще раз");
                            }
                        }

                        if (try1 > number)
                        {
                            Console.WriteLine("Ваше число больше, чем загаданное число");
                        }
                        else if (try1 < number)
                        {
                            Console.WriteLine("Ваше число меньше, чем загаданное число");
                        }
                        else if (try1 == number)
                        {
                            Console.WriteLine("Поздравляю, вы угадали число! \n██████████████\r\n█───█─██─█───█\r\n██─██─██─█─███\r\n██─██────█───█\r\n██─██─██─█─███\r\n██─██─██─█───█\r\n██████████████\r\n███████████████████\r\n█────██───█───█───█\r\n█─██──█─███─████─██\r\n█────██───█───██─██\r\n█─██──█─█████─██─██\r\n█────██───█───██─██\r\n███████████████████");
                        break;
                        }
                        else
                        {
                            Console.WriteLine("Произошла непредвиденная ошибка, попробуйте еще раз");
                        }
                        int totalX = total - 1;
                        Console.WriteLine("У вас осталось " + totalX + " попыток");
                    }
                
                  if (total == 0)
                {
                    Console.WriteLine("Вы проиграли. Было загадано число " + number);
                }
                
                Console.WriteLine("Нажмите ВВОД, чтобы начать новый раунд");
                Console.ReadLine();
                Console.WriteLine("______________________________________________________________");
            }
        }
    }
}