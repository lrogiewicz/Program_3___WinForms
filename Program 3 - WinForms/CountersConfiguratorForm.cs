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
    public partial class CountersConfiguratorForm : Form
    {
        public CountersConfiguratorForm()
        {
            InitializeComponent();
        }

        CounterType counterType;
        int repetitionsNumber;
        int interval;
        int countersNumber;
        readonly List<Counter> counterList = new List<Counter>();
        int countersNumberIndex = 1;

        private void CreateCounters(object sender, EventArgs e)
        {
            CounterTypeProvider counterTypeProvider = new CounterTypeProvider();
            counterType = counterTypeProvider.GetCounterType(CounterTypeComboBox.Text);
            countersNumber = Decimal.ToInt32(CountersNumberNumericUpDown.Value);
            label5.Text = "Licznik nr " + countersNumberIndex.ToString();
            CountersCreatorButton.Enabled = false;
            CountersNumberNumericUpDown.Enabled = false;
            CounterTypeComboBox.Enabled = false;
            label5.Visible = true;
            label6.Visible = true;
            label12.Visible = true;
            RepetitionsNumberTextBox.Visible = true;
            IntervalTextBox.Visible = true;
            CountersConfiguratorButton.Visible = true;
        }

        private void CountersConfiguratorForm_Load(object sender, EventArgs e)
        {
            CounterTypeComboBox.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RepetitionsNumberProvider repetitionsNumberProvider = new RepetitionsNumberProvider();
            repetitionsNumber = repetitionsNumberProvider.GetRepetitionsNumber(counterType, RepetitionsNumberTextBox.Text);
            IntervalProvider intervalProvider = new IntervalProvider();
            interval = intervalProvider.GetInterval(counterType, IntervalTextBox.Text);
            if (repetitionsNumber <= 0 || interval <= 0)
            {
                ErrorsLabel.Text = "Sprawdź poprawność wprowadzonych danych. ";
                ErrorsLabel.Visible = true;
                return;
            }
            else
            {
                if (countersNumberIndex < countersNumber)
                {
                    counterList.Add(new Counter(countersNumberIndex, repetitionsNumber, interval));
                    RepetitionsNumberTextBox.Text = "";
                    IntervalTextBox.Text = "";
                    ErrorsLabel.Visible = false;
                    countersNumberIndex += 1;
                    label5.Text = "Licznik nr " + countersNumberIndex.ToString();
                }
                else if (countersNumberIndex == countersNumber)
                {
                    counterList.Add(new Counter(countersNumberIndex, repetitionsNumber, interval));
                    RepetitionsNumberTextBox.Text = "";
                    RepetitionsNumberTextBox.Enabled = false;
                    IntervalTextBox.Text = "";
                    IntervalTextBox.Enabled = false;
                    ErrorsLabel.Visible = false;
                    CountersConfiguratorButton.Enabled = false;
                    CountersResultFormsCreator.Visible = true;
                }
            }
        }

        private void CountersResultFormsCreator_Click(object sender, EventArgs e)
        {
            foreach (Counter counter in counterList)
            {
                ResultCountingForm resultCountingForm = new ResultCountingForm();
                resultCountingForm.StartCounter(counter.Index, counter.RepetitionsNumber, counter.Interval);
                resultCountingForm.Text = "Licznik nr " + counter.Index.ToString();
                resultCountingForm.Show();
            }
            counterList.Clear();
            CountersCreatorButton.Enabled = true;
            CountersNumberNumericUpDown.Enabled = true;
            CounterTypeComboBox.Enabled = true;
            label5.Visible = false;
            label6.Visible = false;
            label12.Visible = false;
            RepetitionsNumberTextBox.Visible = false;
            RepetitionsNumberTextBox.Enabled = true;
            IntervalTextBox.Visible = false;
            IntervalTextBox.Enabled = true;
            CountersConfiguratorButton.Visible = false;
            CountersConfiguratorButton.Enabled = true;
            CountersResultFormsCreator.Visible = false;
            CountersResultFormsCreator.Enabled = true;
            countersNumberIndex = 1;
        }
    }
}
