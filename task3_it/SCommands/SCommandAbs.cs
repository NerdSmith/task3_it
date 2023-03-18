using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it.SCommands
{
    internal abstract class SCommandAbs : ISCommand
    {
        protected VFileSystemService VFileSystemService { get; set; }
        protected SCommandAbs(VFileSystemService vFileSystemService)
        {
            VFileSystemService = vFileSystemService;
        }

        public abstract int exec(VFile currFile, string[] args);
    }
}
