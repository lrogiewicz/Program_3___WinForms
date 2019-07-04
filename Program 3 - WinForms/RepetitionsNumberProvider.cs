using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3___WinForms
{
    class RepetitionsNumberProvider
    {
        public int GetRepetitionsNumber(string counterType, string repetitionsInput, Dictionary<string, int> dictionary)
        {
            int repetitionsNumber;
            try
            {
                if (counterType == "Licznik 1 (liczbowy)") //magic strings are not good (see for example https://blog.goyello.com/2014/12/30/magic-strings-no-more/)
                {
                    repetitionsNumber = Int32.Parse(repetitionsInput);
                    return repetitionsNumber;
                }
                else if (counterType == "Licznik 2 (tekstowy)")
                {
                    repetitionsNumber = 0;
                    string numberText = repetitionsInput.ToLower().Replace("-", "").Replace(" ", "");//intersting way to handle cases like 'twenty-two' or 'twenty two'
                    for (int i = 0; i <  dictionary.Count; i++) //there are easier ways to get value out of dictionary
                    {
                        if (numberText == dictionary.Keys.ElementAt(i))
                        {
                            repetitionsNumber = dictionary[dictionary.Keys.ElementAt(i)];
                            break;
                        }
                    }
                    return repetitionsNumber;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception) //it's a bit risky that you're not handling the errors in any way
            {
                return 0;
            }
        }
    }
}
