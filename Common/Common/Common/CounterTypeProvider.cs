using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class CounterTypeProvider
    {
        private static readonly string NumberCounterName = "liczbowy";
        private static readonly string NumeralCounterName = "tekstowy";
        /// <summary>
        /// returns counters type
        /// </summary>
        /// <param name="counterName">string which tells which counter type is choosen</param>
        /// <returns></returns>
        public static CounterType GetCounterType(string counterName)
        {
            if (String.Equals(counterName, NumberCounterName, StringComparison.OrdinalIgnoreCase))
            {
                return CounterType.Number;
            }
            else if (String.Equals(counterName, NumeralCounterName, StringComparison.OrdinalIgnoreCase))
            {
                return CounterType.Numeral;
            }
            return CounterType.Unrecognized;
        }
    }
}
