using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class ClsNormalCal : IBusinessLayer<NormalCalModel>
    {
        #region Add Function
        public void Add(NormalCalModel table)
        {
            Console.WriteLine("plz enter F number");
            float fParseNumber = 0;
            bool bCanConvert = float.TryParse(Console.ReadLine(), out fParseNumber);
            if (bCanConvert)
            {
                table.fNumber1 = fParseNumber;
            }
            else
            {
                Console.WriteLine("plz enter valid Number");
            }

            Console.WriteLine("plz enter S number");
            bCanConvert = float.TryParse(Console.ReadLine(), out fParseNumber);
            if (bCanConvert)
            {
                table.fNumber2 = fParseNumber;
            }
            else
            {
                Console.WriteLine("plz enter valid Number");
            }

            Console.WriteLine($"result of sum = {table.fNumber1 + table.fNumber2}\n\n **************************");
        }

        #endregion

        #region Div Function
        public void Div(NormalCalModel table)
        {
            Console.WriteLine("plz enter FIREST number");
            float fParseNumber = 0;
            bool bCanConvert = float.TryParse(Console.ReadLine(), out fParseNumber);
            if (bCanConvert)
            {
                table.fNumber1 = fParseNumber;
            }
            else
            {
                Console.WriteLine("plz enter valid Number");
            }

            Console.WriteLine("plz enter SECOND number");
            bCanConvert = float.TryParse(Console.ReadLine(), out fParseNumber);
            if (bCanConvert)
            {
                table.fNumber2 = fParseNumber;
            }
            else
            {
                Console.WriteLine("plz enter valid Number");
            }

            Console.WriteLine($"result of Div = {table.fNumber1 / table.fNumber2}\n\n **************************");
        }
        #endregion

        #region Mul Function
        public void Mul(NormalCalModel table)
        {
            Console.WriteLine("plz enter FIRST number");
            float fParseNumber = 0;
            bool bCanConvert = float.TryParse(Console.ReadLine(), out fParseNumber);
            if (bCanConvert)
            {
                table.fNumber1 = fParseNumber;
            }
            else
            {
                Console.WriteLine("plz enter valid Number");
            }

            Console.WriteLine("plz enter SECOND number");
            bCanConvert = float.TryParse(Console.ReadLine(), out fParseNumber);
            if (bCanConvert)
            {
                table.fNumber2 = fParseNumber;
            }
            else
            {
                Console.WriteLine("plz enter valid Number");
            }

            Console.WriteLine($"result of Mul = {table.fNumber1 * table.fNumber2} \n\n **************************");
        }


        #endregion

        #region Sub Function
        public void Sub(NormalCalModel table)
        {
            Console.WriteLine("plz enter FIRST number");
            float fParseNumber = 0;
            bool bCanConvert = float.TryParse(Console.ReadLine(), out fParseNumber);
            if (bCanConvert)
            {
                table.fNumber1 = fParseNumber;
            }
            else
            {
                Console.WriteLine("plz enter valid Number");
            }

            Console.WriteLine("plz enter SECOND number");
            bCanConvert = float.TryParse(Console.ReadLine(), out fParseNumber);
            if (bCanConvert)
            {
                table.fNumber2 = fParseNumber;
            }
            else
            {
                Console.WriteLine("plz enter valid Number");
            }

            Console.WriteLine($"result of Sub = {table.fNumber1 - table.fNumber2} \n\n **************************");
        }


        #endregion

        #region Ignower Functons
        public void tan(NormalCalModel table)
        {
        }
        public void Sin(NormalCalModel table)
        {
        }
        public void Cos(NormalCalModel table)
        {
        }
        #endregion
    }
}
