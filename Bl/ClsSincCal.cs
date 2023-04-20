using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class ClsSincCal : IBusinessLayer<SincCalModel>
    {


        #region Cos Function
        public void Cos(SincCalModel table)
        {
            Console.WriteLine("plz enter ur number");

            float fUserNumber;
            bool bICanConvert = float.TryParse(Console.ReadLine(), out fUserNumber);
            if (bICanConvert)
            {
                Console.WriteLine($"Cos({fUserNumber}) ={Math.Cos(fUserNumber)} \n\n **********************************");
            }
            else
            {
                Console.WriteLine("enter a valid number");
            }

        }
        #endregion

        #region Sin Function
        public void Sin(SincCalModel table)
        {
            Console.WriteLine("plz enter ur number");

            float fUserNumber;
            bool bICanConvert = float.TryParse(Console.ReadLine(), out fUserNumber);
            if (bICanConvert)
            {
                Console.WriteLine($"Sin({fUserNumber}) ={Math.Sin(fUserNumber)}\n\n **********************************");
            }
            else
            {
                Console.WriteLine("plz enter a valid number");
            }
        }
        #endregion

        #region Tan Function
        public void tan(SincCalModel table)
        {
            Console.WriteLine("plz enter ur number");

            float fUserNumber;
            bool bICanConvert = float.TryParse(Console.ReadLine(), out fUserNumber);
            if (bICanConvert)
            {
                Console.WriteLine($"Tan({fUserNumber}) ={Math.Tan(fUserNumber)}\n\n **********************************");
            }
            else
            {
                Console.WriteLine("plz enter a valid number");
            }
        }
        #endregion

        #region Ignower Functions
        public void Add(SincCalModel table)
        {
        }

        public void Div(SincCalModel table)
        {
        }

        public void Mul(SincCalModel table)
        {
        }

        public void Sub(SincCalModel table)
        {
        }
        #endregion
    }
}
