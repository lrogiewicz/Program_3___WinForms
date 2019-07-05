﻿using System;
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

        public int repetitionsNumber;

        //OK, probably I wasn't clear what I wanted you to do. 
        //you need to give proper correct names to the methods and objects, rather than adding descriptions like below
        // see hints of proper names

        //clicking on Button1 will start counter - ok, so the button should be called StartCounterButton and the method should be called StartCounterButton_Click
        //comboBox1 gets which type of counter should be executed (number or numeral) - so it should be called CounterTypeComboBox
        //textBox1 input provides repetitions number - RepetitionsNumberTextBox
        //textBox2 input provides interval number - IntervalTextBox
        //label6 shows result: counting from 0 to repetitions number with interaval - ResultLabel
        //uses timer1 ticks to raise counting values



        private void Button1_Click(object sender, EventArgs e) 
        {
            CounterTypeProvider counterTypeProvider = new CounterTypeProvider();
            CounterType counterType = counterTypeProvider.GetCounterType(comboBox1.Text);
            RepetitionsNumberProvider repetitionsNumberProvider = new RepetitionsNumberProvider();
            repetitionsNumber = repetitionsNumberProvider.GetRepetitionsNumber(counterType, textBox1.Text);
            IntervalProvider intervalProvider = new IntervalProvider();
            int interval = intervalProvider.GetInterval(counterType, textBox2.Text);

            if (repetitionsNumber <= 0 || interval <= 0)
            {
                label6.Text = "Sprawdź poprawność wprowadzonych danych. ";
                return;
            }
            else
            {
                timer1.Interval = interval;
                timer1.Start();
                timer1.Tick += Timer1_Tick;
                label6.Text = "0";
                button1.Text = "Odliczam...";
                button1.Enabled = false;
            }
        }

        public int ticks;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ticks = ticks + 1;
            label6.Text = ticks.ToString();
            if (ticks == repetitionsNumber)
            {
                timer1.Stop();
                button1.Text = "Odliczanie zakończone";
            }
        }
    }
}
