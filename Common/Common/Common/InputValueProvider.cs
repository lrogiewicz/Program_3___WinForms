using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class InputValueProvider
    {
    /// <summary>
    /// returns integer value of users input depending of choosen counter
    /// </summary>
    /// <param name="counterType">can be numerical or number</param>
    /// <param name="input">users input to be converted</param>
    /// <returns></returns>
        public int GetInputValue(CounterType counterType, string input)
        {
            int inputValue;
            try
            {
                switch (counterType)
                {
                    case CounterType.Number:
                        inputValue = Int32.Parse(input);
                        return inputValue;
                    case CounterType.Numeral:
                        NumeralParser numeralParser = new NumeralParser();
                        int numeralValue = numeralParser.GetNumeralValue(input);
                        inputValue = numeralValue;
                        return inputValue;
                    default:
                        return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
