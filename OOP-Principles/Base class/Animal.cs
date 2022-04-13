using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public abstract class Animal
    {

        public virtual string Name { get; set; }

        public abstract int Age { get; set; }

        public abstract string Gender { get; set; }

        public virtual int Weight { get; set; }

        public virtual bool EatsMeat { get; set; }

        public abstract void Eat();

        public abstract void Sleep();
    }
}
