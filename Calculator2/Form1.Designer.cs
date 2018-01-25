//Michael Sibbald C00206817
namespace Calculator2
{
    partial class Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.output = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.point = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.output, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45594F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.54406F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 336);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // output
            // 
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.output.Location = new System.Drawing.Point(3, 3);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(278, 66);
            this.output.TabIndex = 0;
            this.output.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.point, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.seven, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.eight, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nine, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.plus, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.four, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.five, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.six, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.minus, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.one, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.two, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.three, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.multi, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.zero, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.equal, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.divide, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.ans, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ce, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.clear, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.backspace, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 75);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 258);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // point
            // 
            this.point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.point.Location = new System.Drawing.Point(3, 207);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(63, 48);
            this.point.TabIndex = 16;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.Point);
            // 
            // seven
            // 
            this.seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seven.Location = new System.Drawing.Point(3, 54);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(63, 45);
            this.seven.TabIndex = 0;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Seven);
            // 
            // eight
            // 
            this.eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eight.Location = new System.Drawing.Point(72, 54);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(63, 45);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Eight);
            // 
            // nine
            // 
            this.nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nine.Location = new System.Drawing.Point(141, 54);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(63, 45);
            this.nine.TabIndex = 2;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Nine);
            // 
            // plus
            // 
            this.plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plus.Location = new System.Drawing.Point(210, 54);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(65, 45);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Plus);
            // 
            // four
            // 
            this.four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.four.Location = new System.Drawing.Point(3, 105);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(63, 45);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Four);
            // 
            // five
            // 
            this.five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.five.Location = new System.Drawing.Point(72, 105);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(63, 45);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Five);
            // 
            // six
            // 
            this.six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.six.Location = new System.Drawing.Point(141, 105);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(63, 45);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Six);
            // 
            // minus
            // 
            this.minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minus.Location = new System.Drawing.Point(210, 105);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(65, 45);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus);
            // 
            // one
            // 
            this.one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.one.Location = new System.Drawing.Point(3, 156);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(63, 45);
            this.one.TabIndex = 8;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.One);
            // 
            // two
            // 
            this.two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.two.Location = new System.Drawing.Point(72, 156);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(63, 45);
            this.two.TabIndex = 9;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Two);
            // 
            // three
            // 
            this.three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.three.Location = new System.Drawing.Point(141, 156);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(63, 45);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Three);
            // 
            // multi
            // 
            this.multi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multi.Location = new System.Drawing.Point(210, 156);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(65, 45);
            this.multi.TabIndex = 11;
            this.multi.Text = "*";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.Multiply);
            // 
            // zero
            // 
            this.zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zero.Location = new System.Drawing.Point(72, 207);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(63, 48);
            this.zero.TabIndex = 13;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Zero);
            // 
            // equal
            // 
            this.equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equal.Location = new System.Drawing.Point(141, 207);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(63, 48);
            this.equal.TabIndex = 14;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.Equal);
            // 
            // divide
            // 
            this.divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divide.Location = new System.Drawing.Point(210, 207);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(65, 48);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Divide);
            // 
            // ans
            // 
            this.ans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ans.Location = new System.Drawing.Point(3, 3);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(63, 45);
            this.ans.TabIndex = 17;
            this.ans.Text = "Ans";
            this.ans.UseVisualStyleBackColor = true;
            this.ans.Click += new System.EventHandler(this.Ans);
            // 
            // ce
            // 
            this.ce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ce.Location = new System.Drawing.Point(72, 3);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(63, 45);
            this.ce.TabIndex = 18;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = true;
            this.ce.Click += new System.EventHandler(this.CE);
            // 
            // clear
            // 
            this.clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear.Location = new System.Drawing.Point(141, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(63, 45);
            this.clear.TabIndex = 19;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear);
            // 
            // backspace
            // 
            this.backspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backspace.Location = new System.Drawing.Point(210, 3);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(65, 45);
            this.backspace.TabIndex = 20;
            this.backspace.Text = "Del";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.Backspace);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 336);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button ans;
        private System.Windows.Forms.Button ce;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button backspace;
    }
}

