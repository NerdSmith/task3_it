using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it.Commands
{
    internal class CD : CommandAbs
    {
        public CD(string name, VFileSystem fs) : base(name, fs)
        {
        }

        public override int exec(VFile file, string[] args)
        {
            if (file is VDirectory)
            {
                string targetDir = args[1];
                if (((VDirectory) file).getChildByName(targetDir) != null)
                {
                    return 1;
                }
                else
                {
                    return -2;
                }
            }
            return -1;
        }
    }
}
