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
    public partial class CounterRepetitionsAndIntervalForm : Form
    {
        public CounterRepetitionsAndIntervalForm(CounterType CounterType)
        {
            InitializeComponent();
            counterType = CounterType;
        }

        private readonly CounterType counterType;

        int repetitionsNumber;

        private void StartCounterButton_Click(object sender, EventArgs e)
        {

            RepetitionsNumberProvider repetitionsNumberProvider = new RepetitionsNumberProvider();
            repetitionsNumber = repetitionsNumberProvider.GetRepetitionsNumber(counterType, RepetitionsTextBox.Text);
            IntervalProvider intervalProvider = new IntervalProvider();
            int interval = intervalProvider.GetInterval(counterType, IntervalTextBox.Text);

            if (repetitionsNumber <= 0 || interval <= 0)
            {
                ResultLabel.Text = "Sprawdź poprawność wprowadzonych danych. ";
                return;
            }
            else
            {
                CounterTimer.Interval = interval;
                CounterTimer.Start();
                CounterTimer.Tick += CounterTimer_Tick;
                ResultLabel.Text = "0";
                StartCounterButton.Text = "Odliczam...";
                StartCounterButton.Enabled = false;
            }
        }

        public int ticks;

        private void CounterTimer_Tick(object sender, EventArgs e)
        {
            ticks += 1;

            ResultLabel.Text = ticks.ToString();

            if (ticks == repetitionsNumber)
            {
                CounterTimer.Stop();
                StartCounterButton.Text = "Odliczanie zakończone";
            }
        }
    }
}
