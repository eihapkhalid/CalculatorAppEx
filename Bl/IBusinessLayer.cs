using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public interface IBusinessLayer<t>
    {
        void Add(t table);
        void Sub(t table);
        void Mul(t table);
        void Div(t table);
        void Cos(t table);
        void Sin(t table);
        void tan(t table);
    }
}
