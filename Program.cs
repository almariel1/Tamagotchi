using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Program 
    {
        
      
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" \t \t \t Добро пожаловать!");
            //меню
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" \t \t \t ------МЕНЮ------- \t \t \t \n");

            Console.WriteLine("\t Выберите персонажа: \n 1 - Собака \n 2 - Кошка \n 3 - Человек \n 4 - Выход");
            Console.ForegroundColor = ConsoleColor.White;

            string [] species = new string [3];
            species[0] = "Собака";
            species[1] = "Кот";
            species[2] = "Человек";

            DateTime curDate = DateTime.Now;
            Console.WriteLine("Введите номер выбора \n");
            int input = Convert.ToInt32(Console.ReadLine());

            CreatureName nm = new CreatureName();                       // реализация свойства
            Console.WriteLine("Выберите имя для персонажа \n");             
            string n = Console.ReadLine();
            nm.Name = n;
            
            

            if (input == 1)
            {
                Console.WriteLine("Поздравляем! Вы завели питомца: " + (species[0]) + " " + "по имени " + " " + nm.Name + ". \n" + "Дата и время создания: " + curDate);
            }
            else if (input == 2)
            {
                Console.WriteLine("Поздравляем! Вы завели питомца: " + (species[1]) + " " + "по имени " + " " + nm.Name + ". \n" + "Дата и время создания: " + curDate);
            }
            else
            {
                Console.WriteLine("Поздравляем! Вы завели питомца: " + (species[2]) + " " + "по имени " + " " + nm.Name + ". \n" + "Дата и время создания: " + curDate + " \n ");
            }


        link: try
            {
            switch (input)
                 {
                    case 1:
                         Dog dg = new Dog();
                         dg.Menu();
                         break;
                    case 2:
                         Cat ct = new Cat();
                         ct.Menu();
                         break;
                    case 3:
                         Human hm = new Human();
                         hm.Menu();
                         break;
                    case 4: 
                         goto link;
                 }

             }

            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Читай внимательно! Надо вводить Ч-И-С-Л-О!");
                Console.ForegroundColor = ConsoleColor.White;
                goto link;
            }

        Console.ReadLine();
          
        }
    }
}
