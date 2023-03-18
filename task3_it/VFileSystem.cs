using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3_it.Commands;

namespace task3_it
{
    internal class VFileSystem
    {
        private VDirectory root = new VDirectory("~");
        public Dictionary<String, ICommand> commands {get; set;}

        public VFileSystem()
        {
        }

        public int TryExecCommand(VDirectory currDir, String[] command)
        {
            if (commands.ContainsKey(command[0]))
            {
                return commands[command[0]].exec(currDir, command);
            }
            else if (command.Length > 1 && commands.ContainsKey(command[1]))
            {
                VFile? targetFile = currDir.getChildByName(command[0]);
                if (targetFile != null)
                {
                    return commands[command[1]].exec(targetFile, command);
                }
            }
            return -1;
        }

        

        public VDirectory GetRoot() => root;
    }
}
