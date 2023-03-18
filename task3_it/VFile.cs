using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_it
{
    internal class VFile
    {
        public virtual String Name { get; set; }
        public virtual String? Content {  get; set; }
        public virtual VDirectory? Parent { get; set; }

        public VFile(string name, string content, VDirectory parent)
        {
            Name = name;
            Content = content;
            Parent = parent;
        }

        public VFile(string name, string content)
        {
            Name = name;
            Content = content;
            Parent = null;
        }

        public VFile(string name, VDirectory parent)
        {
            Name = name;
            Content = null;
            Parent = parent;
        }

        public VFile(string name)
        {
            Name = name;
            Content = null;
            Parent = null;
        }
    }
}
