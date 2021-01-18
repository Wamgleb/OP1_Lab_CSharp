using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        // Прописываем константы, дерикторию файлов
        const string firstFileName = "C:\\Users\\Gleb\\Documents\\Repo_location\\OP1_Lab_CSharp\\Lab6\\1.txt";
        const string secondFileName = "C:\\Users\\Gleb\\Documents\\Repo_location\\OP1_Lab_CSharp\\Lab6\\2.txt";

        static void Main(string[] args)
        {
            CreateFileName();
            ReadFileName();
            
		}

        public static void CreateFileName()
        {
            // Вписываем значения в файл по указаной дериктории
            StreamWriter sw = new StreamWriter(firstFileName);
            sw.WriteLine("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21");
            sw.Close();
        }

        public static void ReadFileName()
        {
            // Читаем файлл
            string file = File.ReadAllText(firstFileName);
            // Конвектируем массив char в int
            int[] nums = file.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();
          
            int temp;

            for (int i = 0; i < nums.Length; i++)
            {
                // Находим максимальное и минимальное значение
                int maxValue = nums.Max<int>();
                int minValue = nums.Min<int>();

                // Вывод начального отсортированого массива
                Console.WriteLine(nums[i]);

                if (nums[i] == maxValue)
                {
                    // передаем переменной значения минимально в массиве
                    temp = minValue;
                    // Ставим макчимальний элемент на место минимального
                    nums[0] = nums[i];
                    // Ставим минимальный на место максимального 
                    nums[20] = temp;
                }

            }

            Console.WriteLine("\n");
            Console.WriteLine("Измененный массив.");
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine(nums[j]);
            }

            // Вписываем значения в файл по указаной дериктории
            StreamWriter sw = new StreamWriter(secondFileName);
            // Конвектируем каждый элемент массива в строку для записи в файл
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i].ToString();
                sw.WriteLine(nums[i]);
            }
            sw.Close();

            Console.WriteLine("\n");

            for (int i = 0; i < nums.Length; i++)
            {
                // Находим максимальное и минимальное значение
                int maxValue = nums.Max<int>();
                int minValue = nums.Min<int>();

                // Вывод начального отсортированого массива
                Console.WriteLine(nums[i]);

                if (nums[i] == maxValue)
                {
                    temp = minValue;
                    nums[19] = maxValue;
                    // Ставим минимальный на место максимального 
                    nums[20] = temp;


                }

            }

            Console.WriteLine("\n");
            Console.WriteLine("Измененный массив.");

            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine(nums[j]);
            }

           
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i].ToString();
            }
            
        }

    }
}
