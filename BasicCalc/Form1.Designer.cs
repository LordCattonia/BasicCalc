namespace BasicCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Negative_Switch = new System.Windows.Forms.Button();
            this.Percent_button = new System.Windows.Forms.Button();
            this.Addition_button = new System.Windows.Forms.Button();
            this.seven_button = new System.Windows.Forms.Button();
            this.eight_button = new System.Windows.Forms.Button();
            this.nine_button = new System.Windows.Forms.Button();
            this.subtraction_button = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.five_button = new System.Windows.Forms.Button();
            this.six_button = new System.Windows.Forms.Button();
            this.multiplication_button = new System.Windows.Forms.Button();
            this.one_button = new System.Windows.Forms.Button();
            this.two_button = new System.Windows.Forms.Button();
            this.three_button = new System.Windows.Forms.Button();
            this.divide_button = new System.Windows.Forms.Button();
            this.zero_button = new System.Windows.Forms.Button();
            this.decimal_point = new System.Windows.Forms.Button();
            this.equals_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 128);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear_Button.Location = new System.Drawing.Point(44, 192);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(120, 93);
            this.Clear_Button.TabIndex = 1;
            this.Clear_Button.Text = "AC";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Negative_Switch
            // 
            this.Negative_Switch.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Negative_Switch.Location = new System.Drawing.Point(180, 192);
            this.Negative_Switch.Margin = new System.Windows.Forms.Padding(1);
            this.Negative_Switch.Name = "Negative_Switch";
            this.Negative_Switch.Size = new System.Drawing.Size(120, 93);
            this.Negative_Switch.TabIndex = 2;
            this.Negative_Switch.Text = "-/+";
            this.Negative_Switch.UseVisualStyleBackColor = true;
            this.Negative_Switch.Click += new System.EventHandler(this.button2_Click);
            // 
            // Percent_button
            // 
            this.Percent_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Percent_button.Location = new System.Drawing.Point(316, 192);
            this.Percent_button.Name = "Percent_button";
            this.Percent_button.Size = new System.Drawing.Size(120, 93);
            this.Percent_button.TabIndex = 3;
            this.Percent_button.Text = "%";
            this.Percent_button.UseVisualStyleBackColor = true;
            this.Percent_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Addition_button
            // 
            this.Addition_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Addition_button.Location = new System.Drawing.Point(451, 192);
            this.Addition_button.Name = "Addition_button";
            this.Addition_button.Size = new System.Drawing.Size(120, 93);
            this.Addition_button.TabIndex = 4;
            this.Addition_button.Text = "+";
            this.Addition_button.UseVisualStyleBackColor = true;
            this.Addition_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // seven_button
            // 
            this.seven_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seven_button.Location = new System.Drawing.Point(44, 301);
            this.seven_button.Name = "seven_button";
            this.seven_button.Size = new System.Drawing.Size(120, 93);
            this.seven_button.TabIndex = 5;
            this.seven_button.Text = "7";
            this.seven_button.UseVisualStyleBackColor = true;
            this.seven_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // eight_button
            // 
            this.eight_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eight_button.Location = new System.Drawing.Point(180, 301);
            this.eight_button.Name = "eight_button";
            this.eight_button.Size = new System.Drawing.Size(120, 93);
            this.eight_button.TabIndex = 6;
            this.eight_button.Text = "8";
            this.eight_button.UseVisualStyleBackColor = true;
            this.eight_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // nine_button
            // 
            this.nine_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nine_button.Location = new System.Drawing.Point(316, 301);
            this.nine_button.Name = "nine_button";
            this.nine_button.Size = new System.Drawing.Size(120, 93);
            this.nine_button.TabIndex = 7;
            this.nine_button.Text = "9";
            this.nine_button.UseVisualStyleBackColor = true;
            this.nine_button.Click += new System.EventHandler(this.button7_Click);
            // 
            // subtraction_button
            // 
            this.subtraction_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtraction_button.Location = new System.Drawing.Point(451, 301);
            this.subtraction_button.Name = "subtraction_button";
            this.subtraction_button.Size = new System.Drawing.Size(120, 93);
            this.subtraction_button.TabIndex = 8;
            this.subtraction_button.Text = "-";
            this.subtraction_button.UseVisualStyleBackColor = true;
            this.subtraction_button.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(44, 415);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 93);
            this.button9.TabIndex = 9;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // five_button
            // 
            this.five_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.five_button.Location = new System.Drawing.Point(180, 415);
            this.five_button.Name = "five_button";
            this.five_button.Size = new System.Drawing.Size(120, 93);
            this.five_button.TabIndex = 10;
            this.five_button.Text = "5";
            this.five_button.UseVisualStyleBackColor = true;
            this.five_button.Click += new System.EventHandler(this.button10_Click);
            // 
            // six_button
            // 
            this.six_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.six_button.Location = new System.Drawing.Point(316, 415);
            this.six_button.Name = "six_button";
            this.six_button.Size = new System.Drawing.Size(120, 93);
            this.six_button.TabIndex = 11;
            this.six_button.Text = "6";
            this.six_button.UseVisualStyleBackColor = true;
            this.six_button.Click += new System.EventHandler(this.button11_Click);
            // 
            // multiplication_button
            // 
            this.multiplication_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplication_button.Location = new System.Drawing.Point(451, 415);
            this.multiplication_button.Name = "multiplication_button";
            this.multiplication_button.Size = new System.Drawing.Size(120, 93);
            this.multiplication_button.TabIndex = 12;
            this.multiplication_button.Text = "×";
            this.multiplication_button.UseVisualStyleBackColor = true;
            this.multiplication_button.Click += new System.EventHandler(this.button12_Click);
            // 
            // one_button
            // 
            this.one_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.one_button.Location = new System.Drawing.Point(44, 530);
            this.one_button.Name = "one_button";
            this.one_button.Size = new System.Drawing.Size(120, 93);
            this.one_button.TabIndex = 13;
            this.one_button.Text = "1";
            this.one_button.UseVisualStyleBackColor = true;
            this.one_button.Click += new System.EventHandler(this.button13_Click);
            // 
            // two_button
            // 
            this.two_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.two_button.Location = new System.Drawing.Point(180, 530);
            this.two_button.Name = "two_button";
            this.two_button.Size = new System.Drawing.Size(120, 93);
            this.two_button.TabIndex = 14;
            this.two_button.Text = "2";
            this.two_button.UseVisualStyleBackColor = true;
            this.two_button.Click += new System.EventHandler(this.button14_Click);
            // 
            // three_button
            // 
            this.three_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.three_button.Location = new System.Drawing.Point(316, 530);
            this.three_button.Name = "three_button";
            this.three_button.Size = new System.Drawing.Size(120, 93);
            this.three_button.TabIndex = 15;
            this.three_button.Text = "3";
            this.three_button.UseVisualStyleBackColor = true;
            this.three_button.Click += new System.EventHandler(this.button15_Click);
            // 
            // divide_button
            // 
            this.divide_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divide_button.Location = new System.Drawing.Point(451, 530);
            this.divide_button.Name = "divide_button";
            this.divide_button.Size = new System.Drawing.Size(120, 93);
            this.divide_button.TabIndex = 16;
            this.divide_button.Text = "÷";
            this.divide_button.UseVisualStyleBackColor = true;
            this.divide_button.Click += new System.EventHandler(this.button16_Click);
            // 
            // zero_button
            // 
            this.zero_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zero_button.Location = new System.Drawing.Point(44, 643);
            this.zero_button.Name = "zero_button";
            this.zero_button.Size = new System.Drawing.Size(256, 93);
            this.zero_button.TabIndex = 17;
            this.zero_button.Text = "0";
            this.zero_button.UseVisualStyleBackColor = true;
            this.zero_button.Click += new System.EventHandler(this.button17_Click);
            // 
            // decimal_point
            // 
            this.decimal_point.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decimal_point.Location = new System.Drawing.Point(316, 643);
            this.decimal_point.Name = "decimal_point";
            this.decimal_point.Size = new System.Drawing.Size(120, 93);
            this.decimal_point.TabIndex = 18;
            this.decimal_point.Text = ".";
            this.decimal_point.UseVisualStyleBackColor = true;
            this.decimal_point.Click += new System.EventHandler(this.button18_Click);
            // 
            // equals_button
            // 
            this.equals_button.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equals_button.Location = new System.Drawing.Point(451, 643);
            this.equals_button.Name = "equals_button";
            this.equals_button.Size = new System.Drawing.Size(120, 93);
            this.equals_button.TabIndex = 19;
            this.equals_button.Text = "=";
            this.equals_button.UseVisualStyleBackColor = true;
            this.equals_button.Click += new System.EventHandler(this.button19_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 794);
            this.Controls.Add(this.equals_button);
            this.Controls.Add(this.decimal_point);
            this.Controls.Add(this.zero_button);
            this.Controls.Add(this.divide_button);
            this.Controls.Add(this.three_button);
            this.Controls.Add(this.two_button);
            this.Controls.Add(this.one_button);
            this.Controls.Add(this.multiplication_button);
            this.Controls.Add(this.six_button);
            this.Controls.Add(this.five_button);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.subtraction_button);
            this.Controls.Add(this.nine_button);
            this.Controls.Add(this.eight_button);
            this.Controls.Add(this.seven_button);
            this.Controls.Add(this.Addition_button);
            this.Controls.Add(this.Percent_button);
            this.Controls.Add(this.Negative_Switch);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Clear_Button;
        private Button Negative_Switch;
        private Button Percent_button;
        private Button Addition_button;
        private Button seven_button;
        private Button eight_button;
        private Button nine_button;
        private Button subtraction_button;
        private Button button9;
        private Button five_button;
        private Button six_button;
        private Button multiplication_button;
        private Button one_button;
        private Button two_button;
        private Button three_button;
        private Button divide_button;
        private Button zero_button;
        private Button decimal_point;
        private Button equals_button;
    }
}