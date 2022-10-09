// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_10
{
    class Program
    {
        public static void Kvadrat(double a, double b, double c)
        {
            double D = (a * a - 4 * a * c);
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D) / 2 * a);
                double x2 = (-b - Math.Sqrt(D) / 2 * a);
                Console.WriteLine($"x1={x1}, x2={x2}");
            }
            else if (D == 0)
            {
                double x1 = (-b + Math.Sqrt(D) / 2 * a);
                Console.WriteLine($"x1={x1}");

            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }
        public static void Sort_pyzyr(int[] array)
        {
            for (int i=0; i < array.Length; i++)
                for(int j=0; j<array.Length; j++)
                    if (array[i] > array[j])
                    {
                        int k=array[i];
                        array[i]=array[j];
                        array[j]=k;
                    }
            Console.WriteLine();
            Console.WriteLine("Сортированный массив:");
            for (int i=0; i < array.Length; i++)
                Console.WriteLine(array[i]+" ");
        }
        public static void Sortirovka(ref int pr, out double sr, ref int sum, params int[] arrayy)
        {
            for (int i=0; i < arrayy.Length; i++)
                sum=sum+arrayy[i];
            for (int i=0; i < arrayy.Length; i++)
                pr=pr*arrayy[i];
            sr=sum/arrayy.Length;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1, решение квадратного уравнения");
            Console.WriteLine("Введите коэффиценты a,b,c");
            double ko1 = double.Parse(Console.ReadLine());
            double ko2 = double.Parse(Console.ReadLine());
            double ko3 = double.Parse(Console.ReadLine());
            Kvadrat(ko1, ko2, ko3);
            Console.WriteLine();
            Console.WriteLine("Задание 2. Массив из 20 чисел");
            int[] massiv = new int[20];
            Random rand = new Random();
            int m1 = 0;
            int m2 = 0;
            for (int i = 0; i < massiv.Length; i++)
                massiv[i] = rand.Next();
            for (int i = 0; i < massiv.Length; i++)
                Console.Write(massiv[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Введите 2 числа из массива");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] == a)

                    m1 = i;

                else if (massiv[i] == b)

                    m2 = i;

            }
            int d = massiv[m1];
            massiv[m1] = massiv[m2];
            massiv[m2] = d;
            Console.WriteLine();
            Console.WriteLine("Новый массив");
            for (int i = 0; i < massiv.Length; i++)
                Console.Write(massiv[i] + " ");
            Console.WriteLine("Задание 3. Сортровка массива");
            Console.WriteLine("Массив:");
            int[] array = { 1, 14, 5, 54, 546, 654, 34 };
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i] + " ");
            Sort_pyzyr(array);

            Console.WriteLine("Задание 4. Массив");
            Console.WriteLine("Введите число элементов массива:");
            int j=int.Parse(Console.ReadLine());
            int[] arrayy = new int[j];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < arrayy.Length; i++)
            { 
              arrayy[i] = int.Parse(Console.ReadLine()); 
            }
            int sum = 0;
            int pr = 1;
            double sr;
            Sortirovka(ref pr, out sr, ref sum, arrayy);
            Console.WriteLine();
            Console.WriteLine($"Сумма={sum}, Произведение={pr}, Среднее арифметическое={sr}");

           
           

        }
    }
}