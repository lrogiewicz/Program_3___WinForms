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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetRepetitionsNumber()
        {
            int repetitionsNumber;
            try
            {
                repetitionsNumber = Int32.Parse(textBox1.Text);
                return repetitionsNumber;
            }
            catch (Exception)
            {
                label6.Text = "Podano błędną ilość powtórzeń. ";
                return 0;
            }
        }

        private int GetInterval()
        {
            int interval;
            try
            {
                interval = Int32.Parse(textBox2.Text);
                return interval;
            }
            catch (Exception)
            {
                label6.Text = "Podano błędną wartość interwału. ";
                return 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int repetitionsNumber = GetRepetitionsNumber();
            if (repetitionsNumber == 0)
            {
                return;
            }

            int interval = GetInterval();
            if (interval == 0)
            {
                return;
            }

            timer1.Interval = interval;
            timer1.Start();
            timer1.Tick += Timer1_Tick;
            
        }

        int ticks;
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = ticks.ToString();
            ticks = ticks + 1;
            if (ticks == GetRepetitionsNumber())
            {
                timer1.Stop();
            }
        }
    }
}
