using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_3___WinForms
{
    class Counter
    {
        public int Index { get; set; }
        public int RepetitionsNumber { get; set; }
        public int Interval { get; set; }
        public Counter(int index, int repetitionsNumber, int interval)
        {
            this.Index = index;
            this.RepetitionsNumber = repetitionsNumber;
            this.Interval = interval;
        }
    }
}
