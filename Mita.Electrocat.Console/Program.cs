// Author: Alexey Boinskij, MITA Desktop 15-03 
// HomeWork1
// Date: 25 oct 2015

using System;
using System.Text;
using  Model;

namespace View
{

    class Program
    {
        private static void Main(string[] args)
        {
            // Возникли проблемы с кодировками
            // Чтобы кириллические символы правильно отображались
            // нужно настроить консоль (изменить шрифт на не-растровый, например, Consolas)
            // Или просто не пользоваться кириллицей.      
            Console.WriteLine("Programma \"Koshka dlya programmista\"");
            Console.WriteLine("Vvedite \"1\" chtoby ispol'zovat' kirillitsu");
            Console.WriteLine("ili luboj drugoj simvol chotoby prodolzhat ispol'zovat translit");
            char key = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
            if (key == '1') Cyrillic();
            else Translit();      
        }

        // Транслит
        static void Translit()
        {
            Console.WriteLine("Koshka priobretena");

            // UI001: Запросить возраст кошки у пользователя
            string theAge;
            while (true)
            {
                Console.WriteLine("Vvedite vozrast koshki:");
                theAge = Console.ReadLine();

                // проверка того, что возраст введён верно.
                // (0 - допустимое значение, это значит что кошке меньше года)
                int check;
                bool b = int.TryParse(theAge, out check);
                if (b && (check >= 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Vvedeno nedopustimoe znachenie.");
                    Console.WriteLine("Poprobujte escho raz, pozhalujsta.");
                    Console.WriteLine();
                }
            } // ..while (true)

            // создание экземпляра кошки
            Cat theCat = new Cat(theAge);

            // вывод меню
            while (true)
            {
                // UI004: Перед меню выводить информацию о кошке:
                // имя, возраст, текущий цвет
                Console.WriteLine("Imya:    {0}", theCat.Name);
                Console.WriteLine("Vozrast: {0}", theCat.Age);
                Console.WriteLine("Tekuschij tsvet: {0}", theCat.CurrentColor);
                Console.WriteLine();

                // UI002: Вывести меню со списком действий:
                // Задать имя
                // Задать цвет
                // Ударить
                // Покормить
                // UI003: После выполения выбранного действия не завершать работу
                // приложения, а снова выводить меню
                Console.WriteLine("Spisok dejstvij:");
                Console.WriteLine("1 - vyjti iz programmy");
                Console.WriteLine("2 - zadat' imya");
                Console.WriteLine("3 - zadat' tsvet");
                Console.WriteLine("4 - udarit'");
                Console.WriteLine("5 - pokormit'");

                // проверка того, что код операции введён верно.
                int op;
                string t = Console.ReadLine();
                int.TryParse(t, out op);
                if ((op < 1) || (op > 5))
                {
                    Console.WriteLine("Vvedeno nedopustimoe znachenie.");
                    Console.WriteLine("Poprobujte escho raz, pozhalujsta.");
                    Console.WriteLine();
                }

                switch (op)
                {
                    // некорректное значение
                    default:
                        Console.WriteLine("Oshybka. Programma ne dolzhna dostich etoj tochki.");
                        break;

                    // выход из программы
                    case 1:
                        Console.WriteLine("Vyhod.");
                        Console.ReadKey();
                        return;

                    // ввод имени кошки
                    case 2:
                        Console.WriteLine("Vvedite imya koshki:");
                        var theName = Console.ReadLine();
                        theCat.Name = theName;
                        break;

                    // задать цвет
                    case 3:
                        Console.WriteLine("Vvedite tsvet zdorovoj koshki:");
                        var theHealthyColor = Console.ReadLine();

                        Console.WriteLine("Vvedite tsvet bol'noj koshki:");
                        var theSickColor = Console.ReadLine();

                        theCat.Color.HealthyColor = theHealthyColor;
                        theCat.Color.SickColor = theSickColor;
                        break;

                    // ударить
                    case 4:
                        theCat.Punish();
                        Console.WriteLine("Vy udarili koshku.");
                        break;

                    // покормить
                    case 5:
                        theCat.Feed();
                        Console.WriteLine("Vy pokormili koshku.");
                        break;

                } // ..switch(op)
                Console.WriteLine();
            }
        }


        // Кириллица
        static void Cyrillic ()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Кошка приобретена");



            // UI001: Запросить возраст кошки у пользователя
            string theAge;
            while (true)
            {
                Console.WriteLine("Введите возраст кошки:");
                theAge = Console.ReadLine();

                // проверка того, что возраст введён верно.
                // (0 - допустимое значение, это значит что кошке меньше года)
                int check;
                bool b = int.TryParse(theAge, out check);
                if (b && (check >= 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введено недопустимое значение.");
                    Console.WriteLine("Попробуйте ещё раз, пожалуйста.");
                }
            } // ..while (true)

            // создание экземпляра кошки
            Cat theCat = new Cat(theAge);

            // вывод меню
            while (true)
            {
                // UI004: Перед меню выводить информацию о кошке:
                // имя, возраст, текущий цвет
                Console.WriteLine("Имя: {0}", theCat.Name);
                Console.WriteLine("Возраст: {0}", theCat.Age);
                Console.WriteLine("Текущий цвет: {0}", theCat.CurrentColor);
                Console.WriteLine();

                // UI002: Вывести меню со списком действий:
                // Задать имя
                // Задать цвет
                // Ударить
                // Покормить
                // UI003: После выполения выбранного действия не завершать работу
                // приложения, а снова выводить меню
                Console.WriteLine("Список действий:");
                Console.WriteLine("1 - выйти из программы");
                Console.WriteLine("2 - задать имя");
                Console.WriteLine("3 - задать цвет");
                Console.WriteLine("4 - ударить");
                Console.WriteLine("5 - покормить");

                // проверка того, что код операции введён верно.
                int op;
                string t = Console.ReadLine();
                int.TryParse(t, out op);
                if ((op < 1) || (op > 5))
                {
                    Console.WriteLine("Введено недопустимое значение.");
                    Console.WriteLine("Попробуйте ещё раз, пожалуйста.");
                    continue;
                }

                switch (op)
                {
                    // некорректное значение
                    default:
                        Console.WriteLine("Ошибка. Програма не должна достигунть этой точки");
                        break;

                    // выход из программы
                    case 1:
                        Console.WriteLine("Выход.");
                        Console.ReadKey();
                        return;

                    // ввод имени кошки
                    case 2:
                        Console.WriteLine("Введите имя кошки:");
                        var theName = Console.ReadLine();
                        theCat.Name = theName;
                        break;
                    
                    // задать цвет
                    case 3:
                        Console.WriteLine("Введите цвет здоровой кошки:");
                        var theHealthyColor = Console.ReadLine();

                        Console.WriteLine("Введите цвет больной кошки:");
                        var theSickColor = Console.ReadLine();

                        theCat.Color.HealthyColor = theHealthyColor;
                        theCat.Color.SickColor = theSickColor;
                        break;

                    // ударить
                    case 4: 
                        theCat.Punish();
                        Console.WriteLine("Вы ударили кошку.");
                        break;

                    // покормить
                    case 5:
                        theCat.Feed();
                        Console.WriteLine("Вы покормили кошку.");
                        break;

                } // ..switch(op)
                Console.WriteLine();
            }
        }
    }
}
