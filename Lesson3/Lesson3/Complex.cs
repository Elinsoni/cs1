using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Complex
    {
        private double _Re; //орпеделяем поле объекта комлексное чило - вещественную часть
        private double _Im; // определяем поле объекта комлексное число - мнимую часть (по треб-м инкапсуляции делаем их приват)

        /*public Сomplex ()  //создаем конструктор "по умлочанию"
        {

        }
        */
        public Complex(double Re, double Im)  //конструктор который принимает в ка-ве параметров 2 числа
        {
            _Re = Re;
            _Im = Im;
        }

        public double GetRe()  //метод, возвращает значение действительного поля комплексного числа
        {
            return _Re;
        }

        public void SetRe(double value) //процедура установки Re
        {
            _Re = value;
        }
        public double GetIm()
        {
            return _Im;
        }
        public void SetIm (double value) //процедура установки Im
        {
            _Im = value;
        }

        public double Abs     //gлучение абсолютного значения числа
        {
            get
            {
                return Math.Sqrt(_Re * _Re + _Im * _Im);
            }
        }
        public static Complex operator +(Complex a, Complex b) // определяем оператор сложения "+"
        {
            return new Complex(a._Re + b._Re, a._Im + b._Im);
        }
         public static Complex operator -(Complex a, Complex b) //определяем оператор вычитания "-" ЗАДАНИЕ 1 б
        {
            return new Complex(a._Re - b._Re, a._Im - b._Im);
        }
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a._Re * b._Re, a._Im * b._Im);
        }
    }
}
