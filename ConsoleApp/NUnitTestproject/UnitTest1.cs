using ConsoleApp;
using NUnit.Framework;

namespace NUnitTestproject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            MathOperation obj = new MathOperation();
            int result = obj.Add(10, 30);
            Assert.AreEqual(40, result);  
        }
    }
}