﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Triangle
    {
        public bool Triangle_Inequality(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (((a + b) > c) && ((a + c) > b) && ((b + c) > a))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
