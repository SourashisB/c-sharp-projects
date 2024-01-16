namespace SimpleCalculator
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
            displayBox = new TextBox();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonZero = new Button();
            buttonSwitch = new Button();
            buttonEqual = new Button();
            buttonDecimal = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // displayBox
            // 
            displayBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayBox.Location = new Point(12, 40);
            displayBox.Name = "displayBox";
            displayBox.PlaceholderText = "0";
            displayBox.RightToLeft = RightToLeft.No;
            displayBox.Size = new Size(541, 79);
            displayBox.TabIndex = 0;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(31, 179);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(107, 52);
            buttonPlus.TabIndex = 1;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += operator_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(162, 179);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(107, 52);
            buttonMinus.TabIndex = 2;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += operator_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(297, 179);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(107, 52);
            buttonMultiply.TabIndex = 3;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += operator_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(426, 179);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(107, 52);
            buttonDivide.TabIndex = 4;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += operator_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.Location = new Point(31, 285);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(107, 52);
            buttonSeven.TabIndex = 5;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += button_Click;
            // 
            // buttonEight
            // 
            buttonEight.Location = new Point(162, 285);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(107, 52);
            buttonEight.TabIndex = 6;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += button_Click;
            // 
            // buttonNine
            // 
            buttonNine.Location = new Point(297, 285);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(107, 52);
            buttonNine.TabIndex = 7;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += button_Click;
            // 
            // buttonFour
            // 
            buttonFour.Location = new Point(31, 357);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(107, 52);
            buttonFour.TabIndex = 8;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += button_Click;
            // 
            // buttonFive
            // 
            buttonFive.Location = new Point(162, 357);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(107, 52);
            buttonFive.TabIndex = 9;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += button_Click;
            // 
            // buttonSix
            // 
            buttonSix.Location = new Point(297, 357);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(107, 52);
            buttonSix.TabIndex = 10;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += button_Click;
            // 
            // buttonOne
            // 
            buttonOne.Location = new Point(31, 427);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(107, 52);
            buttonOne.TabIndex = 11;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += button_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Location = new Point(162, 427);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(107, 52);
            buttonTwo.TabIndex = 12;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += button_Click;
            // 
            // buttonThree
            // 
            buttonThree.Location = new Point(297, 427);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(107, 52);
            buttonThree.TabIndex = 13;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += button_Click;
            // 
            // buttonZero
            // 
            buttonZero.Location = new Point(162, 498);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(107, 52);
            buttonZero.TabIndex = 14;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += button_Click;
            // 
            // buttonSwitch
            // 
            buttonSwitch.Location = new Point(31, 498);
            buttonSwitch.Name = "buttonSwitch";
            buttonSwitch.Size = new Size(107, 52);
            buttonSwitch.TabIndex = 15;
            buttonSwitch.Text = "+/-";
            buttonSwitch.UseVisualStyleBackColor = true;
            buttonSwitch.Click += buttonSwitch_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = SystemColors.ActiveCaption;
            buttonEqual.ImageAlign = ContentAlignment.TopLeft;
            buttonEqual.Location = new Point(426, 357);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(107, 202);
            buttonEqual.TabIndex = 16;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqualsClick;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Location = new Point(297, 498);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(107, 52);
            buttonDecimal.TabIndex = 17;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += button_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ScrollBar;
            buttonClear.Location = new Point(426, 285);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(107, 52);
            buttonClear.TabIndex = 18;
            buttonClear.Text = "CE";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClearClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 571);
            Controls.Add(buttonClear);
            Controls.Add(buttonDecimal);
            Controls.Add(buttonEqual);
            Controls.Add(buttonSwitch);
            Controls.Add(buttonZero);
            Controls.Add(buttonThree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonSeven);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(displayBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayBox;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonZero;
        private Button buttonSwitch;
        private Button buttonEqual;
        private Button buttonDecimal;
        private Button buttonClear;
    }
}
