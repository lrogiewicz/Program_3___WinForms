namespace Program_3___WinForms
{
    partial class ResultCountingForm
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
            this.RepetitionsLabel = new System.Windows.Forms.Label();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.CounterTimer = new System.Windows.Forms.Timer(this.components);
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RepetitionsLabel
            // 
            this.RepetitionsLabel.AutoSize = true;
            this.RepetitionsLabel.Location = new System.Drawing.Point(10, 10);
            this.RepetitionsLabel.Name = "RepetitionsLabel";
            this.RepetitionsLabel.Size = new System.Drawing.Size(81, 13);
            this.RepetitionsLabel.TabIndex = 0;
            this.RepetitionsLabel.Text = "Ilość powtórzeń";
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(10, 30);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(46, 13);
            this.IntervalLabel.TabIndex = 1;
            this.IntervalLabel.Text = "Interwał";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(10, 60);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(100, 26);
            this.ResultLabel.TabIndex = 4;
            this.ResultLabel.Text = "Rezultat";
            // 
            // ResultCountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 121);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.RepetitionsLabel);
            this.Name = "ResultCountingForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RepetitionsLabel;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.Timer CounterTimer;
        private System.Windows.Forms.Label ResultLabel;
    }
}