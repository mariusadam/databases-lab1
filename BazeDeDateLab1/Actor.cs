using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeDeDateLab1
{
    public class Actor
    {
        public string Name { set; get; }

        public Actor(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Actor && (obj as Actor).Name == this.Name;
        }
    }
}
