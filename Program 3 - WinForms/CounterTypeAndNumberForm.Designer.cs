namespace Program_3___WinForms
{
    partial class CounterTypeAndNumberForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CounterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CountersNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CountersCreatorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CountersNumberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Licznik 1 (liczbowy)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Licznik, który odlicza wskazaną ilość razy czekając pomiędzy każdym odliczeniem p" +
    "rzez wskazaną ilość milisekund";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Np. odlicz do 10, z interwałem „co milisekundę”, lub odlicz do 123 z interwałem c" +
    "o 350ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Licznik 2 (tekstowy)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(536, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Licznik, który odlicza wskazaną ilość razy, czekając pomiędzy każdym odliczeniem " +
    "przez wskazaną ilość sekund";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(478, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Jako input przyjmując liczby od 1 do 100 w formie angielskich liczebników („one”," +
    " „two”, „three” etc)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Wybierz licznik z którego chcesz skorzystać";
            // 
            // CounterTypeComboBox
            // 
            this.CounterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CounterTypeComboBox.FormattingEnabled = true;
            this.CounterTypeComboBox.Items.AddRange(new object[] {
            "Licznik 1 (liczbowy)",
            "Licznik 2 (tekstowy)"});
            this.CounterTypeComboBox.Location = new System.Drawing.Point(13, 170);
            this.CounterTypeComboBox.Name = "CounterTypeComboBox";
            this.CounterTypeComboBox.Size = new System.Drawing.Size(211, 21);
            this.CounterTypeComboBox.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ile liczników ma być uruchomionych";
            // 
            // CountersNumberNumericUpDown
            // 
            this.CountersNumberNumericUpDown.Location = new System.Drawing.Point(253, 170);
            this.CountersNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountersNumberNumericUpDown.Name = "CountersNumberNumericUpDown";
            this.CountersNumberNumericUpDown.Size = new System.Drawing.Size(173, 20);
            this.CountersNumberNumericUpDown.TabIndex = 15;
            this.CountersNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CountersCreatorButton
            // 
            this.CountersCreatorButton.Location = new System.Drawing.Point(188, 210);
            this.CountersCreatorButton.Name = "CountersCreatorButton";
            this.CountersCreatorButton.Size = new System.Drawing.Size(100, 50);
            this.CountersCreatorButton.TabIndex = 16;
            this.CountersCreatorButton.Text = "Stwórz liczniki";
            this.CountersCreatorButton.UseVisualStyleBackColor = true;
            this.CountersCreatorButton.Click += new System.EventHandler(this.CreateCounters);
            // 
            // CounterTypeAndNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 269);
            this.Controls.Add(this.CountersCreatorButton);
            this.Controls.Add(this.CountersNumberNumericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CounterTypeComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CounterTypeAndNumberForm";
            this.Text = "Wybór typu i ilości liczników";
            this.Load += new System.EventHandler(this.CounterTypeAndNumberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountersNumberNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CounterTypeComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown CountersNumberNumericUpDown;
        private System.Windows.Forms.Button CountersCreatorButton;
        private System.Windows.Forms.Label label1;
    }
}

