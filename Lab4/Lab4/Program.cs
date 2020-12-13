using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            Random dice = new Random();
            int[] arr = new int[20];

            //формируем массив рандомных чисел;
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    arr[i] = dice.Next(0,100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine(arr[i]);
                }
            
            }


            //var max = arr.Max();
            //var min = arr.Min();
            //Console.WriteLine($"Максимальный элемент: {max}\nМинимальный элемент: {min}");
            int max_i = Max_ind(arr);
            int min_i = Min_ind(arr);
            int tmp = arr[max_i];
            arr[max_i] = arr[min_i];
            arr[min_i] = tmp;
            Console.WriteLine("Измененный массив: ");
            Console.WriteLine(arr);
            Console.ReadKey(true);



            Console.ReadLine();
        
        }

        static int Max_ind(int[] a)
        {
            int max_i = 0;
            for (int i = 1; i < a.Length; ++i)
                if (a[i] >= a[max_i]) max_i = i;
            return max_i;
        }

        static int Min_ind(int[] a)
        {
            int min_i = a.Length - 1;
            for (int i = a.Length - 1; i > 0; --i)
                if (a[i - 1] <= a[min_i]) min_i = i - 1;
            return min_i;
        }

        
    }   

}
