using task3_it;
using task3_it.Commands;
using task3_it.SCommands;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            VFileSystem vFileSystem = new VFileSystem();
            vFileSystem.commands = new Dictionary<string, ICommand> {
                {"touch", new Touch("touch", vFileSystem)},
                {"rename", new Rename("rename", vFileSystem) },
                {"ls", new List("ls", vFileSystem) },
                {"cd", new CD("cd", vFileSystem) },
                {"mkdir", new Mkdir("mkdir", vFileSystem) },
                {"rm", new Remove("rm", vFileSystem) },
                {"<<", new AddContent("<<", vFileSystem) },
                {"<", new WriteContent("<", vFileSystem) },
                {"cat", new Cat("cat", vFileSystem) },
            };
            VFileSystemService vFileSystemService = new VFileSystemService(vFileSystem);
            vFileSystemService.Commands = new Dictionary<int, ISCommand> {
                {1, new CD4Serv(vFileSystemService)}
            };

            string? inp = null;
            while (inp != "exit")
            {
                Console.Write("CUMPUTAR:");
                Console.Write(vFileSystemService.GetFullPath());
                inp = Console.ReadLine();
                if (inp != null && inp != "")
                {
                    int statusCode = vFileSystemService.ProcessInput(inp);
                    Console.Write("Status code: ");
                    Console.WriteLine(statusCode);
                }
            }
        }
    }
}