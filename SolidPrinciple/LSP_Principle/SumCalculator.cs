using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP_Principle
{
    public class SumCalculator:Calculator
    {
        public SumCalculator(int[] numbers)
        : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Sum();
    }
}
