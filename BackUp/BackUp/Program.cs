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
        //static string[] menuName = { "Get Capacity", "Copy" };
        static string[] storage = { "Flash", "DVD", "HDD" };
        static List<Storage> st = new List<Storage>();

        //static void Menu(int select)
        //{
        //    for (int i = 0; i < menuName.Length; i++)
        //    {
        //        Console.SetCursorPosition(0, i);
        //        Console.WriteLine("                        ");
        //        Console.SetCursorPosition(0, i);

        //        if (select == i)
        //            Console.ForegroundColor = ConsoleColor.Cyan;
        //        else
        //            Console.ForegroundColor = ConsoleColor.Gray;

        //        Console.WriteLine(menuName[i]);
        //    }
        //}
		//----------------------------------------------------------------------------------- 
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
		//-----------------------------------------------------------------------------------
		static void CreateFlash()
        {
			Console.CursorVisible = true;
			Console.SetCursorPosition(0, 10);
            Console.WriteLine("Flash:");

            Console.Write("Input name: ");
            string name = Console.ReadLine();

            Console.Write("Input model: ");
            string model = Console.ReadLine();

            Console.WriteLine("Select USB type");
            Console.WriteLine("1. USB 2.0 = 480Mb");
            Console.WriteLine("2. USB 3.0 = 5000Mb");
            var key = Console.ReadKey(true).Key;
            char type;

			if (key == ConsoleKey.D1)
			{
				type = '2';
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"USB 2.0");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			else
			{ 
                type = '3';
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"USB 3.0");
				Console.ForegroundColor = ConsoleColor.Gray;
			}

			Console.Write("Input size: ");
            double capacity = Convert.ToDouble(Console.ReadLine());

            Flash temp = new Flash(type, capacity, name, model);
            st.Add(temp);
			Console.CursorVisible = false;
			Console.SetCursorPosition(0, 10);
			for (int i = 0; i < 8; i++)
				Console.WriteLine("								");
		}
		//-----------------------------------------------------------------------------------
		static void CreateDVD()
        {
			Console.CursorVisible = true;
			Console.SetCursorPosition(0, 10);
			Console.WriteLine("DVD:");

			Console.Write("Input name: ");
			string name = Console.ReadLine();

			Console.Write("Input model: ");
			string model = Console.ReadLine();

			Console.WriteLine("Select DVD type");
			Console.WriteLine("1. One Side DVD");
			Console.WriteLine("2. Two Side DVD");
			var key = Console.ReadKey(true).Key;
			char type;

			if (key == ConsoleKey.D1)
			{
				type = 'o';
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"One Side DVD");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("Size:        4.7Gb");
				Console.WriteLine("Write Spead: 9.8x");
			}
			else
			{
				type = 't';
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"Two Side DVD");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.WriteLine("Size:        9Gb");
				Console.WriteLine("Write Spead: 9.8x");
			}

			DVD temp = new DVD(type, name, model);
			st.Add(temp);
			Console.CursorVisible = false;
			Console.SetCursorPosition(0, 10);
			for (int i = 0; i < 9; i++)
				Console.WriteLine("								");
		}
		//-----------------------------------------------------------------------------------
		static void CreateHDD()
        {
			Console.CursorVisible = true;
			Console.SetCursorPosition(0, 10);
			Console.WriteLine("HDD:");

			Console.Write("Input name: ");
			string name = Console.ReadLine();

			Console.Write("Input model: ");
			string model = Console.ReadLine();

			Console.Write("Input Count of Section: ");
			int countOfSection = Convert.ToInt32(Console.ReadLine());

			Console.Write("Input Size of Section: ");
			int capacityOfSection = Convert.ToInt32(Console.ReadLine());

			HDD temp = new HDD(countOfSection, capacityOfSection, name, model);

			st.Add(temp);
			Console.CursorVisible = false;
			Console.SetCursorPosition(0, 10);
			for (int i = 0; i < 5; i++)
				Console.WriteLine("								");
		}
		//-----------------------------------------------------------------------------------
		static double Capacity()
        {
            double size = 0.0;

            for (int i = 0; i < st.Count; i++)
                size += st[i].GetCapacity();

            return size;
        }
        //-----------------------------------------------------------------------------------
        static TimeSpan GetTotalTime()
        {
            int time = 0;
            TimeSpan temp;

            for (int i = 0; i < st.Count; i++)
                time += st[i].GetTime();

            temp = TimeSpan.FromSeconds(time); 

            return temp;
        }
        //-----------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            int select = 0;
            double TotalSize;
            double OneFileSize;
            bool noExit = true;
			Console.CursorVisible = true;

            Console.Write("Input the total size(Gb): ");
            TotalSize = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(26 + TotalSize.ToString().Length, 0);
            Console.WriteLine("Gb");

            Console.Write("Input the size of one file(Mb): ");
            OneFileSize = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(32 + OneFileSize.ToString().Length, 1);
            Console.WriteLine("Mb");

			Console.CursorVisible = false;
			Console.WriteLine("\nCreate storage");

            while (noExit)
            {
                MenuOfStorage(select);

                Console.Write("Capacity: ");
                if (Capacity() < (TotalSize * 1000))
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

			Console.WriteLine($"Total size: ");

			if (Capacity() < (TotalSize * 1000))
				Console.ForegroundColor = ConsoleColor.Red;
			else
				Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(Capacity());
			Console.ForegroundColor = ConsoleColor.Gray;

			Console.WriteLine();

            Console.WriteLine($"Copy by: {GetTotalTime()}");

            if (st.Count < 1)
                Console.WriteLine("");

            //while (true)
            //{
            //   Menu(select);

            //   var key = Console.ReadKey(true).Key;

            //   switch (key)
            //   {
            //       case ConsoleKey.UpArrow:
            //           if (select > 0)
            //               select--;
            //           break;
            //       case ConsoleKey.DownArrow:
            //           if (select < menuName.Length - 1)
            //               select++;
            //           break;
            //       case ConsoleKey.Enter:
            //           if (select == 0)
            //           {
                           
            //           }
            //           break;
            //   }
            //}
        }
    }
}
//-----------------------------------------------------------------------------------