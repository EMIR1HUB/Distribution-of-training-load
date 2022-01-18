using System;

namespace Department_of_study
{
    //структура предметы
    struct PR
    {
        public string _prak;
    }

    struct LC
    {
        public string _lect;
    }

    class Prak_or_Lec : Teacher
    {
        //поля класса
        protected PR prak;
        protected LC lect;


        //метод класса
        public Prak_or_Lec() { } //конструктор по усмолчанию создает пустой объект

        public Prak_or_Lec(PR prak, LC lect)
        {
            this.prak = prak;
            this.lect = lect;
        }

        public void DataEntry(PR prak)   //метод ввод данных
        {
            this.prak = prak;
        }

        public void DataEntry(LC lect)
        {
            this.lect = lect;
        }

        //препоределение метода с помощью полиморфизма override
        public void Print_(bool temp) //вывод данных
        {
            if (temp)
                Console.WriteLine($"Практика: {prak._prak}");
            else
                Console.WriteLine($"Лекция: {lect._lect}");
        }
        //так как поля закрыты от внешнего доступа, необходим методы, которые смогут выдать инфу о полях
        public PR GetPrak() { return prak; } //выход из класса 
        public LC GetLect() { return lect; } //выход из класса 
    }
}
