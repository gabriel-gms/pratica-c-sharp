using System;
using System.Collections.Generic;
using System.Text;

namespace exception.Execptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
