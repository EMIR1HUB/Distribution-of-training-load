using System;

namespace Department_of_study
{
    //структура ФИО
    public struct Initials
    {
        public string _surname,
            _name, _patronymic;

        public override string ToString()
        {
            return $"{_surname} {_name} {_patronymic}";
        }
    }

    //структура науч.степение, должности и стаж
    struct POS
    {
        public string
            _academ_degr, _position;
        public int _standing;
    }

    //класс Дата
    class Teacher
    {
        //поля класса
        protected Initials init;
        protected POS posit;

        //метод класса
        public Teacher() { } //конструктор по усмолчанию создает пустой объект

        public Teacher(Initials init, POS posit)
        {
            this.init = init;
            this.posit = posit;
        }

        public void DataEntry(Initials init, POS posit)   //метод ввод данных
        {
            this.init = init;
            this.posit = posit;
        }

        //препоределение метода с помощью полиморфизма virtual
        public void Print1(int i) //вывод данных
        {
            string output;
            output = String.Format("|{0,-8}|{1,-36}|{2,-36}|{3,-23}|{4,-6}|\n{5}",
                                       i, init.ToString(), posit._academ_degr, 
                                       posit._position, posit._standing, new string('-', 115));
            Console.WriteLine(output);
        }
        //так как поля закрыты от внешнего доступа, необходим методы, которые смогут выдать инфу о полях
        public Initials GetInitials() { return init; } //выход из класса 
        public POS GetPOS() { return posit; }
    }

}
