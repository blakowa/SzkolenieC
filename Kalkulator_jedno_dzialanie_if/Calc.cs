using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_jedno_dzialanie_if
{
    public static class Calc
    {

        public static decimal Sum(decimal First, decimal Sec)
        {
            return First + Sec;
        }

        public static decimal Minus(decimal First, decimal Sec)
        {
            return First - Sec;
        }

        public static decimal Multi(decimal First, decimal Sec)
        {
            return First * Sec;
        }

        public static decimal Div(decimal First, decimal Sec)
        {
            return First / Sec;
        }

    }
}
