﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AkhmetovRR.Sprint6.Task0.V10.Lib
{
    public class DataService : ISprint6Task0V10
    {
        public double Calculate(int x)
        {
            double res = Math.Round((2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + 4.1 * x * 2), 3);
            return res;
        }
    }
}
