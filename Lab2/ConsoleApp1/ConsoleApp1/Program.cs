/*Лабораторна робота №2
 *роботу виконав студент ЗПІ-ЗП1
 *Калінчук Гліб Сергійович
 *
 *Код показує роботу методів та свойств C#
 *Beep (метод), BackgroundColor(свойство)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(@"Привiт!
Обери одну з наступних опцiй, вказавши необхiдну цифру:
[1] - щоб зiграти Jingle Bells;
[2] - щоб змiнити колiр консолi на новорiчний;");
            string items = Console.ReadLine();
            if (items == "1")
            {
                Main1();
            }
            else if (items == "2")
            {
                Main2();
            }
   
        }

        static void Main1()
        {
            Console.WriteLine("Щоб зупинити музику натисніть 's'");
            string stopRollp = Console.ReadLine();
            if (stopRollp == "s")
            {
               // return Main3();
            }
            coupleSolo1();
            coupleSolo2();
        }

        //Jingle Bells музыка
        //Поменять первый куплет
        static void coupleSolo1()
        {
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        static void coupleSolo2()
        {
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(392, 600);
            Thread.Sleep(300 * 2);
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(440, 600);
            Thread.Sleep(600);
            Console.Beep(440, 300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(783, 600);
            Thread.Sleep(600);
            Console.Beep(880, 300);
            Console.Beep(880, 300);
            Console.Beep(783, 300);
            Console.Beep(622, 300);
            Console.Beep(659, 600);
            Thread.Sleep(600);
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(392, 600);
            Thread.Sleep(600);
            Console.Beep(392, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 300);
            Console.Beep(440, 600);
            Thread.Sleep(600);
            Console.Beep(440, 300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(783, 600);
            Thread.Sleep(600);
            Console.Beep(880, 300);
            Console.Beep(783, 300);
            Console.Beep(698, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 600);
            Thread.Sleep(600);
        }

        static void Main2()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Натисни любу клавiшу, щоб завершити");
            Console.ReadKey();

        }

        static void Main3()
        {
            //TODO: ДОПИСАТЬ КОД ВЫХОДА С СИСТЕМЫ.
        }
    }
}
