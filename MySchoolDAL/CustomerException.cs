using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySchool.DAL
{
    public class CustomerException : Exception
    {
        public CustomerException()
        {
        }

        public CustomerException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
