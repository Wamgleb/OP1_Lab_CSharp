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
            MyArray();
            Matrix();
        
            Console.ReadLine(); 
        }

        public static void MyArray()
        {
            Random rm = new Random();
            int[] myArray = new int[21];

            for (int i = 0; i < myArray.Length; i++)
            {
                // Наполняем массив рандомными числами
                myArray[i] = rm.Next(0, 100);
            }
            
            // Сортируем
            Array.Sort(myArray);
            int temp;

            for (int i = 0; i < myArray.Length; i++)
            {
                // Находим максимальное и минимальное значение
                int maxValue = myArray.Max<int>();
                int minValue = myArray.Min<int>();

                // Вывод начального отсортированого массива
                Console.WriteLine(myArray[i]); 

                if (myArray[i] == maxValue)
                {
                    // передаем переменной значения минимально в массиве
                    temp = minValue;
                    // Ставим макчимальний элемент на место минимального
                    myArray[0] = myArray[i];
                    // Ставим минимальный на место максимального 
                    myArray[20] = temp;
                }

            }

            Console.WriteLine("\n");
            Console.WriteLine("Измененный массив.");
            for (int j = 0; j < myArray.Length; j++)
            {
                Console.WriteLine(myArray[j]);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < myArray.Length; i++)
            {
                // Находим максимальное и минимальное значение
                int maxValue = myArray.Max<int>();

                // Вывод начального отсортированого массива
                Console.WriteLine(myArray[i]);

                if (myArray[i] == maxValue)
                {
                    temp = myArray[19];
                    myArray[19] = maxValue;
                    // Ставим минимальный на место максимального 
                    myArray[20] = temp;
                    
                    
                }

            }

            Console.WriteLine("\n");
            Console.WriteLine("Измененный массив.");

            for (int j = 0; j < myArray.Length; j++)
            {
                Console.WriteLine(myArray[j]);
            }


        }

        public static void Matrix()
        {
            Random r = new Random();
            int[,] Mass = new int[4, 3];
            int s = 1;
            int i, j;
            string byf;
            Console.Write("1 - Ввод вручную, 2 - Рандомный ввод: ");
            byf = Console.ReadLine();
            switch (byf)
            {
                case "1":
                    for (i = 0; i < Mass.GetLength(0); ++i)
                        for (j = 0; j < Mass.GetLength(1); ++j)
                        {
                            Console.Write("введите " + i + " " + j + " элемент: ");
                            Mass[i, j] = int.Parse(Console.ReadLine());
                        }
                    break;

                case "2":
                    for (i = 0; i < Mass.GetLength(0); i++)

                        for (j = 0; j < Mass.GetLength(1); j++)
                            Mass[i, j] = r.Next(0, 20);
                    break;
                default:
                    Console.Write("Ошибка!");
                    Console.WriteLine();
                    Console.ReadKey();
                    return;
            }

            Console.Write("Массив:");
            for (i = 0; i < Mass.GetLength(0); i++)
            {
                Console.WriteLine();
                for (j = 0; j < Mass.GetLength(1); j++)
                {
                    Console.Write(Mass[i, j] + " ");
                    if (i == j) s *= Mass[i, j];
                }
            }
            Console.WriteLine();
            Console.Write("Произведение элементов " + s);
            Console.ReadKey();
        }
    }

}

