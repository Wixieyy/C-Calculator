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
            SuspendLayout();
            // 
            // button0
            // 
            button0.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button0.Location = new Point(12, 376);
            button0.Name = "button0";
            button0.Size = new Size(192, 59);
            button0.TabIndex = 0;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += numberButtons_click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button1.Location = new Point(12, 309);
            button1.Name = "button1";
            button1.Size = new Size(92, 59);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += numberButtons_click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button2.Location = new Point(112, 309);
            button2.Name = "button2";
            button2.Size = new Size(92, 59);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += numberButtons_click;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            buttonCalculate.Location = new Point(306, 376);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(92, 59);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "=";
            buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // buttonDot
            // 
            buttonDot.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            buttonDot.Location = new Point(210, 376);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(92, 59);
            buttonDot.TabIndex = 3;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            buttonPlus.Location = new Point(306, 309);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(92, 59);
            buttonPlus.TabIndex = 6;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button3.Location = new Point(210, 309);
            button3.Name = "button3";
            button3.Size = new Size(92, 59);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += numberButtons_click;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            buttonMinus.Location = new Point(306, 244);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(92, 59);
            buttonMinus.TabIndex = 10;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button6.Location = new Point(210, 244);
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
            button5.Location = new Point(112, 244);
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
            button4.Location = new Point(12, 244);
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
            buttonMultiply.Location = new Point(306, 177);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(92, 59);
            buttonMultiply.TabIndex = 14;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold);
            button9.Location = new Point(210, 177);
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
            button8.Location = new Point(112, 177);
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
            button7.Location = new Point(12, 177);
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
            labelCalculator.Size = new Size(174, 38);
            labelCalculator.TabIndex = 15;
            labelCalculator.Text = "Calculator";
            // 
            // displayBox
            // 
            displayBox.Anchor = AnchorStyles.None;
            displayBox.Font = new Font("Microsoft Sans Serif", 20F);
            displayBox.Location = new Point(11, 49);
            displayBox.Multiline = true;
            displayBox.Name = "displayBox";
            displayBox.ReadOnly = true;
            displayBox.Size = new Size(386, 85);
            displayBox.TabIndex = 16;
            displayBox.TextAlign = HorizontalAlignment.Right;
            // 
            // inputBox
            // 
            inputBox.BorderStyle = BorderStyle.None;
            inputBox.Font = new Font("Microsoft Sans Serif", 30F);
            inputBox.Location = new Point(26, 69);
            inputBox.Name = "inputBox";
            inputBox.PlaceholderText = "text";
            inputBox.ReadOnly = true;
            inputBox.Size = new Size(357, 46);
            inputBox.TabIndex = 17;
            inputBox.TextAlign = HorizontalAlignment.Right;
            // 
            // FCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 447);
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
    }
}
