﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_2
{
    class UserException : Exception
    {
        public UserException()
        {
        }

        public UserException(string message) : base(message)
        {
        }
    }
}
