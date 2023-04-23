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
            
            Console.WriteLine($"Cos({table.fSincNumber}) ={Math.Cos(table.fSincNumber)} \n\n **********************************");

        }
        #endregion

        #region Sin Function
        public void Sin(SincCalModel table)
        {
            Console.WriteLine($"Sin({table.fSincNumber}) ={Math.Sin(table.fSincNumber)} \n\n **********************************");
        }
        #endregion

        #region Tan Function
        public void tan(SincCalModel table)
        {
            Console.WriteLine($"tan({table.fSincNumber}) ={Math.Tan(table.fSincNumber)} \n\n **********************************");
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
