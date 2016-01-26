using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
   delegate string Work (string result);     // делегат

   class Human : Personality
    {
        

       
        
        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" \t \t \t ------МЕНЮ------- \t \t \t \n");
            Console.WriteLine("\t Выберите действие: \n 1 - Кормить \n 2 - Играть \n 3 - Спать \n 4 - Работать \n 5 - Выбрать характер \n 6 - Выход");

            Console.ForegroundColor = ConsoleColor.White;

        link: try
            {
                Console.WriteLine("Введите номер выбора");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:                         
                        Human h1 = new Human();
                        h1.Feed();
                        break;
                    case 2:
                        Human h2 = new Human();
                        h2.Play();
                        break;
                    case 3:
                        Human h3 = new Human();
                        h3.Sleep();
                        break;
                    case 4:
                        Work h4 = new Work(HumanWorking);           // вызов делегата
                        string result = h4("");
                        break;
                    case 5:
                        Human h5 = new Human();
                        h5.Personality();
                        break;
                    case 6:
                        return;
                        }

                if (input < 1 || input > 7)
                {
                    Console.WriteLine("Проверьте введенное число!");
                    goto link;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Число должно быть от 1 до 7");
                goto link;
            }
        }
        public void Feed()
        {
            Console.WriteLine("Выберите, чем покормить человека. \n Если нужного блюда в списке нет, введите любое другое число, чтобы добавить свое\n");
            List<string> food = new List<string>();     
            food.Add("1 - суп");
            food.Add("2 -котлета");
            food.Add("3 - компот");

            foreach (string f in food)
            {
                Console.WriteLine(f);
            }

            int i;
            i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                Console.WriteLine("Сегодня на обед у человека" + " " + (food[0]) + "\n");
            }
            else if (i == 2)
            {
                Console.WriteLine("Сегодня на обед у человека" + " " + (food[1]) + "\n");
            }
            else if (i == 3)
            {
                Console.WriteLine("Сегодня на обед у человека" + " " + (food[2]) + "\n");
            }
            else
            {
                Console.WriteLine("Введите свой вариант еды: \n");
                string newfood = Console.ReadLine();
                food.Add(newfood);

                foreach (string f in food)
                {
                    Console.WriteLine(f);
                }

                Console.WriteLine("Сегодня на обед у человека " + " " + (food[3]) + "\n"); 
            }

            Console.WriteLine("Для возврата в основное меню нажмите Enter");
            Console.ReadLine();
            Menu();
        }

        public void Play()
        {
            Console.WriteLine("Сыграем? Правила простые: человек загадал число. Попробуйте угадать его! \n");

            start:
            Console.WriteLine("Введите число от 1 до 10: \n");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели число {0}", number.ToString());

            Random ran = new Random();
            int min = 1;
            int max = 10;
            for (int i = 1; i <= 1; i++)
            {
                Console.WriteLine("Посмотрим, совпали ли ваши числа. \n Человек загадал число " + ran.Next(min, max));
            }

            Console.WriteLine("Хотите сыграть еще раз? 1 - Да \n 2 - Нет \n");
            int enter;
            enter = Convert.ToInt32(Console.ReadLine());
            if (enter == 1)
            {
                goto start;
            }
            else
            {
                Console.WriteLine("Для возврата в основное меню нажмите Enter \n");
                Console.ReadLine();
                Menu();
            }    
        }

        public void Sleep()
        {
            int input;
            Console.WriteLine("Время спать? \t 1 - Да \t 0 - Нет");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Человек спит. Чтобы разбудить его и вернуться в основное меню, нажмите Enter \n");
                Console.ReadLine();
                Menu();
            }
            else
            {
                Menu();
            }
            
        }


       static string HumanWorking(string empty)   // конструктор? реализация делегата
        {

            Console.WriteLine("Вы хотите отправить человека на работу? \t  1 - Да \n 0 - Нет");

            int input;

            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Человек работает. Чтобы вернуться в основное меню, нажмите Enter \n");
                Console.ReadLine();
                Human hm = new Human();
                hm.Menu();
                return empty = "";
            }
            else
            {
                Human hm = new Human();
                hm.Menu();
                return empty = "";
            }
        }
        public void Walk()
        {
            int input;
            Console.WriteLine("Хотите отправить человека на прогулку? \n 1 - Да \n 0 - Нет");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Человек на прогулке. Чтобы вернуться в основное меню, нажмите Enter \n");
                Console.ReadLine();
                Menu();
            }
            else
            {
                Menu();
            }
        }

        public override string Character        // переопределение абстрактного свойства
        {
            get
            {
                return character;
            }
            set
            {
                character = value;
            }
        }

        public void Personality()
        {
            Human h1 = new Human();
            Console.WriteLine("Выберите характер: \n");
      
            string[] features = new string[6];
            features[0] = "Вредный";
            features[1] = "Добрый";
            features[2] = "Наглый";
            features[3] = "Заносчивый";
            features[4] = "Вспыльчивый";
            features[5] = "Отзывчивый \n";
            foreach (string i in features)
            {
                Console.WriteLine(i);
            }

            string s = Console.ReadLine();
            h1.Character = s;

            Console.WriteLine("Выбран характер:" + " " + h1.Character + "\n");

            Console.WriteLine("Для возврата в основное меню нажмите Enter \n");
            Console.ReadLine();
            Menu();
        }
       
    }
}
