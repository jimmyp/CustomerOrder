using System;

namespace CSharp.CustomerOrder
{
	public class DomainValidationException : Exception
	{
        public DomainValidationException (string message): base(message)
        {
        }
	}

}

