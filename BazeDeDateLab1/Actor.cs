using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeDeDateLab1
{
    public class Actor
    {
        private string __name;

        public Actor(string name)
        {
            __name = name;
        }

        public string Name
        {
            get
            {
                return __name;
            }
            set
            {
                __name = value;
            }
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
