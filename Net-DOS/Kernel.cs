using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using BManager = Boot_DOS.BootManager;
using ComManager = Net_DOS.Commands.CommandManager;

namespace Net_DOS
{
    public class Kernel : Sys.Kernel
    {
        public static Sys.FileSystem.CosmosVFS fs;

        protected override void BeforeRun()
        {
            fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            BManager.CheckDOSforSetup(); //- !!! Start only when the presentation is going, test, or when it needs to compile !!!
            Console.WriteLine(" ");
        }

        protected override void Run()
        {
            
            ComManager.Commands();
            
        }
    }
}
