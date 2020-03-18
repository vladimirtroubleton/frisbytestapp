using System;
using System.Collections.Generic;
using System.Text;

namespace FrisbiTestApp.Exceptions
{
    public class ExceptDbAcess : Exception
    {
        public ExceptDbAcess(string message) : base(message) { }
    }
}
