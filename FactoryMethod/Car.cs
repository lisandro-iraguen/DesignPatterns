﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Car : IProduct
    {
        public string Operation()
        {
            return "{Result of Concrete Product Car}";
        }
    }
}
