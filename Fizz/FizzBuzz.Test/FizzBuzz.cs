using NUnit.Framework;
using System;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_When1_Returns()
        {
            //arrage
            int input = 1;

            //act
            string output = FizzBuzzer.GetValue(input);

            //assert
            Assert.AreEqual("1", output);
        }
    }
}
