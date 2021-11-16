using ExampleWebApplication.Models;
using NUnit.Framework;

namespace ViewTestExample
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
            Assert.AreEqual(new ErrorViewModel().RequestId, null);
        }
    }
}

