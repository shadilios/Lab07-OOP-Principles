﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public interface ICanFly
    {
        public int FlySpeed { get; set; }

        public bool Fly();
    }
}
