using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "test.db"; // Название БД
            Console.WriteLine($"Попытка создать базу {name}");
            Console.WriteLine(DBWork.MakeDB(name)); // Создаём БД и выводим её в консоль
        }
    }
}
