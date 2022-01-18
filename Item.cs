using System;

namespace Department_of_study
{
    //структура предметы
    struct TITLE
    {
        public string _title1;
        public double _hours1;
        public string _title2;
        public double _hours2;
    }

    class Item : Prak_or_Lec
    {
        //поля класса
        protected TITLE item;


        //метод класса
        public Item() { } //конструктор по усмолчанию создает пустой объект

        public Item(TITLE item)
        {
            this.item = item;
        }

        public void DataEntry(TITLE item)   //метод ввод данных
        {
            this.item = item;
        }

        //препоределение метода с помощью полиморфизма override
        public void Print2(int i) //вывод данных
        {
            string output;
            output = String.Format("|{0,-8}|{1,-12}|{2,-50}|{3,-17}|\n{4}\n|{5,-8}|{6,-12}|{7,-50}|{8,-17}|\n{9}",
                                       i, prak._prak, item._title1, item._hours1, new string('-', 92),
                                       ' ', lect._lect, item._title2, item._hours2, new string('-', 92));
            Console.WriteLine(output);
        }
        //так как поля закрыты от внешнего доступа, необходим методы, которые смогут выдать инфу о полях
        public TITLE GetITEM() { return item; } //выход из класса 
    }
}
