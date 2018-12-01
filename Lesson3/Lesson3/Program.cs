using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
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
        public Complex Minus (Complex x) //добавляем 
        {
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex z = new Complex(10, 15);
            var re = z.GetRe();
            z.SetIm(100);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
