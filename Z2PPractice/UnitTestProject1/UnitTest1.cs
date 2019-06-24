using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z2PPractice;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add2ParamCorrectResult()
        {
            Assert.AreEqual(7, Math.Add(5, 2));
            Assert.AreEqual(15, Math.Add(7, 8));
        }
    }
}
