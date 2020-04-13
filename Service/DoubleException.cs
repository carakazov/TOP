using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service
{
    public class DoubleException : Exception
    {
        public DoubleException(String message)
            : base(message)
        {

        }
    }
}