using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syst
{
    public static class FSManager
    {
        public static void TryDelDir(string pathdir)
        {
            try
            {
                Directory.Delete(pathdir, true);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void TryDelFile(string pathfile)
        {
            try {
                File.Delete(pathfile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void TryMkFile(string pathfile)
        {
            try
            {
                File.Create(pathfile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static void TryMkDir(string pathdir)
        {
            try
            {
                Directory.CreateDirectory(pathdir);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}