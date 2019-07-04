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

        private void Button1_Click(object sender, EventArgs e) //again, method names... what is button1, textbox1, textbox2, comobobox1?
        {
            RepetitionsNumberProvider repetitionsNumberProvider = new RepetitionsNumberProvider();
            int repetitionsNumber = repetitionsNumberProvider.GetRepetitionsNumber(comboBox1.Text, textBox1.Text, numbersDictionary);
            IntervalProvider intervalProvider = new IntervalProvider();
            int interval = intervalProvider.GetInterval(comboBox1.Text, textBox2.Text, numbersDictionary);

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
            RepetitionsNumberProvider repetitionsNumberProvider = new RepetitionsNumberProvider(); //if you don't want to create a new instance of the provider,
                                                                                                   //then you need to store the reference as a class-level variable
                                                                                                   //however, it's not bad to create new instance when you need to use it again
            int repetitionsNumber = repetitionsNumberProvider.GetRepetitionsNumber(comboBox1.Text, textBox1.Text, numbersDictionary);
            //are you sure you need to calculate the repetitions number with each tick?

            ticks = ticks + 1;
            label6.Text = ticks.ToString();
            if (ticks == repetitionsNumber)
            {
                timer1.Stop();
                button1.Text = "Odliczanie zakończone";
            }
        }

        public Dictionary<string, int> numbersDictionary = new Dictionary<string, int>() //and if we had 1000?:)
        //probably it would make sense to extract this 'conversion' to separate class (for clarity)
        //or alternatively, it could be an internal field of the RepetitionsNumberProvider class
        {
            {"one", 1},{"two", 2},{"three", 3},{"four", 4},{"five", 5},
            {"six", 6},{"seven", 7},{"eight", 8},{"nine", 9},{"ten", 10},
            {"eleven", 11},{"twelve", 12},{"thirteen", 13},{"fourteen", 14},{"fifteen", 15},
            {"sixteen", 16},{"seventeen", 17},{"eighteen", 18},{"nineteen", 19},{"twenty", 20},
            {"twentyone", 21},{"twentytwo", 22},{"twentythree", 23},{"twentyfour", 24},{"twentyfive", 25},
            {"twentysix", 26},{"twentyseven", 27},{"twentyeight", 28},{"twentynine", 29},{"thirty", 30},
            {"thirtyone", 31},{"thirtytwo", 32},{"thirtythree", 33},{"thirtyfour", 34},{"thirtyfive", 35},
            {"thirtysix", 36},{"thirtyseven", 37},{"thirtyeight", 38},{"thirtynine", 39},{"forty", 40},
            {"fortyone", 41},{"fortytwo", 42},{"fortythree", 43},{"fortyfour", 44},{"fortyfive", 45},
            {"fortysix", 46},{"fortyseven", 47},{"fortyeight", 48},{"fortynine", 49},{"fifty", 50},
            {"fiftyone", 51},{"fiftytwo", 52},{"fiftythree", 53},{"fiftyfour", 54},{"fiftyfive", 55},
            {"fiftysix", 56},{"fiftyseven", 57},{"fiftyeight", 58},{"fiftynine", 59},{"sixty", 60},
            {"sixtyone", 61},{"sixtytwo", 62},{"sixtythree", 63},{"sixtyfour", 64},{"sixtyfive", 65},
            {"sixtysix", 66},{"sixtyseven", 67},{"sixtyeight", 68},{"sixtynine", 69},{"seventy", 70},
            {"seventyone", 71},{"seventytwo", 72},{"seventythree", 73},{"seventyfour", 74},{"seventyfive", 75},
            {"seventysix", 76},{"seventyseven", 77},{"seventyeight", 78},{"seventynine", 79},{"eighty", 80},
            {"eightyone", 81},{"eightytwo", 82},{"eightythree", 83},{"eightyfour", 84},{"eightyfive", 85},
            {"eightysix", 86},{"eightyseven", 87},{"eightyeight", 88},{"eightynine", 89},{"ninety", 90},
            {"ninetyone", 91},{"ninetytwo", 92},{"ninetythree", 93},{"ninetyfour", 94},{"ninetyfive", 95},
            {"ninetysix", 96},{"ninetyseven", 97},{"ninetyeight", 98},{"ninetynine", 99},{"hundred", 100},
        };
    }
}
