using System.Windows.Forms.VisualStyles;

namespace FCalc
{
    partial class FCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCalc));
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            buttonCalculate = new Button();
            buttonDot = new Button();
            buttonPlus = new Button();
            button3 = new Button();
            buttonMinus = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            buttonMultiply = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            labelCalculator = new Label();
            displayBox = new TextBox();
            inputBox = new TextBox();
            buttonSubtract = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            SuspendLayout();
            // 
            // button0
            // 
            button0.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button0.Location = new Point(12, 444);
            button0.Name = "button0";
            button0.Size = new Size(192, 63);
            button0.TabIndex = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += numberButtons_click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button1.Location = new Point(12, 373);
            button1.Name = "button1";
            button1.Size = new Size(92, 63);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += numberButtons_click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button2.Location = new Point(112, 373);
            button2.Name = "button2";
            button2.Size = new Size(92, 63);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += numberButtons_click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            buttonCalculate.Location = new Point(306, 444);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(92, 63);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "=";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += calculateButton_click;
            // 
            // buttonDot
            // 
            buttonDot.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            buttonDot.Location = new Point(209, 444);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(92, 63);
            buttonDot.TabIndex = 3;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += decimalButton_click;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            buttonPlus.Location = new Point(306, 373);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(92, 63);
            buttonPlus.TabIndex = 6;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += arithmeticButtons_click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button3.Location = new Point(209, 373);
            button3.Name = "button3";
            button3.Size = new Size(92, 63);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += numberButtons_click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            buttonMinus.Location = new Point(306, 307);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(92, 59);
            buttonMinus.TabIndex = 10;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += arithmeticButtons_click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button6.Location = new Point(209, 307);
            button6.Name = "button6";
            button6.Size = new Size(92, 59);
            button6.TabIndex = 9;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += numberButtons_click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button5.Location = new Point(112, 307);
            button5.Name = "button5";
            button5.Size = new Size(92, 59);
            button5.TabIndex = 8;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += numberButtons_click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button4.Location = new Point(12, 307);
            button4.Name = "button4";
            button4.Size = new Size(92, 59);
            button4.TabIndex = 7;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += numberButtons_click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            buttonMultiply.Location = new Point(306, 240);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(92, 59);
            buttonMultiply.TabIndex = 14;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += arithmeticButtons_click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button9.Location = new Point(209, 240);
            button9.Name = "button9";
            button9.Size = new Size(92, 59);
            button9.TabIndex = 13;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += numberButtons_click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button8.Location = new Point(112, 240);
            button8.Name = "button8";
            button8.Size = new Size(92, 59);
            button8.TabIndex = 12;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += numberButtons_click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button7.Location = new Point(12, 240);
            button7.Name = "button7";
            button7.Size = new Size(92, 59);
            button7.TabIndex = 11;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += numberButtons_click;
            // 
            // labelCalculator
            // 
            labelCalculator.AutoSize = true;
            labelCalculator.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCalculator.Location = new Point(12, 9);
            labelCalculator.Name = "labelCalculator";
            labelCalculator.Size = new Size(157, 38);
            labelCalculator.TabIndex = 15;
            labelCalculator.Text = "Standard";
            // 
            // displayBox
            // 
            displayBox.Anchor = AnchorStyles.None;
            displayBox.Font = new Font("Microsoft Sans Serif", 20F);
            displayBox.Location = new Point(12, 50);
            displayBox.Multiline = true;
            displayBox.Name = "displayBox";
            displayBox.ReadOnly = true;
            displayBox.Size = new Size(386, 114);
            displayBox.TabIndex = 16;
            displayBox.TextAlign = HorizontalAlignment.Right;
            // 
            // inputBox
            // 
            inputBox.BorderStyle = BorderStyle.None;
            inputBox.Font = new Font("Microsoft Sans Serif", 30F);
            inputBox.Location = new Point(25, 81);
            inputBox.Name = "inputBox";
            inputBox.ReadOnly = true;
            inputBox.Size = new Size(357, 46);
            inputBox.TabIndex = 17;
            inputBox.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            buttonSubtract.Location = new Point(306, 173);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(92, 59);
            buttonSubtract.TabIndex = 18;
            buttonSubtract.Text = "<-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += subtractButton_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button10.Location = new Point(209, 173);
            button10.Name = "button10";
            button10.Size = new Size(92, 59);
            button10.TabIndex = 19;
            button10.Text = "C";
            button10.UseVisualStyleBackColor = true;
            button10.Click += clearButton_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button11.Location = new Point(112, 173);
            button11.Name = "button11";
            button11.Size = new Size(92, 59);
            button11.TabIndex = 20;
            button11.Text = "CE";
            button11.UseVisualStyleBackColor = true;
            button11.Click += clearButton_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button12.Location = new Point(12, 173);
            button12.Name = "button12";
            button12.Size = new Size(92, 59);
            button12.TabIndex = 21;
            button12.Text = "%";
            button12.UseVisualStyleBackColor = true;
            // 
            // FCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 518);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(buttonSubtract);
            Controls.Add(inputBox);
            Controls.Add(displayBox);
            Controls.Add(labelCalculator);
            Controls.Add(buttonMultiply);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(buttonMinus);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonPlus);
            Controls.Add(button3);
            Controls.Add(buttonCalculate);
            Controls.Add(buttonDot);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FCalc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "C# Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button0;
        private Button button1;
        private Button button2;
        private Button buttonCalculate;
        private Button buttonDot;
        private Button buttonPlus;
        private Button button3;
        private Button buttonMinus;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button buttonMultiply;
        private Button button9;
        private Button button8;
        private Button button7;
        private Label labelCalculator;
        private TextBox displayBox;
        private TextBox inputBox;
        private Button buttonSubtract;
        private Button button10;
        private Button button11;
        private Button button12;

    }
}
