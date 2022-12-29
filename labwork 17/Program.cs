using System;
using System.IO;

namespace labwork_17
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter w = new StreamWriter("d:/2 курс/3 семестр/аип 3 семестр/практика 17.txt", true); //ввод в файл 
            w.WriteLine("Баринская"); //ввод в файл фамилии
            w.WriteLine("Ольга"); //ввод в файл имени
            w.WriteLine("Борисовна"); //ввод в файл отчества
            w.WriteLine("2004"); //ввод в файл года рождения
            w.Close(); //закрыть файл
            Console.WriteLine("данные введены в текстовый файл"); //вывод на консоль
            Console.ReadLine(); //программа ожидает нажатия клавиши для завершения работы
        }
    }
}
