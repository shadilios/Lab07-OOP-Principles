using System;
using Xunit;
using OOP_Principles;

namespace Test_OOP_Principles
{
    public class UnitTest1
    {

        Sheep a = new Sheep(5, "KOKO", 12, "Female", 70);
        Pigeon b = new Pigeon(2, "LULU", 6, "Female", 1);
        Cow c = new Cow(3, "Suzie", 7, "Male", 200);
        Shark d = new Shark(3, "Deni", 7, "Male", 400);
        Dolphin e = new Dolphin(3, "Lebra", 8, "Female", 360);




        //1- Test that each concrete animal exhibits 2 behaviors
        [Fact]
        public void TestAnimalsBehaviour()
        {
            Assert.True(!a.EatsMeat);
            Assert.True(!b.EatsMeat);
            Assert.True(!c.EatsMeat);
            Assert.True(d.EatsMeat);
            Assert.True(e.EatsMeat);
        }

        [Fact]
        public void TestInheritance()
        {
            Assert.True(typeof(ICanFly).IsAssignableFrom(typeof(Pigeon)));
            Assert.True(typeof(ICanSwim).IsAssignableFrom(typeof(Shark)));
            Assert.True(typeof(ICanRun).IsAssignableFrom(typeof(Cow)));

        }

        [Fact]
        public void TestInheritanceImplementation()
        {
            Assert.True(b.Fly());
        }

        [Fact]
        public void TestIsAnAnimal()
        {
            Assert.True(typeof(Animal).IsAssignableFrom(typeof(Cow)));

        }

        [Fact]
        public void TestFunctionsOverride()
        {
            //if overriding doesn't work, this would return false!

            Assert.True(!c.ProduceMilk());
        }
    }
}
