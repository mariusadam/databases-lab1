using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeDeDateLab1.Exception
{
    class ItemNotFoundException : System.Exception
    {
        public ItemNotFoundException()
        {

        }

        public ItemNotFoundException(string message) : base(message)
        {
        }

        public ItemNotFoundException(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}
