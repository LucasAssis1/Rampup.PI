using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv4.Commom.Exceptions
{
    public class ExistingAccountException : Exception
    {
        public ExistingAccountException() { }
        public ExistingAccountException(string message) : base(message) { }
        public ExistingAccountException(string message, Exception inner) : base(message, inner) { }
    }
}
