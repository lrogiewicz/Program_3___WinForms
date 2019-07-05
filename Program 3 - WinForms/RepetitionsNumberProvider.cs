using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3___WinForms
{
    class RepetitionsNumberProvider
    {
        /// <summary>
        /// returs integer value of integer to which counter has to count
        /// it's the same as GetInputValue from InputValueProvider
        /// created for clarity 
        /// </summary>
        /// <param name="counterType">can be numerical or number</param>
        /// <param name="input">users input to be converted</param>
        /// <returns></returns>
        public int GetRepetitionsNumber(CounterType counterType, string input)
        {
            int repetitionsNumber;
            InputValueProvider inputValueProvider = new InputValueProvider(); //very well, invoking a class from a different class
            repetitionsNumber = inputValueProvider.GetInputValue(counterType, input);
            return repetitionsNumber;
        }
    }
}
