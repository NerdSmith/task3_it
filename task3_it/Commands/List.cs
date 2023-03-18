using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it.Commands
{
    internal class List : CommandAbs
    {
        public List(string name, VFileSystem fs) : base(name, fs)
        {
        }

        public override int exec(VFile file, string[] args)
        {
            if (file is VDirectory)
            {
                foreach (string s in ((VDirectory)file).GetChildNames())
                {
                    Console.WriteLine(s);
                }
                return 0;
            }
            return -1;
        }
    }
}
