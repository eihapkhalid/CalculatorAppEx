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
        IBusinessLayer<NormalCalModel> oClsNormalCal;
        IBusinessLayer<SincCalModel> oClsSincCal;
        public UiHelper(IBusinessLayer<NormalCalModel> normalCalModel, IBusinessLayer<SincCalModel> sincCalModel)
        {
            oClsNormalCal = normalCalModel;
            oClsSincCal = sincCalModel;
        }
        public void MainOptions()
        {



            Console.WriteLine("*** wlc to cal app :\n");
            Console.WriteLine("press e to exit  :\n");
            Console.WriteLine("press 1 to normal calculator :\n");
            Console.WriteLine("press 2 to scientific calculator :\n");
            Console.WriteLine("press 3 to proff calculator  :\n");
        }

        #region NormalCalOptions

        public void NormalCalOptions(NormalCalModel model)
        {

            string sVarSwitch = string.Empty;
            while (sVarSwitch != "b")
            {
                Console.WriteLine("press b to back  :\n");
                Console.WriteLine("press 1 to add number  :\n");
                Console.WriteLine("press 2 to sub number  :\n");
                Console.WriteLine("press 3 to mul number  :\n");
                Console.WriteLine("press 4 to div number  :\n");

                sVarSwitch = Console.ReadLine();


                switch (sVarSwitch)
                {
                    case "b":
                        Console.Clear();
                        sVarSwitch = "b";
                        break;
                    case "1":
                        Console.Clear();


                        oClsNormalCal.Add(model);
                        break;
                    case "2":
                        Console.Clear();

                        oClsNormalCal.Sub(model);
                        break;
                    case "3":
                        Console.Clear();

                        oClsNormalCal.Mul(model);
                        break;
                    case "4":
                        Console.Clear();

                        oClsNormalCal.Div(model);
                        break;
                }

            }
        }
        #endregion


        #region SinCalOptions
        public void SinCalOptions(SincCalModel sincmodel)
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
                        Console.Clear();
                        sVarSwitch = "b";
                        break;
                    case "1":
                        Console.Clear();

                        oClsSincCal.Sin(sincmodel);
                        break;
                    case "2":
                        Console.Clear();

                        oClsSincCal.Cos(sincmodel);
                        break;
                    case "3":
                        Console.Clear();

                        oClsSincCal.tan(sincmodel);
                        break;

                }

            }
        }
        #endregion
    }
}
