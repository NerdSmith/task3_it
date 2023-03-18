using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it.SCommands
{
    internal class CD4Serv : SCommandAbs
    {
        public CD4Serv(VFileSystemService vFileSystemService) : base(vFileSystemService)
        {
        }

        public override int exec(VFile currFile, string[] args)
        {
            VFileSystemService.CurrDir = (VDirectory)((VDirectory)currFile).getChildByName(args[1]);
            return 0;
        }
    }
}
