using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public abstract class Mammal : Animal
    {
        public virtual bool ProduceMilk()
        {
            bool condition = false;
            if (this.Gender == "Male")
            {
                Console.WriteLine($"{this.Name} is a Male and can't produce milk!");
                condition = false;
            }

            else if (this.Gender == "Female")
            {
                if (this.Age < 1)
                {
                    Console.WriteLine($"{this.Name} Can't produce milk, too young!");
                    condition = false;

                }
                else if (this.Age >= 1)
                {
                    Console.WriteLine($"{this.Name} is producing milk!");
                    condition = true;

                }
            }
            return condition;
        }
    }
}
