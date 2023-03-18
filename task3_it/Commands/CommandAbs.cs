using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it.Commands
{
    internal abstract class CommandAbs : ICommand
    {
        public String Name { get; set; }
        public VFileSystem FileSystem { get; set; }

        protected CommandAbs(string name, VFileSystem fs)
        {
            Name = name;
            FileSystem = fs;
        }
        public abstract int exec(VFile file, string[] args);
    }
}
