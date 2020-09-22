using System;
using System.Collections.Generic;
using System.Text;

namespace Aula.Entities.Exeptions
{
    class DomainException : ApplicationException
    {

        public DomainException(string message) : base(message)
        {
        }
    }
}