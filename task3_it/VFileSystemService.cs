using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3_it.SCommands;

namespace task3_it
{
    internal class VFileSystemService
    {
        private VFileSystem VFileSystem { get; set; }
        public VDirectory CurrDir { get; set; }
        public Dictionary<int, ISCommand> Commands { get; set; }    

        public VFileSystemService(VFileSystem fileSystem) { 
            VFileSystem = fileSystem;
            CurrDir = fileSystem.GetRoot();
        }

        public int ProcessInput(string input)
        {
            String[] splittedInp = input.Split(" ");
            if (splittedInp.Length > 0)
            {
                int statusCode = VFileSystem.TryExecCommand(CurrDir, splittedInp);
                if (statusCode > 0) {
                    return Commands[statusCode].exec(CurrDir, splittedInp);
                }
                return statusCode;
            }
            return -1;
        }

        public string GetFullPath()
        {
            StringBuilder sb = new StringBuilder();
            VDirectory? dir = CurrDir;


            while (dir != null)
            {
                sb.Insert(0, dir.Name);
                if (dir != VFileSystem.GetRoot())
                {
                    sb.Insert(0, "/");
                }
                dir = dir.Parent;
            }
            sb.Append("$ ");
            return sb.ToString();
        }
    }
}
