using Bl;
using Domains;


namespace UnitTestProject
{
    [TestClass]
    public class ClsNormalCalTest
    {
        private ClsNormalCal oClsNormalCal;
        private NormalCalModel _model;

        public  ClsNormalCalTest()
        {
            _model = new NormalCalModel();
            oClsNormalCal = new ClsNormalCal();
        }

        [TestMethod]
        public void TestAdd_ShouldReturnCorrectSum()
        {
            // Arrange
            _model.fNumber1 = 0.1F;
            _model.fNumber2 = 2;
            // Act
            oClsNormalCal.Add(_model);
            // Assert
            Assert.AreEqual(2.1, _model.Result, 0.0001);
        }

        [TestMethod]
        public void Div_ShouldReturnCorrectResult_WhenGivenTwoNumbers()
         {
            // Arrange
            _model.fNumber1 = 4.2F;
            _model.fNumber2 = 2;
            // Act
            oClsNormalCal.Div(_model);
            // Assert
            Assert.AreEqual(2.1, _model.Result, 0.0001);
        }

        [TestMethod]
        public void Mul_ShouldReturnCorrectResult_WhenGivenTwoNumbers()
        {
            // Arrange
            _model.fNumber1 = 3.1F;
            _model.fNumber2 = 5;
            // Act
            oClsNormalCal.Mul(_model);
            // Assert
            Assert.AreEqual(15.5, _model.Result, 0.0001);
        }

        [TestMethod]
        public void Sub_ShouldReturnCorrectResult_WhenGivenTwoNumbers()
        {
            // Arrange
            _model.fNumber1 = 5.1F;
            _model.fNumber2 = 3;
            // Act
            oClsNormalCal.Sub(_model);
            // Assert
            Assert.AreEqual(2.1, _model.Result, 0.0001);
        }
    }
}
