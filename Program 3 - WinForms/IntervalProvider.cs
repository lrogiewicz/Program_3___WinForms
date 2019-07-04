﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3___WinForms
{
    class IntervalProvider //notice that this class is almost identical with 'repetitions number provider'. That's code duplication and could be improved (and simplified)
    //actually, is there any difference which class would you use to get the value? (i.e. use the IntervalProvider to get the RepetitionsNumber would be identical (except for the *1000 for text))
    {
        public int GetInterval(string counterType, string intervalInput, Dictionary<string, int> dictionary)
        {
            int interval;
            try
            {
                if (counterType == "Licznik 1 (liczbowy)")
                {
                    interval = Int32.Parse(intervalInput);
                    return interval;
                }
                else if (counterType == "Licznik 2 (tekstowy)")
                {
                    interval = 0;
                    string numberText = intervalInput.ToLower().Replace("-", "").Replace(" ", "");
                    for (int i = 0; i < dictionary.Count; i++)
                    {
                        if (numberText == dictionary.Keys.ElementAt(i))
                        {
                            interval = dictionary[dictionary.Keys.ElementAt(i)] * 1000; //why the numeral is *1000 but number is not? that's not consistent for the user:)
                            break;
                        }
                    }
                    return interval;
                }
                else
                {
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
