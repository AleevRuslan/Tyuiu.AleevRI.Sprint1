﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AleevRI.Sprint1.Task4.V17.Lib
{
    public class DataService : ISprint1Task4V18
    {
        
        public double Calculate(double x, double y)
        {
            var res = 1 / (Math.Sqrt(x - 5 * y));
            return Math.Round(res, 3); 
        }
    }
}
