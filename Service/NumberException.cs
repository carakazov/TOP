﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service
{
    public class NumberException : Exception
    {
        public NumberException(String message)
            : base(message)
        {

        }
    }
}