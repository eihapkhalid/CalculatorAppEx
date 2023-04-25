using Bl;
using Domains;
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
        private ClsSincCal oClsSincCal;

        private SincCalModel _model;

        public SincCalculatorTest()
        {
            _model = new SincCalModel();
            oClsSincCal = new ClsSincCal();
        }


        #region TestSin
        [TestMethod]
        public void TestSin()
        {
            // Arrange
            _model.fSincNumber = 30;

            // Act
            oClsSincCal.Sin(_model);

            // Assert
            Assert.AreEqual(-0.9880316, _model.Result, 0.0001);
        }
        #endregion

        #region TestTan
        [TestMethod]
        public void TestTan()
        {
            // Arrange
            _model.fSincNumber = 30;

            // Act
            oClsSincCal.tan(_model);

            // Assert
            Assert.AreEqual(-6.405331196646276, _model.Result, 0.0001);
        }
        #endregion

        #region TestCos
        [TestMethod]
        public void TestCosn()
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
