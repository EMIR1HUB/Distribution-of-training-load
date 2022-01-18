using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Department_of_study
{
    class Program
    {
        static int state_menu;

        static void Main()
        {
            Menu.PrintMenu(ref state_menu);     //вызов меню 
            Load[] _load = Array.Empty<Load>();

            while (state_menu != 0)
            {
                DO.Do(ref _load, state_menu);  //вызов функции Do для определения действий 
                Menu.PrintMenu(ref state_menu);     //вызов меню
            }
            Console.WriteLine("-------------ПРОГРАММА ЗАВЕРШЕНА-------------");
            Console.ReadKey();
        }

        //добавление данных 
        public static void AddData(ref Load[] _data)
        {
            int num_of_added = _data.Length;

            Initials init;
            POS posit;
            TITLE title;
            LOAD load;
            PR prak;
            LC lect;
            load._group1 = "";
            load._group2 = "";

            Console.WriteLine("-------------ЗАПИСЬ ДАННЫХ-------------");
            //проверка массива
            if (num_of_added == 0)
            {
                //если данных нет, то выделяем новую память
                _data = new Load[num_of_added + 1];
                for (int i = 0; i < _data.Length; i++)
                    _data[i] = new Load();

                if (state_menu == 1 || state_menu == 10 || state_menu == 4)
                {
                    /*string a, b, c;
                    Initials temp = new Initials();*/
                    
                    //вводим нужные данные
                    Console.Write("# Введите фамилию: ");
                    init._surname = Console.ReadLine();
                    Console.Write("# Введите имя: ");
                    init._name = Console.ReadLine();
                    Console.Write("# Введите отчество: ");
                    init._patronymic = Console.ReadLine();

                    Console.Write("# Ученая степень: ");
                    posit._academ_degr = Console.ReadLine();
                    Console.Write("# Должность: ");
                    posit._position = Console.ReadLine();
                    Console.Write("# Стаж: ");
                    posit._standing = Convert.ToInt32(Console.ReadLine());

                    //добавление данных в массив данных
                    _data[0].DataEntry(init, posit);
                }

                if (state_menu == 1 || state_menu == 10 || state_menu == 7)
                {
                    Console.WriteLine("\n# ПРАКТИКА:");
                    prak._prak = "Практика";
                    Console.Write("# Введите название предмета: ");
                    title._title1 = Console.ReadLine();
                    Console.Write("# Количество часов: ");
                    title._hours1 = Convert.ToDouble(Console.ReadLine());

                    if (state_menu == 1 || state_menu == 10)
                    {
                        Console.Write("# Введите название группы: ");
                        load._group1 = Console.ReadLine();

                        //добавление данных в массив данных
                        _data[0].DataEntry(load);
                    }

                    Console.WriteLine("\n# ЛЕКЦИЯ:");
                    lect._lect = "Лекция";
                    Console.Write("# Введите название предмета: ");
                    title._title2 = Console.ReadLine();
                    Console.Write("# Количество часов: ");
                    title._hours2 = Convert.ToDouble(Console.ReadLine());

                    if (state_menu == 1 || state_menu == 10)
                    {
                        Console.Write("# Введите название группы: ");
                        load._group2 = Console.ReadLine();

                        //добавление данных в массив данных
                        _data[0].DataEntry(load);
                    }
                    //добавление данных в массив данных
                    _data[0].DataEntry(prak);
                    _data[0].DataEntry(lect);
                    _data[0].DataEntry(title);
                }
            }

            else
            {
                //если данные имеются, то необходимо их не потерять при выделении новой памяти

                //копируем массив данных с помощью метода Clone()
                //иначе создаем новый масс и каждому элем нового присвоить знаение старого масс
                //for(...) buf_data[i] = _data[i]
                Load[] buf_data = (Load[])_data.Clone();

                //новая память под текущий масс данных
                _data = new Load[num_of_added + 1]; //после данные все потеряются
                for (int i = 0; i < _data.Length; i++)
                    _data[i] = new Load();

                //копируем из временного в текущий обратно
                for (int i = 0; i < buf_data.Length; i++)
                    _data[i] = buf_data[i];

                if (state_menu == 1 || state_menu == 10 || state_menu == 4)
                {
                    //вводим нужные данные
                    Console.Write("# Введите фамилию: ");
                    init._surname = Console.ReadLine();
                    Console.Write("# Введите имя: ");
                    init._name = Console.ReadLine();
                    Console.Write("# Введите отчество: ");
                    init._patronymic = Console.ReadLine();

                    Console.Write("# Ученая степень: ");
                    posit._academ_degr = Console.ReadLine();
                    Console.Write("# Должность: ");
                    posit._position = Console.ReadLine();
                    Console.Write("# Стаж: ");
                    posit._standing = Convert.ToInt32(Console.ReadLine());

                    //добавление данных в массив данных
                    _data[num_of_added].DataEntry(init, posit);
                }

                if (state_menu == 1 || state_menu == 10 || state_menu == 7)
                {
                    Console.WriteLine("# ПРАКТИКА:");
                    prak._prak = "Практика";
                    Console.Write("# Введите название предмета: ");
                    title._title1 = Console.ReadLine();
                    Console.Write("# Количество часов: ");
                    title._hours1 = Convert.ToDouble(Console.ReadLine());

                    if (state_menu == 1 || state_menu == 10)
                    {
                        Console.Write("# Введите название группы: ");
                        load._group1 = Console.ReadLine();

                        //добавление данных в массив данных
                        _data[num_of_added].DataEntry(load);
                    }

                    Console.WriteLine("# ЛЕКЦИЯ:");
                    lect._lect = "Лекция";
                    Console.Write("# Введите название предмета: ");
                    title._title2 = Console.ReadLine();
                    Console.Write("# Количество часов: ");
                    title._hours2 = Convert.ToDouble(Console.ReadLine());

                    if (state_menu == 1 || state_menu == 10)
                    {
                        Console.Write("# Введите название группы: ");
                        load._group2 = Console.ReadLine();

                        //добавление данных в массив данных
                        _data[num_of_added].DataEntry(load);
                    }

                    //добавление данных в массив данных
                    _data[num_of_added].DataEntry(prak);
                    _data[num_of_added].DataEntry(lect);
                    _data[num_of_added].DataEntry(title);
                }

                //удаляем временный массив
                Array.Clear(buf_data, 0, buf_data.Length);
            }
            Console.Clear();
            Console.WriteLine("-------------ДАННЫЕ ДОБАВЛЕНЫ-------------");
        }

        //чтение из файла 
        public static void DataReading(ref Load[] _data)
        {
            string fileName;
            Console.WriteLine("-------------ЧТЕНИЕ ИЗ ФАЙЛА-------------");
            Console.Write("Введите название файла по умолчанию ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Main.txt: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            fileName = Console.ReadLine();

            //StreamReader read = new StreamReader(fileName);
            try
            {//проверка на открытость файла
                StreamReader read = new StreamReader(fileName);
                int number_of_data = Convert.ToInt32(read.ReadLine());
                int i = 0;  //индекс элемента массива данных
                int number_of_lines = 0; //номер строки, чтобы знать какую строку считываем

                //выделяем память
                _data = new Load[number_of_data];
                for (; i < _data.Length; i++)
                    _data[i] = new Load();
                i = 0;

                Initials init;
                POS posit;
                TITLE title;
                LOAD load;
                PR prac;
                LC lect;

                init._name = ""; init._surname = ""; init._patronymic = "";
                posit._academ_degr = ""; posit._position = ""; posit._standing = 0;
                title._title1 = ""; title._hours1 = 0;
                load._group1 = "";
                title._title2 = ""; title._hours2 = 0;
                load._group2 = "";
                prac._prak = ""; lect._lect = "";

                //считываем
                while (!read.EndOfStream)
                {
                    if (number_of_lines == 0)
                    {
                        init._surname = read.ReadLine(); //считываем и запоминаем строку
                        number_of_lines++;    //записываем нужные данные
                    }
                    else if (number_of_lines == 1)
                    {
                        init._name = read.ReadLine();
                        number_of_lines++;
                    }
                    else if (number_of_lines == 2)
                    {
                        init._patronymic = read.ReadLine(); //считываем строку
                        number_of_lines++;
                    }
                    else if (number_of_lines == 3)
                    {
                        posit._academ_degr = read.ReadLine();
                        number_of_lines++;
                    }
                    else if (number_of_lines == 4)
                    {
                        posit._position = read.ReadLine();
                        number_of_lines++;
                    }
                    else if (number_of_lines == 5)
                    {
                        posit._standing = Convert.ToInt32(read.ReadLine());
                        number_of_lines++;
                    }
                    else if (number_of_lines == 6)
                    {
                        prac._prak = read.ReadLine();
                        number_of_lines++;
                    }
                    else if (number_of_lines == 7)
                    {
                        title._title1 = read.ReadLine();
                        number_of_lines++;
                    }
                    else if (number_of_lines == 8)
                    {
                        title._hours1 = Convert.ToDouble(read.ReadLine());
                        number_of_lines++;
                    }
                    else if (number_of_lines == 9)
                    {
                        load._group1 = read.ReadLine();
                        number_of_lines++;
                    }
                    else if (number_of_lines == 10)
                    {
                        lect._lect = read.ReadLine();
                        number_of_lines++;
                    }
                    else if (number_of_lines == 11)
                    {
                        title._title2 = read.ReadLine();
                        number_of_lines++;
                    }
                    else if (number_of_lines == 12)
                    {
                        title._hours2 = Convert.ToDouble(read.ReadLine());
                        number_of_lines++;
                    }
                    else if (number_of_lines == 13)
                    {
                        load._group2 = read.ReadLine();

                        //добавляем 
                        _data[i].DataEntry(load);
                        _data[i].DataEntry(title);
                        _data[i].DataEntry(prac);
                        _data[i].DataEntry(lect);
                        _data[i].DataEntry(init, posit);

                        i++;//увеличение индекса элемента
                        number_of_lines = 0;
                    }
                }
                Console.WriteLine($"Данных: {_data.Length} сичтано из файла {fileName}");
                read.Close();   //закрытие файла
            }
            catch
            {//если случилась ошибка в блоке try
                Console.WriteLine($"# Ошибка при работе с файлом: {fileName}!!!");
            }
        }

        //вывод в коносль 
        public static void Print(Load[] _data)
        {
            int i = 0;
            Console.ForegroundColor = ConsoleColor.White;
            if (state_menu == 2)
            {
                string header = String.Format("\n|{0,-8}|{1,-36}|{2,-36}|{3,-23}|{4,-6}|",
                                        "Данные №", "ФИО", "Научная степень", "Должность", "Стаж");
                Console.WriteLine(header);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(new string('-', 115));
            }
            else if (state_menu == 5)
            {
                string header = String.Format("\n|{0,-8}|{1,-12}|{2,-50}|{3,-17}|",
                                        "Данные №", "Вид занятий", "Предмет", "Количество часов");
                Console.WriteLine(header);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(new string('-', 92));
            }
            else if (state_menu == 8)
            {
                string header = String.Format("\n|{0,-8}|{1,-36}|{2,-12}|{3,-50}|{4,-17}|{5,-20}|",
                                        "Данные №", "ФИО", "Вид занятий", "Предмет", "Количество часов", "Группа");
                Console.WriteLine(header);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(new string('-', 150));
            }
            foreach (Load d in _data)
            {
                i++;
                if (state_menu == 2)
                {
                    d.Print1(i);
                }
                else if (state_menu == 5)
                {
                    d.Print2(i);
                }
                else if (state_menu == 8)
                {
                    d.Print3(i);
                }
            }
        }

        //запись в файл 
        public static void SavingData(Load[] _data)
        {
            string fileName;

            Console.WriteLine("-------------ЗАПИСЬ В ФАЙЛ-------------");
            Console.Write("Введите название файла: ");
            fileName = Console.ReadLine();
            Console.Clear();

            //Для записи данных в поток используется класс StreamWriter
            try
            {
                StreamWriter record = new StreamWriter(fileName, false);
                //записываем данные в файл
                record.WriteLine(_data.Length);

                foreach (Load d in _data)      //8 - запись о нагрузки, 5 - запись о предмете, 2 - запись о преподавателе 
                {
                    if (state_menu == 2 || state_menu == 8)
                    {
                        record.WriteLine(d.GetInitials()._surname);
                        record.WriteLine(d.GetInitials()._name);
                        record.WriteLine(d.GetInitials()._patronymic);

                        record.WriteLine(d.GetPOS()._academ_degr);
                        record.WriteLine(d.GetPOS()._position);
                        record.WriteLine(d.GetPOS()._standing);
                    }

                    if (state_menu == 8 || state_menu == 5)
                    {
                        record.WriteLine(d.GetPrak()._prak);
                        record.WriteLine(d.GetITEM()._title1);
                        record.WriteLine(d.GetITEM()._hours1);
                        if (state_menu == 8)
                        {
                            record.WriteLine(d.GetLoad()._group1);
                        }

                        record.WriteLine(d.GetLect()._lect);
                        record.WriteLine(d.GetITEM()._title2);
                        record.WriteLine(d.GetITEM()._hours2);
                        if (state_menu == 8)
                        {
                            record.WriteLine(d.GetLoad()._group2);
                        }
                    }
                }
                record.Close();
                Console.WriteLine($"Данные: {_data.Length} записанно в файл: {fileName}");
                
            }
            catch
            {
                //если вышла ошибка
                Console.WriteLine($"# Ошибка при работа с файлом: {fileName} !!!");
            }
        }

        //изменение данных 
        public static void DataChange(Load[] _data)
        {
            Console.WriteLine("-------------ИЗМЕНЕНИЕ ДАННЫХ-------------");
            Console.WriteLine($"Введите необходимый элемент (от 1 до {_data.Length}): ");
            int n = Convert.ToInt32(Console.ReadLine());
            n--;    //так как вводим от 1

            Console.Clear();

            //проверка на правильность ввода
            if (n >= 0 && n < _data.Length)
            {
                Initials init;
                POS posit;
                TITLE title;
                LOAD load;

                load._group1 = "";
                load._group2 = "";

                if (state_menu == 9 || state_menu == 3)
                {
                    //вводим нужные данные
                    Console.Write("# Введите фамилию: ");
                    init._surname = Console.ReadLine();
                    Console.Write("# Введите имя: ");
                    init._name = Console.ReadLine();
                    Console.Write("# Введите отчество: ");
                    init._patronymic = Console.ReadLine();

                    Console.Write("# Ученая степень: ");
                    posit._academ_degr = Console.ReadLine();
                    Console.Write("# Должность: ");
                    posit._position = Console.ReadLine();
                    Console.Write("# Стаж: ");
                    posit._standing = Convert.ToInt32(Console.ReadLine());

                    _data[n].DataEntry(init, posit);
                }

                if (state_menu == 9 || state_menu == 6)
                {
                    Console.WriteLine("# ПРАКТИКА");
                    Console.Write("# Введите название предмета: ");
                    title._title1 = Console.ReadLine();
                    Console.Write("# Количество часов: ");
                    title._hours1 = Convert.ToDouble(Console.ReadLine());
                    if (state_menu == 9)
                    {
                        Console.Write("# Введите название группы: ");
                        load._group1 = Console.ReadLine();

                        _data[n].DataEntry(load);
                    }

                    Console.WriteLine("# ЛЕКЦИЯ");
                    Console.Write("# Введите название предмета: ");
                    title._title2 = Console.ReadLine();
                    Console.Write("# Количество часов: ");
                    title._hours2 = Convert.ToDouble(Console.ReadLine());
                    if (state_menu == 9)
                    {
                        Console.Write("# Введите название группы: ");
                        load._group2 = Console.ReadLine();

                        _data[n].DataEntry(load);
                    }
                    _data[n].DataEntry(title);
                }

                Console.Clear();
                Console.WriteLine($"# Данные элемента: {n + 1} изменены!!!");
            }
            else
                Console.WriteLine("-------------НОМЕР ВВЕДЕН НЕ ВЕРНО-------------");
        }

        //удаление данных нагрузка 
        public static void DeleteData(ref Load[] _data)
        {
            Console.WriteLine("-------------УДАЛЕНИЕ ДАННЫХ-------------");
            Console.WriteLine($"Введите необходимый элемент (от 1 до {_data.Length}): ");
            int n = Convert.ToInt32(Console.ReadLine());
            n--;    //так как вводим от 1

            //проверка на правлиность ввода
            if (n >= 0 && n < _data.Length)
            {

                Load[] buf_data = (Load[])_data.Clone();

                //выделяем новую память для текущего массива
                int new_size = _data.Length - 1;
                _data = new Load[new_size];     //после данные сотруться 

                //считываем данные из временного массива в основной кроме удаляемого
                int d = 0;
                for (int i = 0; i < buf_data.Length; i++)
                {
                    if (i != n)
                    {
                        _data[d] = buf_data[i];
                        d++;
                    }
                }

                Console.Clear();
                Console.WriteLine($"# Данные №{n + 1} удален");

                //удаление временного массива
                Array.Clear(buf_data, 0, buf_data.Length);
            }
            else
                Console.WriteLine("-------------НОМЕР ВВЕДЕН НЕ ВЕРНО-------------");
        }

        //сортировка данных нашрузки 
        public static void DataSorting(Load[] _data)
        {
            //временный объект класса
            Load buf;

            Console.Write("Выберите по какому полю сортировать: \n" +
                "1 - По фамили\n" +
                "2 - По имени\n" +
                "3 - По отчеству\n" +
                "4 - По предметам практики\n" +
                "5 - По предметам лекции\n" +
                "6 - По группам практики\n" +
                "7 - По группам лекции\n" +
                "Ваш выбор: ");

            int way = Convert.ToInt32(Console.ReadLine());

            switch (way)
            {
                //Сортировка методом пузырька, сравниваем текущий с последующим
                case 1:
                    //по фамилии
                    for (int i = 0; i < _data.Length; i++)
                    {
                        for (int j = i + 1; j < _data.Length; j++)
                        {
                            //сравниваем две строки 
                            int result = String.Compare(_data[i].GetInitials()._surname, _data[j].GetInitials()._surname);
                            if (result > 0)
                            {
                                //меняем местами, если нужно
                                buf = _data[i];
                                _data[i] = _data[j];
                                _data[j] = buf;
                            }
                        }
                    }

                    Console.Clear();
                    Console.WriteLine("-------------ДАННЫЕ ОТСОРТИРОВАННЫЙ ПО \"ФАМИЛИИ\"-------------");
                    break;

                case 2:
                    //по имени
                    for (int i = 0; i < _data.Length; i++)
                    {
                        for (int j = i + 1; j < _data.Length; j++)
                        {
                            //сравниваем две строки 
                            int result = String.Compare(_data[i].GetInitials()._name, _data[j].GetInitials()._name);
                            if (result > 0)
                            {
                                //меняем местами, если нужно
                                buf = _data[i];
                                _data[i] = _data[j];
                                _data[j] = buf;
                            }
                        }
                    }

                    Console.Clear();
                    Console.WriteLine("-------------ДАННЫЕ ОТСОРТИРОВАННЫЙ ПО \"ИМЕНИ\"-------------");
                    break;

                case 3:
                    //по отчеству
                    for (int i = 0; i < _data.Length; i++)
                    {
                        for (int j = i + 1; j < _data.Length; j++)
                        {
                            //сравниваем две строки 
                            int result = String.Compare(_data[i].GetInitials()._patronymic, _data[j].GetInitials()._patronymic);
                            if (result > 0)
                            {
                                //меняем местами, если нужно
                                buf = _data[i];
                                _data[i] = _data[j];
                                _data[j] = buf;
                            }
                        }
                    }

                    Console.Clear();
                    Console.WriteLine("-------------ДАННЫЕ ОТСОРТИРОВАННЫЙ ПО \"ОТЧЕСТВУ\"-------------");
                    break;

                case 4:
                    //по предметам
                    for (int i = 0; i < _data.Length; i++)
                    {
                        for (int j = i + 1; j < _data.Length; j++)
                        {
                            //сравниваем две строки
                            int result = String.Compare(_data[i].GetITEM()._title1, _data[j].GetITEM()._title1);
                            if (result > 0)
                            {
                                //меняем местами, если нужно
                                buf = _data[i];
                                _data[i] = _data[j];
                                _data[j] = buf;
                            }
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("-------------ДАННЫЕ ОТСОРТИРОВАННЫЙ ПО \"ПРЕДМЕТАМ\"-------------");
                    break;
                case 5:
                    //по предметам
                    for (int i = 0; i < _data.Length; i++)
                    {
                        for (int j = i + 1; j < _data.Length; j++)
                        {
                            //сравниваем две строки
                            int result = String.Compare(_data[i].GetITEM()._title2, _data[j].GetITEM()._title2);
                            if (result > 0)
                            {
                                //меняем местами, если нужно
                                buf = _data[i];
                                _data[i] = _data[j];
                                _data[j] = buf;
                            }
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("-------------ДАННЫЕ ОТСОРТИРОВАННЫЙ ПО \"ПРЕДМЕТАМ\"-------------");
                    break;
                case 6:
                    //по группам
                    for (int i = 0; i < _data.Length; i++)
                    {
                        for (int j = i + 1; j < _data.Length; j++)
                        {
                            //сравниваем две строки
                            int result = String.Compare(_data[i].GetLoad()._group1, _data[j].GetLoad()._group1);
                            if (result > 0)
                            {
                                //меняем местами, если нужно
                                buf = _data[i];
                                _data[i] = _data[j];
                                _data[j] = buf;
                            }
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("-------------ДАННЫЕ ОТСОРТИРОВАННЫЙ ПО \"ГРУППАМ\"-------------");
                    break;
                case 7:
                    //по группам
                    for (int i = 0; i < _data.Length; i++)
                    {
                        for (int j = i + 1; j < _data.Length; j++)
                        {
                            //сравниваем две строки
                            int result = String.Compare(_data[i].GetLoad()._group2, _data[j].GetLoad()._group2);
                            if (result > 0)
                            {
                                //меняем местами, если нужно
                                buf = _data[i];
                                _data[i] = _data[j];
                                _data[j] = buf;
                            }
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("-------------ДАННЫЕ ОТСОРТИРОВАННЫЙ ПО \"ГРУППАМ\"-------------");
                    break;
                default:
                    Console.WriteLine("-------------НОМЕР ВВЕДЕН НЕ ВЕРНО-------------");
                    break;
            }
        }
    }
}
