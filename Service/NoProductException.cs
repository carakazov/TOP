using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service
{
    public class NoProductException : Exception
    {
        public NoProductException(String message) :
            base(message)
        {

        }
    }
}