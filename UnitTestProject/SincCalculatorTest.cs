using Bl;
using Domains;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class SincCalculatorTest
    {
        #region dependency injection
        private ClsSincCal oClsSincCal;
        private SincCalModel _model;
        public SincCalculatorTest()
        {
            _model = new SincCalModel();
            oClsSincCal = new ClsSincCal();
        }
        #endregion

        [TestMethod]
        #region TestSin

        public void TestSine_ShouldReturnCorrectValueForGivenAngle()
        {
            // Arrange
            _model.fSincNumber = 30;

            // Act
            oClsSincCal.Sin(_model);

            // Assert
            Assert.AreEqual(-0.9880316, _model.Result, 0.0001);
        }
        #endregion

        [TestMethod]
        #region TestTan
        public void TestTan_ShouldReturnCorrectValueForGivenAngle()
        {
            // Arrange
            _model.fSincNumber = 30;

            // Act
            oClsSincCal.tan(_model);

            // Assert
            Assert.AreEqual(-6.405331196646276, _model.Result, 0.0001);
        }
        #endregion

        [TestMethod]
        #region TestCos
        public void TestCos_ShouldReturnCorrectValueForGivenAngle()
        {
            // Arrange
            _model.fSincNumber = 30;

            // Act
            oClsSincCal.Cos(_model);

            // Assert
            Assert.AreEqual(0.15425144988758405, _model.Result, 0.0001);
        }
        #endregion
    }
}
