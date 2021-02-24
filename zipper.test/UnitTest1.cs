using NUnit.Framework;

namespace zipper.test
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
            Assert.Throws<System.IO.IOException>(() => {
                zipper.ZipperLogic.Zip(@".", ".");
            });
        }

        [Test]

        public void Test2()
        {
            Assert.Throws<System.IO.DirectoryNotFoundException>(() => {
                zipper.ZipperLogic.Zip(@"/test", "/test/test2.zip");
            });
        }
    }
}