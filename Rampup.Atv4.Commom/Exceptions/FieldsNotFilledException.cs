using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rampup.Atv4.Commom
{
    public class FieldsNotFilledException: Exception
    {
        public FieldsNotFilledException() { }
        public FieldsNotFilledException(string message) : base(message) { }
        public FieldsNotFilledException(string message, Exception inner) : base(message, inner) { }
    }
}
