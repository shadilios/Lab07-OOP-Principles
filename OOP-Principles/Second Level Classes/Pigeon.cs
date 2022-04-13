using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public class Pigeon : Bird, ICanFly
    {
        public Pigeon(int flySpeed, string name, int age, string gender, int weight)
        {
            this.FlySpeed = flySpeed;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
        }

        public int FlySpeed { get; set; }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override int Age { get; set; }
        public override string Gender { get; set; }
        public override int Weight { get => base.Weight; set => base.Weight = value; }
        public override bool EatsMeat
        {
            get
            {
                return false;
            }
        }

        public override void BuildNest()
        {
            base.BuildNest();
        }

        public override void Eat()
        {
            Console.WriteLine($"{this.Name} is Eating!");

        }

        public bool Fly()
        {
            bool inheritnaceWorks = true;

            Console.WriteLine($"{this.Name} is Flying by {this.FlySpeed} M/h speed");

            return inheritnaceWorks;


        }

        public override void Sleep()
        {
            Console.WriteLine($"{this.Name} is Sleeping!!!");
        }
    }
}
