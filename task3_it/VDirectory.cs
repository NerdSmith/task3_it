using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it
{
    internal class VDirectory : VFile
    {
        protected Dictionary<String, VFile> files = new Dictionary<string, VFile>();

        public VDirectory(string name, VDirectory parent) : base(name, parent)
        {
            files.Add(".", this);
            files.Add("..", parent);
        }

        public VDirectory(string name) : base(name)
        {
            files.Add(".", this);
        }

        public int AddFile(VFile file)
        {
            if (!files.ContainsKey(file.Name))
            {
                files.Add(file.Name, file);
                file.Parent = this;
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public int RemoveFile(VFile file)
        {
            return RemoveFile(file.Name);
        }

        public int RemoveFile(String Filename)
        {
            if (files.ContainsKey(Filename))
            {
                files.Remove(Filename);
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public List<String> GetChildNames()
        {
            return files.Keys.ToList();
        }

        public VFile? getChildByName(String filename)
        {
            VFile? child = null;
            files.TryGetValue(filename, out child);
            return child;
        }
    }
}
