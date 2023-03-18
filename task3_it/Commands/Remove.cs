using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it.Commands
{
    internal class Remove : CommandAbs
    {
        public Remove(string name, VFileSystem fs) : base(name, fs)
        {
        }

        public override int exec(VFile file, string[] args)
        {
            if (file is VDirectory)
            {
                string filename = args[1];
                ((VDirectory)file).RemoveFile(filename);
                return 0;
            }
            return -1;
        }
    }
}
