using Bl;
using CalculatorApp.Utlities;
using Domains;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Moq;
namespace UnitTestProject
{
    [TestClass]
    public class UiHelperMsTest
    {
        #region dependency injection
        private UiHelper oUiHelper;

        private ClsNormalCal oClsNormalCal;
        private NormalCalModel _model;
        public UiHelperMsTest()
        {
            oUiHelper = new UiHelper(new ClsNormalCal(), new ClsSincCal(), new NormalCalModel(), new SincCalModel());
            _model = new NormalCalModel();
            oClsNormalCal = new ClsNormalCal();

        }
        #endregion

        [TestMethod]
        #region TestNormalCalOptionScreen
        public void TestNormalCalOptionScreen_ShouldPrintCorrectOptions()
        {
            // Arrange
            var mockOutput = new Mock<TextWriter>();
            Console.SetOut(mockOutput.Object);

            // Act
            oUiHelper.NormalCalOptionScreen();

            // Assert
            mockOutput.Verify(x => x.WriteLine("press b to back  :\n"), Times.Once);
            mockOutput.Verify(x => x.WriteLine("press 1 to add number  :\n"), Times.Once);
            mockOutput.Verify(x => x.WriteLine("press 2 to sub number  :\n"), Times.Once);
            mockOutput.Verify(x => x.WriteLine("press 3 to mul number  :\n"), Times.Once);
            mockOutput.Verify(x => x.WriteLine("press 4 to div number  :\n"), Times.Once);
        }
        #endregion


        #region TestNormalCalOptionCase
        /* [TestMethod]
          public void TestNormalCalOptionCase_ShouldPerformCorrectOperation()
          {
              // Arrange
              var mockInput = new Mock<TextReader>();
              mockInput.SetupSequence(x => x.ReadLine())
                       .Returns("1")
                       .Returns("2")
                       .Returns("3")
                       .Returns("4")
                       .Returns("b");

              var mockOutput = new Mock<TextWriter>();
              Console.SetOut(mockOutput.Object);

              // Act
              oUiHelper.sVarSwitch = "1";
              _model.fNumber1 = 5;
              _model.fNumber2 = 6;
              oUiHelper.NormalCalOptionCase();


              // Assert
              Assert.AreEqual("1", oUiHelper.sVarSwitch);
              mockOutput.Verify(x => x.Close(), Times.Once);
              mockInput.Verify(x => x.ReadLine(), Times.Exactly(5));
              mockOutput.Verify(x => x.WriteLine("Enter a number:"), Times.Exactly(4));
              //mockOutput.Verify(x => x.WriteLine("Result: " + oClsNormalCal.Result), Times.Exactly(4));
              mockOutput.Verify(x => x.WriteLine("press b to back  :"), Times.Once);
              mockOutput.Verify(x => x.WriteLine("press 1 to add number  :"), Times.Once);
              mockOutput.Verify(x => x.WriteLine("press 2 to sub number  :"), Times.Once);
              mockOutput.Verify(x => x.WriteLine("press 3 to mul number  :"), Times.Once);
              mockOutput.Verify(x => x.WriteLine("press 4 to div number  :"), Times.Once);
          }*/
        #endregion



    }

}

