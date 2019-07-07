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
    public partial class CounterTypeAndNumberForm : Form
    {
        public CounterTypeAndNumberForm()
        {
            InitializeComponent();
        }

        public CounterType counterType;

        private void CreateCounters(object sender, EventArgs e)
        {
            CounterTypeProvider counterTypeProvider = new CounterTypeProvider();
            counterType = counterTypeProvider.GetCounterType(CounterTypeComboBox.Text);
            for (int i = 1; i<=CountersNumberNumericUpDown.Value; i++)
            {
                CounterRepetitionsAndIntervalForm counterRepetitionsAndIntervalForm = new CounterRepetitionsAndIntervalForm(this.counterType);
                counterRepetitionsAndIntervalForm.Text = "Licznik nr " + i;
                counterRepetitionsAndIntervalForm.Show();
            }
        }

        private void CounterTypeAndNumberForm_Load(object sender, EventArgs e)
        {
            CounterTypeComboBox.SelectedIndex = 0;
        }
    }
}
