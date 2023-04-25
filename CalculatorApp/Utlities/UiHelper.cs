using Bl;
using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Utlities
{
    public class UiHelper
    {
        #region dependency injection
        IBusinessLayer<NormalCalModel> oClsNormalCal;
        IBusinessLayer<SincCalModel> oClsSincCal;
        NormalCalModel normalCal;
        SincCalModel sincCal;
        public string sVarSwitch = string.Empty;

        public UiHelper(IBusinessLayer<NormalCalModel> normalCalModel, IBusinessLayer<SincCalModel> sincCalModel, NormalCalModel _normalCal, SincCalModel _sincCal)
        {
            oClsNormalCal = normalCalModel;
            oClsSincCal = sincCalModel;
            normalCal = _normalCal;
            sincCal = _sincCal;
            
        }
        #endregion
        
        #region MainOptions
        public void MainOptions()
        {
            Console.WriteLine("*** wlc to cal app :\n");
            Console.WriteLine("press e to exit  :\n");
            Console.WriteLine("press 1 to normal calculator :\n");
            Console.WriteLine("press 2 to scientific calculator :\n");
        } 
        #endregion

        #region NormalCalOptions

        public void NormalCalOptions()
        {
            
            while (sVarSwitch != "b")
            {
                NormalCalOptionScreen();
                sVarSwitch = Console.ReadLine();
                NormalCalOptionCase();
            }
        }
        #endregion
        #region NormalCalOptionScreen
        public void NormalCalOptionScreen()
        {
            Console.WriteLine("press b to back  :\n");
            Console.WriteLine("press 1 to add number  :\n");
            Console.WriteLine("press 2 to sub number  :\n");
            Console.WriteLine("press 3 to mul number  :\n");
            Console.WriteLine("press 4 to div number  :\n");
        }
        #endregion

        #region NormalCalOptionCase
        public void NormalCalOptionCase()
        {
            switch (sVarSwitch)
            {
                case "b":
                   // Console.Clear();
                    sVarSwitch = "b";
                    break;
                case "1":
                    //Console.Clear();
                    nGetDataFromUser();
                    oClsNormalCal.Add(normalCal);
                    break;
                case "2":
                    //Console.Clear();
                    nGetDataFromUser();
                    oClsNormalCal.Sub(normalCal);
                    break;
                case "3":
                    //Console.Clear();
                    nGetDataFromUser();
                    oClsNormalCal.Mul(normalCal);
                    break;
                case "4":
                    //Console.Clear();
                    nGetDataFromUser();
                    oClsNormalCal.Div(normalCal);
                    break;
            }
        } 
        #endregion

        #region SinCalOptions
        public void SinCalOptions()
        {
            string sVarSwitch = string.Empty;
            while (sVarSwitch != "b")
            {
                Console.WriteLine("press b to back  :\n");
                Console.WriteLine("press 1 to sin (number)  :\n");
                Console.WriteLine("press 2 to cos (number)  :\n");
                Console.WriteLine("press 3 to tan (number)  :\n");

                sVarSwitch = Console.ReadLine();
                switch (sVarSwitch)
                {
                    case "b":
                        sGetDataFromUser();
                        sVarSwitch = "b";
                        break;
                    case "1":
                        sGetDataFromUser();
                        oClsSincCal.Sin(sincCal);
                        break;
                    case "2":
                        sGetDataFromUser();
                        oClsSincCal.Cos(sincCal);
                        break;
                    case "3":
                        sGetDataFromUser();
                        oClsSincCal.tan(sincCal);
                        break;
                }
            }
        }
        #endregion

        #region normal GetDataFromUser
        public void nGetDataFromUser()
        {
            Console.WriteLine("plz enter F number");
            float fParseNumber = 0;
            bool bCanConvert = float.TryParse(Console.ReadLine(), out fParseNumber);
            if (bCanConvert)
            {
                normalCal.fNumber1 = fParseNumber;
            }
            else
            {
                Console.WriteLine("plz enter valid Number");
            }

            Console.WriteLine("plz enter S number");
            bCanConvert = float.TryParse(Console.ReadLine(), out fParseNumber);
            if (bCanConvert)
            {
                normalCal.fNumber2 = fParseNumber;

            }
            else
            {
                Console.WriteLine("plz enter valid Number");
            }
        }
        #endregion

        #region since GetDataFromUser
        public void sGetDataFromUser()
        {
            Console.Clear();
            Console.WriteLine("plz enter ur number");

            float fUserNumber;
            bool bICanConvert = float.TryParse(Console.ReadLine(), out fUserNumber);
            if (bICanConvert)
            {
                sincCal.fSincNumber = fUserNumber;

            }
            else
            {
                Console.WriteLine("enter a valid number");
            }
        } 
        #endregion
    }
}
