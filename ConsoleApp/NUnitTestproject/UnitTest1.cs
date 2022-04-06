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

        [Test]
        public void Test2()
        {
            MathOperation obj=new MathOperation();
            int result=obj.Sub(100, 30);
            Assert.AreEqual(70,result);
        }
    }
}