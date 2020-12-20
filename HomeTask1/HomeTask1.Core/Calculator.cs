using System;

namespace HomeTask1.Core
{
    public class Calculator
    {
        private readonly IFormatProvider _formatProvider;
        private readonly int _round;

        public Calculator(IFormatProvider formatProvider, int round)
        {
            formatProvider = _formatProvider;
            round = _round;
        }

        public double Calculate(string left, string right, string calcOperator)
        {
            return double.NaN;
        }


        public double Summ(string left, string right)
        { 
        var result= double.NaN;

            if (double.TryParse(left, System.Globalization.NumberStyles.Float, _formatProvider, out var leftDouble)
                && double.TryParse(right, System.Globalization.NumberStyles.Float, _formatProvider, out var rightDouble))
            {
                result = Math.Round( leftDouble + rightDouble,_round);
            }
            return result;
        }
    }
}
