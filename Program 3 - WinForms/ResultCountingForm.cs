using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3___WinForms
{
    public partial class ResultCountingForm : Form
    {
        public ResultCountingForm()
        {
            InitializeComponent();
        }

        int repetitionsNumber;

        public void StartCounter(int index, int repetitionsNumber, int interval)
        {
            this.repetitionsNumber = repetitionsNumber;
            RepetitionsLabel.Text = "Ilość powtórzeń: " + repetitionsNumber.ToString();
            IntervalLabel.Text = "Interwał: " + interval.ToString();
            CounterTimer.Interval = interval;
            CounterTimer.Start();
            CounterTimer.Tick += CounterTimer_Tick;
            ResultLabel.Text = "0";
        }

        public int ticks;

        private void CounterTimer_Tick(object sender, EventArgs e)
        {
            ticks += 1;

            ResultLabel.Text = ticks.ToString();

            if (ticks == repetitionsNumber)
            {
                CounterTimer.Stop();
            }
        }
    }
}
