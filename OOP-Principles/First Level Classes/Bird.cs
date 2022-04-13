using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public abstract class Bird : Animal
    {
       
        public virtual void BuildNest()
        {

            if (this.Gender == "Female")
            {
                Console.WriteLine($"{this.Name} is building her nest");
            }
            else if (this.Gender == "Male")
            {
                Console.WriteLine($"{this.Name} is building his nest");
            }
        }

        
    }
}
