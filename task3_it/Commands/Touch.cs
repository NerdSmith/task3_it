using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it.Commands
{
    internal class Touch : CommandAbs
    {
        public Touch(string name, VFileSystem fs) : base(name, fs)
        {
        }

        public override int exec(VFile file, string[] args)
        {
            if (file is VDirectory)
            {
                string filename = args[1];
                VFile newFile = new VFile(filename);

                return ((VDirectory)file).AddFile(newFile);
            }
            return -1;
        }
    }
}
