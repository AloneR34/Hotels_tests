// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

public class Methods
{
    static public void Main()
    {
        string[] cities = { "Москва", "Воронеж", "Волгоград", "Вологда" };
        Console.WriteLine("Задание номер 1:");
        Console.WriteLine(split_cities(cities));
        Console.WriteLine("Задание номер 2:");
        Console.WriteLine(raund(27));
        Console.WriteLine(raund(27.8));
        Console.WriteLine(raund(41.7));
        Console.WriteLine("Задание номер 3:");
        declination(0);
        declination(41);
        declination(2);
        Console.WriteLine("Задание номер 4:");
        simple_number(16);
        Console.WriteLine("Задание номер 5:");
        int[] n = { 7, 17, 1, 9, 1, 17, 56, 56, 23 } ;
        int[] b = { 56, 17, 17, 1, 23, 34, 23, 1, 8, 1 };
        int[] a = couples(n,b);
 
        Console.WriteLine();
        Console.WriteLine("Задание номер 6:");
        multiplication_table(5);

    }

    //Написание и отладка метода 15 минут
    public static string split_cities(string[] cities)
    {
        string result = cities[0];
        int i = 1;
        int N = cities.Length;
        for (i = 1; i < N; i++)
        {
            result = result + ", " + cities[i];
        }
        result = result + ".";
        return result;
    }
    // 12 минут + вывод 2 минуты
    public static string raund(double i)
    {
        double result;
        double n = i % 5;

        if (n < 2.5)
        {
            result = i - n;
        }
        else
        {
            result = i + (5 - n);
        }
        return result.ToString();
    }

    //16 минут
    public static void declination(int i)
    {
        int n = 0;
        if (i > 11)
        {
            n = i % 10;
        }
        if (i == 1 || n == 1)
        {
            Console.WriteLine(i.ToString() + " компьютер");
        }
        else if (i == 2 || i == 3 || i == 4 || n == 2 || n == 3 || n == 4)
        {
            Console.WriteLine(i.ToString() + " компьютера");
        }
        else
        {
            Console.WriteLine(i.ToString() + " компьютеров");
        }

    }

    //Минут 26
    public static void simple_number(int number)
    {
        bool simple = true;
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                simple = false;
                break;
            }
        }
        if (simple)
        {
            Console.WriteLine(number.ToString() + " - число простое");
        }
        else
        {
            Console.WriteLine(number.ToString() + " - число не простое");
        }

    }

    // 1,5 часа  - Не верно трактовала условия задачи
    public static int[] couples(int[] a, int[] b)
    {
        var intersect = a.Intersect(b);
        var List1 = new List<int>();
        int[] p = intersect.ToArray();
        for(int k = 0; k < p.Length; k++)
            {
                List1.Add(p[k]);
            }
         var dist1 = a.Distinct();
        int[] h = dist1.ToArray();
        var dist2 = b.Distinct();
        int[] v = dist2.ToArray();
        var cuple = a.Where(x => a.Count(y => x == y) > 1).Distinct();
        int[] cuple_mass = cuple.ToArray();
        var cuple2 = b.Where(x => b.Count(y => x == y) > 1).Distinct();
        int[] cuple_mass2 = cuple2.ToArray();

        var arrayOut = new int[cuple_mass2.Length + cuple_mass.Length];
        cuple_mass2.CopyTo(arrayOut, 0);
        cuple_mass.CopyTo(arrayOut, cuple_mass.Length);

        var couples = arrayOut.Where(x => arrayOut.Count(y => x == y) > 1).Distinct();
        int[] couples_mass = couples.ToArray();

        for (int l = 0; l < couples_mass.Length; l++)
            Console.Write(couples_mass[l] + " ");
        Console.WriteLine();


        return couples_mass;
    }


    // 35 минут
    public static void multiplication_table(int number)
    {
        int[,] arr = new int[10, 10];
        var List1 = new List<int>();
        for (int i = 1; i < number+1; ++i)
        {
            List1.Add(i);
        }
        var arr1 = List1.ToArray();
        Console.Write("x/y |\t");
        for (int i = 0; i < arr1.Length; ++i)
        {
            Console.Write(arr1[i] + "\t");
        }
        Console.WriteLine();
        Console.Write("---------------------------------------------------------------------");
        Console.WriteLine();

        for (int i = 1; i < number+1; ++i)
        {
            Console.Write(i + "|\t");
            for (int j = 1; j < number+1; ++j)
            {
                
               int sum = i * j;
                if (i == j)
                {
                    arr[i, j] = sum;
                    Console.Write(arr[i, j] + "\t");
                }
                else if (i > j)
                {
                    arr[i, j] = sum;
                    Console.Write(arr[i, j] + "\t");
                }
                else if (i < j)
                {
                    arr[i, j] = sum;
                    Console.Write(arr[i, j] + "\t");
                }

            }
            Console.Write("\n");
        }

    }
}

  
