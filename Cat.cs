using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tamagochi
{
    public class Cat : Appearance
    {
        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" \t \t \t ------МЕНЮ------- \t \t \t \n");
            Console.WriteLine("\t Выберите действие: \n \n 1 - Кормить \n 2 - Играть \n 3 - Спать \n 4 - Гулять \n 5 - Выбрать внешность \n 6 - Выбрать породу \n 7 - Выход");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Введите номер выбора");
            int input = Convert.ToInt32(Console.ReadLine());

        link: try
            {
                switch (input)
                {
                    case 1:                         
                        Cat c1 = new Cat();
                        c1.Feed();
                        break;
                    case 2:
                        Cat c2 = new Cat();
                        c2.Play();
                        break;
                    case 3:
                        Cat c3 = new Cat();
                        c3.Sleep();
                        break;
                    case 4:
                        Cat c4 = new Cat();
                        c4.Walk();
                        break;
                    case 5:
                        Cat c5 = new Cat();
                        c5.Appearance();
                        break;
                    case 6:
                        Cat c6 = new Cat();
                        c6.Breed();
                        break;
                    case 7:
                        return;

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Читай внимательно! Надо вводить Ч-И-С-Л-О!");
                goto link;
            }   
        

                if (input < 1  || input > 7)
                { try
                {
                   Console.WriteLine("Проверьте введенное число!");
                   goto link;
                }
                   catch (FormatException)
                        {
                            Console.WriteLine("Число должно быть от 1 до 7");
                            goto link;
                        }
                }
        }

        
        public void Feed()
        {
            Console.WriteLine("Выберите, чем покормить кота. \n Если нужного блюда в списке нет, введите любое другое число, чтобы добавить свое \n");
            List<string> food = new List<string>();
            food.Add("1 - рыба");
            food.Add("2 -вискас");
            food.Add("3 - молоко");

            foreach (string f in food)
            {
                Console.WriteLine(f);
            }

            int i;
            i = Convert.ToInt32(Console.ReadLine());

            if (i == 1)
            {
                Console.WriteLine("Сегодня на обед у кота" + " " + (food[0]) + "\n");
            }
            else if (i == 2)
            {
                Console.WriteLine("Сегодня на обед у кота" + " " + (food[1]) + "\n");
            }
            else if (i == 3)
            {
                Console.WriteLine("Сегодня на обед у кота" + " " + (food[2]) + "\n");
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

                Console.WriteLine("Сегодня на обед у кота" + " " + (food[3]) + "\n");
            }

            Console.WriteLine("Для возврата в основное меню нажмите Enter");
            Console.ReadLine();
            Menu();
        }

         public void Play()
            {
                Console.WriteLine("Сыграем? Правила простые: ваш питомец загадал число. Попробуйте угадать его! \n");
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
                    Console.WriteLine("Посмотрим, совпали ли ваши числа. \n Ваш питомец загадал число " + ran.Next(min, max));
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
                     Console.WriteLine("Кот спит. Чтобы разбудить его и вернуться в основное меню, нажмите Enter \n");
                     Console.WriteLine("Для возврата в основное меню нажмите Enter \n");
                     Console.ReadLine();
                     Menu();
                 }
                 else
                 {
                     Menu();
                 }
             }

        public void Walk()
        {
            int input;
            Console.WriteLine("Хотите отправить питомца на прогулку? \t 1 - Да \t 0 - Нет");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Кот на прогулке. Чтобы вернуться в основное меню, нажмите Enter \n");
                Console.WriteLine("Для возврата в основное меню нажмите Enter \n");
                Console.ReadLine();
                Menu();
            }
            else
            {
                Menu();
            }
        }

        public override string HairColor        // переопределение абстрактного свойства
        {
            get
            {
                return haircolor;
            }
            set
            {
                haircolor = value;
            }
        }

        public override string HairLength       // переопределение абстрактного свойства
        {
            get
            {
                return hairlength;
            }
            set
            {
                hairlength = value;
            }
        }


        public override string Breed()         // переопределение абстрактного метода
        {
            Console.WriteLine("Выберите породу. \n Если нужной породы в списке нет, введите любое другое число, чтобы добавить свою \n");

            List<string> breeds = new List<string>();
            breeds.Add("1 - Перс");
            breeds.Add("2 - Британская");
            breeds.Add("3 - Мейн-кун \n");
            foreach (string breed in breeds)
            {
                Console.WriteLine(breed);
            }

            int result = Convert.ToInt32(Console.ReadLine());
            if (result == 1)
            {
                Console.WriteLine("Выбрана порода: " + " " + (breeds[0]) + "\n");
                Console.WriteLine("Для возврата в основное меню нажмите Enter \n");
                Console.ReadLine();
                Menu();
                return result.ToString();
                
            }
            else if (result == 2)
            {
                Console.WriteLine("Выбрана порода: " + " " + (breeds[1]) + "\n");
                Console.WriteLine("Для возврата в основное меню нажмите Enter \n");
                Console.ReadLine();
                Menu();
                return result.ToString();
            }
            else if (result == 3)
            {
                Console.WriteLine("Выбрана порода: " + " " + (breeds[2]) + "\n");
                Console.WriteLine("Для возврата в основное меню нажмите Enter \n");
                Console.ReadLine();
                Menu();
                return result.ToString();
                
            }
            else
            {
                Console.WriteLine("Введите свою породу: \n");
                string newbreed = Console.ReadLine();
                breeds.Add(newbreed);

                foreach (string breed in breeds)
                {
                    Console.WriteLine(breed);
                }

                Console.WriteLine("Выбрана своя порода: " + " " + (breeds[3]) + "\n");
                return result.ToString();
            }


        }

        public void Appearance()
        {
            Cat c1 = new Cat();
            Console.WriteLine("Выберите цвет шерсти: \n");

            string[] hair = new string[3];
            hair[0] = "Рыжий";
            hair[1] = "Черный";
            hair[2] = "Белый \n";
            foreach (string i in hair)
            {
                Console.WriteLine(i);
            }

            string s = Console.ReadLine();
            c1.HairColor = s;

            Console.WriteLine("Выбран цвет шерсти: " + " " + c1.HairColor + "\n");

            Cat c2 = new Cat();
            Console.WriteLine("Выберите длину шерсти: \n");

            string[] length = new string[3];
            length[0] = "Короткая";
            length[1] = "Средняя";
            length[2] = "Длинная \n";
            foreach (string h in length)
            {
                Console.WriteLine(h);
            }

            string u = Console.ReadLine();
            c2.HairLength = u;

            Console.WriteLine("Выбрана длина шерсти:" + " " + c2.HairLength + "\n");
            Console.WriteLine("Для возврата в основное меню нажмите Enter \n");
            Console.ReadLine();
            Menu();
        }

    }
}
