﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPattern.FactoryPattern
{
    public interface ILogger
    { 
        void WriteMessage(string messge);
    }
}
