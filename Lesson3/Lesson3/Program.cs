using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    /*
    #region
    /// <summary>
    /// описываем структуру комплексного числа Задание 1а
    /// </summary>
    struct Complex  // описываем структуру
    {
        public double im;
        public double re;
        public Complex Plus (Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        } 
        public Complex Minus (Complex x) //добавляем операцию вычитания в структуру
        {
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        } 
        #endregion  

    }
    */
    class Program
    {
        static void Main(string[] args)
        {
            Complex z = new Complex(10, 15);
            var re = z.GetRe();
            z.SetIm(100);

            Console.WriteLine(z);
            Console.ReadLine();

            var d = new Complex(53, 67);
            var n = z - d;
            Console.WriteLine(n);  //Демонстрация результата работы оператора вычитания класса комплекс
            Console.ReadLine();

            var pr = z * d; //демонстрация работы оператора умножения класса комплекс
            Console.WriteLine(pr);
            Console.ReadLine();
        }
    }
}
