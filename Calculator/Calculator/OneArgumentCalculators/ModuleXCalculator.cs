﻿using System;

namespace Calculator.OneArgumentCalculators
{
    public class ModuleXCalculator : IOneArgumentCalculator
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}