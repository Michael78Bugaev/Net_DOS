using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Syst;

namespace Net_DOS.Commands
{
    public static class CommandManager
    {
        public static string currentdir = @"0:\net10\System";
        public static void Commands()
        {
            
            Console.Write(currentdir + ">");
            var input = Console.ReadLine();

            switch (input)
            {
                default:
                    Console.WriteLine("Unknown Command!\n");
                    break;
                case "help":
                    Console.WriteLine("help - get list of commands\nqip - quick install packages\n");
                    break;
                case "qip":
                    Console.WriteLine("Example: 'qip install <programm, game, or library>'\n\nPrograms: GraphicLine, AudioMixer, CPPLanguage (C++ Lanpuage).");
                    break;
                case "cls":
                    Console.Clear();
                    Console.WriteLine(" ");
                    break;
                case "deldir":
                    Console.Write("name >");
                    string dirr = currentdir + "/" + Console.ReadLine();
                    FSManager.TryDelDir(dirr);
                    break;
                case "delfile":
                    Console.Write("name >");
                    string filee = currentdir + "/" + Console.ReadLine();
                    FSManager.TryDelFile(filee);
                    break;
                case "mkdir":
                    Console.Write("name >");
                    string ddir = currentdir + "/" + Console.ReadLine();
                    FSManager.TryMkDir(ddir);
                    break;
                case "mkfile":
                    Console.Write("name >");
                    string ffile = currentdir + "/" + Console.ReadLine();
                    FSManager.TryMkFile(ffile);
                    break;
                case "cd ..":
                    currentdir = Directory.GetParent(currentdir).FullName;
                    try
                    {
                        var files_list = Directory.GetFiles(currentdir);
                        var directory_list = Directory.GetDirectories(currentdir);
                        var fs_type = Kernel.fs.GetFileSystemType(currentdir);
                        var available_space = Kernel.fs.GetAvailableFreeSpace(currentdir);
                        var time_dir = Directory.GetCreationTime(currentdir);
                        var time_file = File.GetCreationTime(currentdir);
                        Console.WriteLine("File System Type: " + fs_type);
                        Console.WriteLine("Free space: " + available_space + " bytes\n");
                        if (currentdir == null)
                        {
                            Console.WriteLine("Directory is empty");
                        }

                        foreach (var file in files_list)
                        {
                            Console.WriteLine(time_file + " <FILE> " + file);
                        }

                        foreach (var directory in directory_list)
                        {
                            Console.WriteLine(time_dir + " <DIR> " + directory);
                        }
                        Console.WriteLine(" ");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                case "dir":
                    try
                    {
                        var files_list = Directory.GetFiles(currentdir);
                        var directory_list = Directory.GetDirectories(currentdir);
                        var fs_type = Kernel.fs.GetFileSystemType(currentdir);
                        var available_space = Kernel.fs.GetAvailableFreeSpace(currentdir);
                        var time_dir = Directory.GetCreationTime(currentdir);
                        var time_file = File.GetCreationTime(currentdir);
                        Console.WriteLine("File System Type: " + fs_type );
                        Console.WriteLine("Free space: " + available_space + " bytes\n");
                        if (currentdir == null)
                        {
                            Console.WriteLine("Directory is empty");
                        }

                        foreach (var file in files_list)
                        {
                            Console.WriteLine(time_file + " <FILE> " + file);
                        }

                        foreach (var directory in directory_list)
                        {
                            Console.WriteLine(time_dir + " <DIR> " + directory);
                        }
                        Console.WriteLine(" ");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                case "cd":
                    Console.Write("name >");
                    var currdir = Console.ReadLine();
                    if (currdir == null)
                    {
                        Console.WriteLine("You aren't specify a folder.");
                    }
                    currentdir = currentdir + @"\" + currdir;
                    try
                    {
                        var files_list = Directory.GetFiles(currentdir);
                        var directory_list = Directory.GetDirectories(currentdir);
                        var fs_type = Kernel.fs.GetFileSystemType(currentdir);
                        var available_space = Kernel.fs.GetAvailableFreeSpace(currentdir);
                        var time_dir = Directory.GetCreationTime(currentdir);
                        var time_file = File.GetCreationTime(currentdir);
                        Console.WriteLine("File System Type: " + fs_type);
                        Console.WriteLine("Free space: " + available_space + " bytes\n");
                        if (currentdir == null)
                        {
                            Console.WriteLine("Directory is empty");
                        }

                        foreach (var file in files_list)
                        {
                            Console.WriteLine(time_file + " <FILE> " + file);
                        }

                        foreach (var directory in directory_list)
                        {
                            Console.WriteLine(time_dir + " <DIR> " + directory);
                        }
                        Console.WriteLine(" ");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                case "cd..":
                    currentdir = Directory.GetParent(currentdir).FullName;
                    try
                    {
                        var files_list = Directory.GetFiles(currentdir);
                        var directory_list = Directory.GetDirectories(currentdir);
                        var fs_type = Kernel.fs.GetFileSystemType(currentdir);
                        var available_space = Kernel.fs.GetAvailableFreeSpace(currentdir);
                        var time_dir = Directory.GetCreationTime(currentdir);
                        var time_file = File.GetCreationTime(currentdir);
                        Console.WriteLine("File System Type: " + fs_type);
                        Console.WriteLine("Free space: " + available_space + " bytes\n");
                        if (currentdir == null)
                        {
                            Console.WriteLine("Directory is empty");
                        }

                        foreach (var file in files_list)
                        {
                            Console.WriteLine(time_file + " <FILE> " + file);
                        }

                        foreach (var directory in directory_list)
                        {
                            Console.WriteLine(time_dir + " <DIR> " + directory);
                        }
                        Console.WriteLine(" ");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
            }
        }
    }
}