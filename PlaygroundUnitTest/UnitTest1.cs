using NUnit.Framework;
using Playground;

namespace Tests
{
    public class Tests
    {
        private Demo1 _demo;

        [SetUp]
        public void Setup()
        {
            _demo = new Demo1();
        }

        [Test]
        public void Test1()
        {
            _demo.Func1();
            Assert.Pass();
        }

        [TestCase("hello world.")]
        public void Test1(string text)
        {
            _demo.Func1(text);
            Assert.Pass();
        }

        [TestCase(999)]
        public void Test1(int value)
        {
            _demo.Func1(value);
            Assert.Pass();
        }
    }
}