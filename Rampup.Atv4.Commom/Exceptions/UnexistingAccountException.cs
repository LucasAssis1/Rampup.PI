using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv4.Commom.Exceptions
{
    public class UnexistingAccountException: Exception
    {
        public UnexistingAccountException() { }
        public UnexistingAccountException(string message) : base(message) { }
        public UnexistingAccountException(string message, Exception inner) : base(message, inner) { }
    }
}
