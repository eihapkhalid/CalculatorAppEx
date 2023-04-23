using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bl;
using Domains;

namespace UnitTestProject
{
    [TestClass]
    public class NormalCalculatorTest
    {
        private ClsNormalCal _normalCal;

        [TestInitialize]
        public void TestInitialize()
        {
            _normalCal = new ClsNormalCal();
        }

        #region TestAdd
        [TestMethod]
        public void TestAdd()
        {
            NormalCalModel model = new NormalCalModel();
            model.fNumber1 = 5;
            model.fNumber2 = 10;

            _normalCal.Add(model);

            // Check that the result is correct
            Assert.AreEqual(15, model.fNumber1 + model.fNumber2);
        }
        #endregion

        #region TestDiv
        [TestMethod]
        public void TestDiv()
        {
            NormalCalModel model = new NormalCalModel();
            model.fNumber1 = 20;
            model.fNumber2 = 4;

            _normalCal.Div(model);

            // Check that the result is correct
            Assert.AreEqual(5, model.fNumber1 / model.fNumber2);
        }
        #endregion

        #region TestMul
        [TestMethod]
        public void TestMul()
        {
            NormalCalModel model = new NormalCalModel();
            model.fNumber1 = 6;
            model.fNumber2 = 8;

            _normalCal.Mul(model);

            // Check that the result is correct
            Assert.AreEqual(48, model.fNumber1 * model.fNumber2);
        }
        #endregion

        #region TestSub
        [TestMethod]
        public void TestSub()
        {
            NormalCalModel model = new NormalCalModel();
            model.fNumber1 = 15;
            model.fNumber2 = 7;

            _normalCal.Sub(model);

            // Check that the result is correct
            Assert.AreEqual(8, model.fNumber1 - model.fNumber2);
        } 
        #endregion
    }
}
