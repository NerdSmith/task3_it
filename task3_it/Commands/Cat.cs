using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it.Commands
{
    internal class Cat : CommandAbs
    {
        public Cat(string name, VFileSystem fs) : base(name, fs)
        {
        }

        public override int exec(VFile file, string[] args)
        {
            if (file is VDirectory)
            {
                string filename = args[1];
                VFile? vf = ((VDirectory)file).getChildByName(filename);
                if (vf != null)
                {
                    if (vf.Content == null)
                    {
                        Console.WriteLine("<Empty file>");
                    }
                    else
                    {
                        Console.WriteLine(vf.Content);
                    }


                    return 0;
                }
            }


            return -1;
        }
    }
}
