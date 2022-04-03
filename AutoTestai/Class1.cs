
//1 auto testu paskaita
using NUnit.Framework;
using System;
using System.Threading;

namespace AutoTestai
{
    public class Class1
    {

        [Test]
        public static void If4IsEven()
        {
            int leftover = 4 % 2;
            Assert.AreEqual(0, leftover, "4 is not even");

        }

        [Test]
        public static void TestNowIS19h()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(20, currentTime.Hour, "Now is not 20 hour");

        }

        [Test]
        public static void DalijasiIs3()
        {
            int leftover = 995 % 3;
            Assert.IsTrue(0 == leftover, "995 divides by 3 without any leftover");
        }

        [Test]
        public static void JeiSianTreciadienis()
        {
            Assert.AreEqual(DayOfWeek.Wednesday, DateTime.Now.DayOfWeek, "Now is not Wednesday");
        }

        [Test]
        public static void Palaukia5sekundes()
        {
            Thread.Sleep(5000);
            Assert.Pass();
        }

        [Test]
        public static void TestEvenNumberBetween1And10()
        {
            int counter = 0;
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    counter++;
                }
            }
            Assert.AreEqual(4, counter, "We not have 4 even numbers between 1 and 10");
        }
    }
}

