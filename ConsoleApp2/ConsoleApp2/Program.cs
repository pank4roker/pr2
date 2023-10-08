using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Треугольник задан координатами своих вершин.Найти периметр и площадь треугольника.
            /*Write("Введите координаты вершин А: \nx =");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Write("y= ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Write("Введите координаты вершин B: \nx=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Write("y= ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Write("Введите координаты вершин C: \nx=");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Write("y= ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double P = 0;

            P += Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));  
            P += Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));  
            P += Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));  

            WriteLine($"\nПериметр треугольника ABC = {P:f2}");

            double p = P / 2;  

            double S = Math.Sqrt(p *
                (p - Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))) *
                (p - Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2))) *
                (p - Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2))));  

            Write($"\nПлощадь треугольника ABC = {S:f2}");*/
            //Задание 2
            //Стоимость поездки на автомобиле
            //(ввод: s – расстояние, b – расход бензина на 100 км, c - цена бензина за 1 литр).
            /*Write("Введите расстояние S= ");
            double S = Convert.ToDouble(Console.ReadLine());
            Write("Введите расход бензина на 100 км b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Write("Введите цену бензина за 1 литр с= ");
            double C = Convert.ToDouble(Console.ReadLine());
            WriteLine($"СТоимость поездки составила {(S/100)* b * C} руб.");
            ReadKey();*/
            //3 
            Write("Введите цену за 1 кг конфет = ");
            double sweets = Convert.ToDouble(Console.ReadLine());
            Write("Введите цену за 1 кг печенья = ");
            double cookies = Convert.ToDouble(Console.ReadLine());
            Write("Введите цену за 1 кг яблок = ");
            double apples = Convert.ToDouble(Console.ReadLine());

            Write("\nВведите x кг конфет = ");
            double X = Convert.ToDouble(Console.ReadLine());
            Write("\nВведите x кг печенья = ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Write("\nВведите x кг яблок = ");
            double Z = Convert.ToDouble(Console.ReadLine());

            WriteLine($"\nСтоимость всей покупки составила {(sweets * X) + (cookies * Y) + (apples * Z)} руб.");
            ReadKey();



        }
    }
}
