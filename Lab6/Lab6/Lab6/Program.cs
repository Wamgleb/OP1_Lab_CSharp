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
        const string firstFile = "C:\\Users\\Gleb\\Documents\\Repo_location\\OP1_Lab_CSharp\\Lab6";
        const string secondFile = "C:\\Users\\Gleb\\Documents\\Repo_location\\OP1_Lab_CSharp\\Lab6";

        static void Main(string[] args)
        {
            
        }


        static void ReadFile(string a, string b)
        {
            var line = File.ReadLines(firstFile).FirstOrDefault();
            var ar = line.Split(' ').Select(r => decimal.Parse(r)).Reverse().Select(s => s.ToString()).ToArray();
        }


    }
}
