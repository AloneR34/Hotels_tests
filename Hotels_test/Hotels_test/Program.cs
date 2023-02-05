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
        for (int i = 0; i < a.Length; i++)
        { 
           Console.Write(a[i]);
        }
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
        for (int l=0; l<p.Length; l++)
        {
        for (int i = 0; i < b.Length; i++)
        {
            for (int j = i + 1; j < b.Length; j++)
            {
                if (b[i] == b[j] && p[l]== b[j]) 
                {
                    
                }
                else List1.Remove(p[l]);
            }

        }
        }

        var arr1 = List1.ToArray();
        Console.WriteLine(String.Join(" ", intersect));
        return arr1;
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

  
