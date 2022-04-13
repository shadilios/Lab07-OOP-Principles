using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public class Sheep : Mammal, ICanRun
    {
        public Sheep(int runSpeed, string name, int age, string gender, int weight)
        {
            this.RunSpeed = runSpeed;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
        }

        public override bool EatsMeat
        {
            get
            {
                return false;
            }
        }

        public int RunSpeed { get; set; }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override int Age { get; set; }
        public override string Gender { get; set; }
        public override int Weight { get => base.Weight; set => base.Weight = value; }

        public override void Eat()
        {
            Console.WriteLine($"{this.Name} is Eating!");
        }


        public override bool ProduceMilk()
        {
            bool condition = false;
            if (this.Name == "Suzie")
            {
                Console.WriteLine("Suzie has health problems and can't produce milk!");

            }
            else
            {
                condition = base.ProduceMilk();
                base.ProduceMilk();
            }
            return condition;
        }

        public void Run()
        {
            Console.WriteLine($"{this.Name} is running by {this.RunSpeed} M/h speed");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{this.Name} is sleeping, ZzZzZZzz!");
        }
    }
}
