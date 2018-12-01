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


            #region
            /// <summary>
            /// Задание 2 С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран исп TryParse
            /// </summary>
            /// <param name="n"></param>
             void Summa(int number)
            {
                int sum = 0;
                do //зажаем цикл который будет работать пока введенное число с клавиатуры будет 0
                {

                    if (number > 0 && number % 2 != 0) // если введенное число положительное и нечетное (при делении на 2 с отбрасыванием целой части получем не 0)
                        sum = sum + number;
                    Console.WriteLine("Введите число: "); // затем запрашиваем следущее число для ввода с клавиатуры для которого наш цыкл повторится
                    number = Convert.ToInt32(Console.ReadLine());
                    /*WriteandCheck();*/
                } while (number != 0);
                Console.WriteLine("Сумма нечетных, положительных чисел = {0}", sum); //вывод результата сложения, подходящих под условие введенных цифр
                Console.ReadLine();
            }
            #endregion

           /* void WriteandCheck()
            {

                Console.WriteLine("Введите число: "); // запрашиваем ввод числа с клавиатуры
                string usernumber;
                usernumber =Int32.TryParse(Console.ReadLine()); // кладем запрошенное число в переменную
                if (usernumber==0)
                {
                    throw new DivideByZeroException("Введены не коректные данные ");
                }
                
            }*/
            Console.WriteLine("Введите число: "); // запрашиваем ввод числа с клавиатуры

            int usernumber = Convert.ToInt32(Console.ReadLine()); // кладем запрошенное число в переменну

            Summa(usernumber); // запускаем метод сложения положительных, нечетных чисел


        }
    }
}
