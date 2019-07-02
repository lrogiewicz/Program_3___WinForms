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
                if (counterType == "Licznik 1 (liczbowy)")
                {
                    repetitionsNumber = Int32.Parse(repetitionsInput);
                    return repetitionsNumber;
                }
                else if (counterType == "Licznik 2 (tekstowy)")
                {
                    repetitionsNumber = 0;
                    string numberText = repetitionsInput.ToLower().Replace("-", "").Replace(" ", "");
                    for (int i = 0; i <  dictionary.Count; i++)
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
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
