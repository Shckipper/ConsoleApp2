using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Calculator
    {
        private int Add(int a, int b)
        {
            return a + b;
        }

        public string Greeting(string name)
        {
            return $"Привет, {name}!";
        }

        public void ShowDemo()
        {
            int sum = Add(5, 10);
            Console.WriteLine($"Сумма чисел: {sum}");
            Console.WriteLine(Greeting("Иван"));
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            calculator.ShowDemo();
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
