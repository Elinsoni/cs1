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

        public Сomplex ()  //создаем конструктор "по умлочанию"
        {

        }
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
    }
}
