using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructureMap;
using ResistorService.Interface;
using StructureContainer;

namespace ResistorTest
{
    /// <summary>
    /// Summary description for ResistorCalculatorTests
    /// </summary>
    [TestClass]
    public class ResistorCalculatorTests
    {
        private readonly IContainer _container;
        private readonly IOhmValueCalculator _resistorCalculator;

        public ResistorCalculatorTests()
        {
            _container = IocContainer.Container;
            _resistorCalculator = _container.GetInstance<IOhmValueCalculator>();
        }

        [TestMethod]
        public void CanCalculateYellowVioletRedGoldTest()
        {
            var result = _resistorCalculator.CalculateOhmValue("YELLOW", "VIOLET", "RED");
            Assert.IsTrue(result == 4700);
        }

        [TestMethod]
        public void CanCalculateToleranceTest()
        {
            var result = _resistorCalculator.CalculateTolerance("GOLD", 4700);
            Assert.IsTrue(result[0] == 4465);
            Assert.IsTrue(result[1] == 4935);
        }

        [TestMethod]
        public void CanCalculateEmptyToleranceTest()
        {
            var result = _resistorCalculator.CalculateTolerance("", 4700);
            Assert.IsTrue(result[0] == 3760);
            Assert.IsTrue(result[1] == 5640);
        }

        [TestMethod]
        public void CanCalculateEmptyToleranceZeroOhmsTest()
        {
            var result = _resistorCalculator.CalculateTolerance("", 0);
            Assert.IsTrue(result.Count == 2);
        }

        [TestMethod]
        public void CanCalculateNullToleranceZeroOhmsTest()
        {
            var result = _resistorCalculator.CalculateTolerance(null, 0);
            Assert.IsTrue(result.Count == 2);
        }
    }
}
