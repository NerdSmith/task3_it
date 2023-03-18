using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it.Commands
{
    internal class WriteContent : CommandAbs
    {
        public WriteContent(string name, VFileSystem fs) : base(name, fs)
        {
        }

        public override int exec(VFile file, string[] args)
        {
            if (!(file is VDirectory))
            {
                file.Content = String.Join(" ", args.ToList().Skip(2));
                return 0;
            }
            return -1;
        }
    }
}
