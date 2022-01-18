using System;

namespace Department_of_study
{
    class Menu
    {

        public Menu() { }   //конструктор по усмолчанию создает пустой объект

        public static void PrintMenu(ref int state_menu)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(new string('#', 71)+"\n" +
                "#####                                                             #####\n" +
                "#####               РАСПРЕДЕЛЕНИЕ УЧЕБНОЙ НАГРУЗКИ                #####\n" +
                "#####                                                             #####\n" +
                new string('#', 71) + "\n\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 - Ввести данные\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{new string('-', 103)}\n" +
                "|          ПРЕПОДАВАТЕЛИ          |             ПРЕДМЕТЫ            |             НАГРУЗКАЛ           |" +
                $"\n{new string('-', 103)}\n" +
                "|2 - Вывод данных о преподавателях|5 - Вывод данных о предметах     |8 - Вывод данных                 |\n" +
                "|3 - Изменение данных             |6 - Изменение данных             |9 - Изменение данных             |\n" +
                "|4 - Добавление данных            |7 - Добавление данных            |10 - Добавление данных           |\n" +
                "|                                 |                                 |11 - Удаление данных             |\n" +
                "|                                 |                                 |12 - Сортировка данных           |\n" +
                $"{new string('-',103)}\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("0 - Выход из программы\n");

            Console.Write("Ваш выбор: ");
            state_menu = Convert.ToInt32(Console.ReadLine());
        }
    }
}
