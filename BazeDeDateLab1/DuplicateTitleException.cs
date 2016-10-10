using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazeDeDateLab1.Exception
{
    class DuplicateTitleException : System.Exception
    {
        public DuplicateTitleException()
        {

        }

        public DuplicateTitleException(string message) : base(message)
        {
        }

        public DuplicateTitleException(string message, System.Exception inner) : base(message, inner)
        {
        }
    }
}
