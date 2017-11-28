using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------------------------------------
namespace BackUp
{
    class Program
    {
        static string[] menuName = { "Get Capacity", "Copy" };
        static string[] storage = { "Flash", "DVD", "HDD" };
        static List<Storage> st = new List<Storage>();

        static void Menu(int select)
        {
            for (int i = 0; i < menuName.Length; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("                        ");
                Console.SetCursorPosition(0, i);

                if (select == i)
                    Console.ForegroundColor = ConsoleColor.Cyan;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine(menuName[i]);
            }
        }

        static void MenuOfStorage(int select)
        {
            for (int i = 0; i < storage.Length; i++)
            {
                Console.SetCursorPosition(0, i + 4);
                Console.WriteLine("                        ");
                Console.SetCursorPosition(0, i + 4);

                if (select == i)
                    Console.ForegroundColor = ConsoleColor.Cyan;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine(storage[i]);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void CreateFlash()
        {
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("Flash:");
            Console.Write("In");
            //Flash temp = new Flash()
        }

        static void CreateDVD()
        {

        }

        static void CreateHDD()
        {

        }

        static double Capacity()
        {
            double size = 0.0;

            for (int i = 0; i < st.Count; i++)
                size += st[i].GetCapacity();

            return size;
        }

        static void Main(string[] args)
        {
            int select = 0;
            double TotalSize;
            double OneFileSize;
            bool noExit = true;
            Console.CursorVisible = false;

            Console.Write("Input the total size(Gb): ");
            TotalSize = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(26 + TotalSize.ToString().Length, 0);
            Console.WriteLine("Gb");

            Console.Write("Input the size of one file(Mb): ");
            OneFileSize = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(32 + OneFileSize.ToString().Length, 1);
            Console.WriteLine("Mb");

            Console.WriteLine("\nCreate storage(create min one by each type)");

            while (noExit)
            {
                MenuOfStorage(select);

                Console.Write("Capacity: ");
                if (Capacity() < TotalSize)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Capacity());
                Console.ForegroundColor = ConsoleColor.Gray;

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (select > 0)
                            select--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (select < storage.Length - 1)
                            select++;
                        break;
                    case ConsoleKey.Enter:
                        if (select == 0)
                            CreateFlash();
                        else
                        if (select == 1)
                            CreateDVD();
                        else
                        if (select == 2)
                            CreateHDD();
                        break;
                    case ConsoleKey.Escape:
                        noExit = false;
                        Console.Clear();
                        break;
                }
            }

            while (true)
            {
               Menu(select);

               var key = Console.ReadKey(true).Key;

               switch (key)
               {
                   case ConsoleKey.UpArrow:
                       if (select > 0)
                           select--;
                       break;
                   case ConsoleKey.DownArrow:
                       if (select < menuName.Length - 1)
                           select++;
                       break;
                   case ConsoleKey.Enter:
                       if (select == 0)
                       {
                           
                       }
                       break;
               }
            }
        }
    }
}
//-----------------------------------------------------------------------------------