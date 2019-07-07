namespace Program_3___WinForms
{
    partial class CounterRepetitionsAndIntervalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RepetitionsTextBox = new System.Windows.Forms.TextBox();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.CounterTimer = new System.Windows.Forms.Timer(this.components);
            this.ResultLabel = new System.Windows.Forms.Label();
            this.StartCounterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ilość powtórzeń";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interwał";
            // 
            // RepetitionsTextBox
            // 
            this.RepetitionsTextBox.Location = new System.Drawing.Point(150, 10);
            this.RepetitionsTextBox.Name = "RepetitionsTextBox";
            this.RepetitionsTextBox.Size = new System.Drawing.Size(180, 20);
            this.RepetitionsTextBox.TabIndex = 2;
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(150, 50);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(180, 20);
            this.IntervalTextBox.TabIndex = 3;
            // 
            // CounterTimer
            // 
            this.CounterTimer.Tick += new System.EventHandler(this.CounterTimer_Tick);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(10, 100);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(46, 13);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Rezultat";
            // 
            // StartCounterButton
            // 
            this.StartCounterButton.Location = new System.Drawing.Point(240, 100);
            this.StartCounterButton.Name = "StartCounterButton";
            this.StartCounterButton.Size = new System.Drawing.Size(90, 50);
            this.StartCounterButton.TabIndex = 5;
            this.StartCounterButton.Text = "Start";
            this.StartCounterButton.UseVisualStyleBackColor = true;
            this.StartCounterButton.Click += new System.EventHandler(this.StartCounterButton_Click);
            // 
            // CounterRepetitionsAndIntervalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 162);
            this.Controls.Add(this.StartCounterButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.RepetitionsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CounterRepetitionsAndIntervalForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RepetitionsTextBox;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.Timer CounterTimer;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button StartCounterButton;
    }
}