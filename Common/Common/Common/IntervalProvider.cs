using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{


    public static class IntervalProvider
    {
        /// <summary>
        /// returns interval value between counting
        /// for numeral counter it's measured in seconds
        /// for number counter it's measured in miliseconds
        /// </summary>
        /// <param name="counterType">can be number or numerical</param>
        /// <param name="input">users input</param>
        /// <returns></returns>
        public static int GetInterval(CounterType counterType, string input)
        {
            int interval;
            InputValueProvider inputValueProvider = new InputValueProvider();
            interval = inputValueProvider.GetInputValue(counterType, input);
            switch (counterType)
            {
                case CounterType.Number:
                    return interval;
                case CounterType.Numeral:
                    return interval * 1000;
                default:
                    return 0;
            }
        }
    }
}
