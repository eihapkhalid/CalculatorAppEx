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
        private ClsSincCal _sincCal;

        [TestInitialize]
        public void TestInitialize()
        {
            _sincCal = new ClsSincCal();
        }

        #region TestSin
        [TestMethod]
        public void TestSin()
        {
            SincCalModel model = new SincCalModel();
            model.fSincNumber = 30;


            _sincCal.Sin(model);

            // Check that the result is correct
            Assert.AreEqual(-0.9880316240928618, Math.Sin(model.fSincNumber));
        }
        #endregion

        #region TestTan
        [TestMethod]
        public void TestTan()
        {
            SincCalModel model = new SincCalModel();
            model.fSincNumber = 30;


            _sincCal.tan(model);

            // Check that the result is correct
            Assert.AreEqual(-6.405331196646276, Math.Tan(model.fSincNumber));
        }
        #endregion

        #region TestCos
        [TestMethod]
        public void TestCosn()
        {
            SincCalModel model = new SincCalModel();
            model.fSincNumber = 30;


            _sincCal.Cos(model);

            // Check that the result is correct
            Assert.AreEqual(0.15425144988758405, Math.Cos(model.fSincNumber));
        }
        #endregion
    }
}
