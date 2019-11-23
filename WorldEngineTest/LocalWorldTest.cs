using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldEngine;

namespace WorldEngineTest
{
    [TestClass]
    public class LocalWorldTest
    {
        [TestMethod]
        public void TestCreate()
        {
            var world = new World();
            Assert.IsNotNull(world);
        }
    }
}
