using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it.Commands
{
    internal class Rename : CommandAbs
    {
        public Rename(string name, VFileSystem fs) : base(name, fs)
        {
        }

        public override int exec(VFile file, string[] args)
        {
            if (file is VDirectory)
            {
                VFile? f = ((VDirectory)file).getChildByName(args[1]);
                if (f != null)
                {
                    string newName = args[2];
                    if (!((VDirectory)file).GetChildNames().Contains(newName))
                    {
                        ((VDirectory)file).RemoveFile(f);
                        f.Name = newName;
                        ((VDirectory)file).AddFile(f);
                        return 0;
                    }
                }
            }
            return -1;
        }
    }
}
