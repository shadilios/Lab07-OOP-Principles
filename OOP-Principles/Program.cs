using System;

namespace OOP_Principles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cow c = new Cow(5, "Suzie", 5, "Female", 200);
            Cow x = new Cow(2, "Adam", 3, "Male", 300);
            Cow z = new Cow(2, "Luna", 3, "Female", 300);


            c.ProduceMilk();
            x.ProduceMilk();
            z.ProduceMilk();
            c.Run();

            
        }
    }

}
 
