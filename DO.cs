using System;

namespace Department_of_study
{
    class DO:Program    //действия меню
    {
        public DO() { }

        public static void Do(ref Load[] _load, int state_menu)
        {

            int action;
            Console.ForegroundColor = ConsoleColor.Cyan;
            switch (state_menu)
            {
                case 0:
                    //поле завершение работы, удалим массив данных
                    Array.Clear(_load, 0, _load.Length);
                    break;
                case 1:
                    Console.Clear();    //очистка консоли

                    //выбор способа ввода даных
                    Console.Write("1 - Ввод вручную.\n" +
                        "2 - Чтение из файла.\n" +
                        "Ваш выбор: ");
                    action = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (action == 1)
                    {
                        //ввод вручную 
                        AddData(ref _load);
                    }
                    else if (action == 2)
                    {
                        //чтение из файла
                        DataReading(ref _load);
                    }
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine(); 
                    Console.Clear(); 
                    break;
                case 2:
                    Console.Clear();    

                    if (_load.Length > 0)
                    {
                        //выбор способа ввода даных
                        Console.Write("1 - Вывод в консоль.\n" +
                            "2 - Запись в файл.\n" +
                            "Ваш выбор: ");
                        action = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (action == 1)
                        {
                            //вывод вручную 
                            Print(_load);
                        }
                        else if (action == 2)
                        {
                            //запись в файл
                            SavingData(_load);
                        }
                    }
                    else
                        Console.WriteLine("-------------ДАННЫЕ ПУСТЫ-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();

                    if (_load.Length > 0)
                    {
                        DataChange(_load);
                    }
                    else
                        Console.WriteLine("-------------ДАННЫЕ ПУСТЫ-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();

                    if (_load.Length > 0)
                    {
                        AddData(ref _load);
                    }
                    else
                        Console.WriteLine("-------------ДАННЫЕ ПУСТЫ-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear(); 

                    if (_load.Length > 0)
                    {
                        Console.Write("1 - Вывод в консоль.\n" +
                            "2 - Запись в файл.\n" +
                            "Ваш выбор: ");
                        action = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (action == 1)
                        {
                            //вывод вручную 
                            Print(_load);
                        }
                        else if (action == 2)
                        {
                            //запись в файл
                            SavingData(_load);
                        }
                    }
                    else
                        Console.WriteLine("-------------ДАННЫЕ ПУСТЫ-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 6:
                    Console.Clear();

                    if (_load.Length > 0)
                    {
                        DataChange(_load);
                    }
                    else
                        Console.WriteLine("-------------ДАННЫЕ ПУСТЫ-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 7:
                    Console.Clear();

                    if (_load.Length > 0)
                    {
                        AddData(ref _load);
                    }
                    else
                        Console.WriteLine("-------------ДАННЫЕ ПУСТЫ-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 8:
                    Console.Clear();

                    if (_load.Length > 0)
                    {
                        Console.Write("1 - Вывод в консоль.\n" +
                            "2 - Запись в файл.\n" +
                            "Ваш выбор: ");
                        action = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (action == 1)
                        {
                            Print(_load);
                        }
                        else if (action == 2)
                        {
                            SavingData(_load);
                        }
                    }
                    else
                        Console.WriteLine("-------------ДАННЫЕ ПУСТЫ-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 9:
                    Console.Clear();

                    if (_load.Length > 0)
                    {
                        DataChange(_load);
                    }
                    else
                        Console.WriteLine("-------------ДАННЫЕ ПУСТЫ-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 10:
                    Console.Clear();

                    if (_load.Length > 0)
                    {
                        AddData(ref _load);
                    }
                    else
                        Console.WriteLine("-------------ДАННЫЕ ПУСТЫ-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 11:
                    Console.Clear();

                    if (_load.Length > 0)
                    {
                        DeleteData(ref _load);
                    }
                    else
                        Console.WriteLine("-------------ДАННЫЕ ПУСТЫ-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 12:
                    Console.Clear();

                    if (_load.Length > 0)
                    {
                        DataSorting(_load);
                    }
                    else
                        Console.WriteLine("-------------ДАННЫЕ ПУСТЫ-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("-------------ПУНКТ МЕНЮ ВЫБРАН НЕ ВЕРНО-------------");
                    Console.WriteLine($"\n\nВведите Enter для продолжения...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}
