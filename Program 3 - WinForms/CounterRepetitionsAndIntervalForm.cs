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
        public CounterRepetitionsAndIntervalForm(CounterType CounterType) //params start with lowercase letter
        {
            InitializeComponent();
            counterType = CounterType; //so, if you have a lowercase letter parameter,
                                       //you have the same name for the constructor parameter and your private readonly field.
                                       //how is that ambiguity solved? by ALWAYS adding 'this.' prefix to class level instance members
                                       //(so, this.counterType = counterType;)

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
                //regarding timers...
                //I would use a different one (if I had to use a timer at all)
                //the one that you chose is a WinForms timer, i.e. it is tied to WinForms
                //Try perhaps System.Timers.Timer, as it is not tied to Winforms and you can use it in console as well
                //it has it's own 'issues' though... :)
                CounterTimer.Interval = interval; 
                CounterTimer.Tick += CounterTimer_Tick; //you are assigning a second event handler here, hence it does not work properly

                CounterTimer.Start();
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
