using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public abstract class Fish : Animal
    {
        public virtual void EasyToSpot()
        {
            if (this.Weight >= 5)
            {
                Console.WriteLine($"{this.Name} can be spotted, it has a big & heavy body");
            }
            else if(this.Weight < 5)
            {
                Console.WriteLine($"{this.Name} can't be spotted, it's small relate to other fish");
            }
        }
        
    }
}
