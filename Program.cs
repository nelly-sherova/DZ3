using System;

namespace dz3day
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задание 1 ");
                Console.WriteLine("Сделано :)");
            }
            {
                Console.WriteLine("Задание 2 ");
                int a, b;
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToInt32(Console.ReadLine());
                if (a != b)
                {
                   a = (a>b)?a:b;
                   b = (b>a)?b:a;
                   Console.WriteLine($"New a is: {a}");
                   Console.WriteLine($"New b is: {b}");
                }
                else if (a == b)
                {
                    a = 0;
                    b = 0;
                     Console.WriteLine($"New a is: {a}");
                   Console.WriteLine($"New b is: {b}");
                }
            }
            {
                Console.WriteLine("Задание 3 ");
                double operand1, operand2;
                Console.Write("Введите первое число: ");
                operand1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число: ");
                operand2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите знак арифметической оперции: ");
                string sign = Console.ReadLine();
                switch (sign)
                {
                    case "+":
                    {
                        Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
                        break;
                    }
                    case "-":
                    {
                        Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
                        break;
                    }
                    case "*" :
                    {
                        Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
                        break;
                    }
                    case "/":
                    {
                        if (operand2 != 0)
                        {
                            Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");
                            
                        }
                        else
                        {
                            Console.WriteLine("На 0 делить нельзя!!!");
                        }
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Вы ввели некоректный знак!!");
                        break;
                    }
                }

            }
            {
                Console.WriteLine("Задание 4");
                int a;
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a>=0 && a<=14)
                {
                    Console.WriteLine("Ваше число попадает в отрезок [0;14]");
                }
                else if (a>=15 && a<=35)
                {
                    Console.WriteLine("Ваше число попадает в отрезок [15;35]");
                }
                else if (a>=36 && a<=50)
                {
                    Console.WriteLine("Ваше число попадает в отрезок [36;50]");
                }
                else if (a>=50 && a<=100)
                {
                    Console.WriteLine("Ваше число попадает в отрезок [50;100]");
                }
                else
                {
                    Console.WriteLine("Ваше число не принадлежит не одному из 4 отрезков!!");
                }
            }
        }
    }
}
