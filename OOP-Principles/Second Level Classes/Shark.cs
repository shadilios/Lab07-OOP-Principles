using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public class Shark : Fish, ICanSwim
    {
        public int SwimSpeed { get; set; }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override int Age { get; set; }
        public override string Gender { get; set; }
        public override int Weight { get => base.Weight; set => base.Weight = value; }

        public Shark(int swimSpeed, string name, int age, string gender, int weight)
        {
            this.SwimSpeed = swimSpeed;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
        }

        public override bool EatsMeat
        {
            get
            {
                return true;
            }
        }

        public override void Eat()
        {
            Console.WriteLine($"{this.Name} is Eating!");
        }


        public override void EasyToSpot()
        {
            base.EasyToSpot();
        }


        public void Swim()
        {
            Console.WriteLine($"{this.Name} is swimming by {this.SwimSpeed} M/h speed");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{this.Name} is sleeping, ZzZzZZzz!");
        }
    }
}
