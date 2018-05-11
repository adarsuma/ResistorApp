using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResistorService.Interface;
using StructureContainer;
using StructureMap;

namespace ResistorTest
{
    [TestClass]
    public class ResistorBandTests
    {
        private readonly IContainer _container;
        private readonly IResistorBand _resistorBand;

        public ResistorBandTests()
        {
            _container = IocContainer.Container;
            _resistorBand = _container.GetInstance<IResistorBand>();
        }

        [TestMethod]
        public void CanGetRedBandInUppercaseValueTest()
        {
            var result = _resistorBand.GetBandValue("RED");
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void CanGetRedBandInLowercaseValueTest()
        {
            var result = _resistorBand.GetBandValue("red");
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void CanGetRedBandInMixedcaseValueTest()
        {
            var result = _resistorBand.GetBandValue("rEd");
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void CanGetBandNullTest()
        {
            var result = _resistorBand.GetBandValue(null);
            Assert.IsNotNull(result);
        }
    }
}
