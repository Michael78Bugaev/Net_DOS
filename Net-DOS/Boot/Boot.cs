using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;
using Syst;

namespace Boot_DOS
{
    public static class BootManager
    {
        
        public static void CheckDOSforSetup()
        {
            
            if (!Directory.Exists(@"0:\net10"))
            {
                
                Console.Clear();
                Console.WriteLine("Welcome to Net-DOS 1.0.0 Setup Manager! Do you want to continue? (Y/N)");
                while (true)
                {
                    var YN = Console.ReadLine();
                    switch (YN)
                    {
                        default:
                            Console.Clear();
                            Console.WriteLine("Wrong answer!");
                            break;
                        case "y":
                            install();
                            break;
                        case "n":
                            Cosmos.System.Power.Shutdown();
                            break;
                        case "Y":
                            install();
                            break;
                        case "N":
                            Cosmos.System.Power.Shutdown();
                            break;
                    }
                }
                
            }
            else
            {
                Console.Clear();
            }
                
        }
        private static void trytodeldir(string path)
        {
            if (Directory.Exists(path))
            {
                FSManager.TryDelDir(path);
            }
            else
            {
                Console.WriteLine("Error: failed to delete directory.");
            }
        }
        private static void install()
        {
            Console.Clear();
            Console.WriteLine("Setting up Net-DOS...");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Directory.CreateDirectory(@"0:\net10");
            Directory.CreateDirectory(@"0:\net10\system");
            Directory.CreateDirectory(@"0:\net10\root");
            Directory.CreateDirectory(@"0:\net10\files");
            Directory.CreateDirectory(@"0:\net10\qip");
            Directory.CreateDirectory(@"0:\net10\qip\Programs");
            FSManager.TryDelDir(@"0:\Dir Testing");
            FSManager.TryDelFile(@"0:\TEST\DirInTest\Readme.txt");
            FSManager.TryDelDir(@"0:\TEST\DirInTest");
            FSManager.TryDelDir(@"0:\TEST");
            Thread.Sleep(7000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Warning: Network driver cannot be installed. Continue? (Y/N)");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                var YN = Console.ReadLine();
                switch (YN)
                {
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong answer!");
                        break;
                    case "N":
                        Cosmos.System.Power.Shutdown();
                        break;
                    case "Y":
                        Console.Clear();
                        Console.WriteLine("Setting up Net-DOS... There is very little left");
                        Console.ForegroundColor= ConsoleColor.Black;
                        Thread.Sleep(5000);
                        Cosmos.System.Power.Reboot();
                        break;
                }
            
                
            }
        }
    }
}

