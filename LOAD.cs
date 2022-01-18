using System;

namespace Department_of_study
{
    //структура преподаватель предмет группа 
    struct LOAD
    {
        public string _group1;
        public string _group2;
    }

    class Load : Item
    {
        //поля класса

        protected LOAD load;

        //метод класса
        public Load() { } //конструктор по усмолчанию создает пустой объект

        public Load(LOAD load)
        {
            this.load = load;
        }

        public void DataEntry(LOAD load)   //метод ввод данных
        {
            this.load = load;
        }

        //препоределение метода с помощью полиморфизма override
        public void Print3(int i) //вывод данных
        {
            string output;
            output = String.Format("|{0,-8}|{1,-36}|{2,-12}|{3,-50}|{4,-17}|{5,-20}|\n{6}\n|{7,-45}|{8,-12}|{9,-50}|{10,-17}|{11,-20}|\n{12}",
                                       i, init.ToString(), prak._prak, item._title1, item._hours1, load._group1,
                                       new string('-', 150), ' ', lect._lect, item._title2, item._hours2, load._group2, new string('-', 150));
            Console.WriteLine(output);
        }
        //так как поля закрыты от внешнего доступа, необходим методы, которые смогут выдать инфу о полях
        public LOAD GetLoad() { return load; } //выход из класса 
    }
}
