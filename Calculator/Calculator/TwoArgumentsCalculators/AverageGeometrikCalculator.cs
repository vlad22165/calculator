﻿using System;

namespace Calculator.TwoArgumentsCalculators
{
    public class AverageGeometrikCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Calculate Average Geometrik
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Sqrt(first * second);
        }
    }
}