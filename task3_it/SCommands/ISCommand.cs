using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it.SCommands
{
    internal interface ISCommand
    {
        public int exec(VFile currFile, string[] args);
    }
}
