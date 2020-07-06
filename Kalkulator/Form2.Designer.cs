namespace Kalkulator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.decimal_point = new System.Windows.Forms.Button();
            this.pos_neg = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.esc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(318, 69);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Tomato;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(12, 96);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 50);
            this.delete.TabIndex = 1;
            this.delete.Text = "Clear";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // decimal_point
            // 
            this.decimal_point.BackColor = System.Drawing.Color.DarkGray;
            this.decimal_point.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decimal_point.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimal_point.Location = new System.Drawing.Point(12, 323);
            this.decimal_point.Name = "decimal_point";
            this.decimal_point.Size = new System.Drawing.Size(75, 50);
            this.decimal_point.TabIndex = 2;
            this.decimal_point.Text = ".";
            this.decimal_point.UseVisualStyleBackColor = false;
            this.decimal_point.Click += new System.EventHandler(this.decimal_point_Click);
            // 
            // pos_neg
            // 
            this.pos_neg.BackColor = System.Drawing.Color.DarkGray;
            this.pos_neg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pos_neg.Font = new System.Drawing.Font("Calibri", 12F);
            this.pos_neg.Location = new System.Drawing.Point(174, 96);
            this.pos_neg.Name = "pos_neg";
            this.pos_neg.Size = new System.Drawing.Size(75, 50);
            this.pos_neg.TabIndex = 3;
            this.pos_neg.Text = "+/-";
            this.pos_neg.UseVisualStyleBackColor = false;
            this.pos_neg.Click += new System.EventHandler(this.pos_neg_Click);
            // 
            // addition
            // 
            this.addition.BackColor = System.Drawing.Color.DarkGray;
            this.addition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addition.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(255, 263);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 50);
            this.addition.TabIndex = 4;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.Gainsboro;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one.Font = new System.Drawing.Font("Calibri", 12F);
            this.one.Location = new System.Drawing.Point(12, 264);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 50);
            this.one.TabIndex = 5;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.Gainsboro;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.two.Font = new System.Drawing.Font("Calibri", 12F);
            this.two.Location = new System.Drawing.Point(93, 264);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 50);
            this.two.TabIndex = 6;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click_1);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.Gainsboro;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.three.Font = new System.Drawing.Font("Calibri", 12F);
            this.three.Location = new System.Drawing.Point(174, 264);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 50);
            this.three.TabIndex = 7;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // substraction
            // 
            this.substraction.BackColor = System.Drawing.Color.DarkGray;
            this.substraction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.substraction.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substraction.Location = new System.Drawing.Point(255, 208);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(75, 50);
            this.substraction.TabIndex = 8;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = false;
            this.substraction.Click += new System.EventHandler(this.substraction_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.Gainsboro;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.four.Font = new System.Drawing.Font("Calibri", 12F);
            this.four.Location = new System.Drawing.Point(12, 208);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 50);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.Gainsboro;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.five.Font = new System.Drawing.Font("Calibri", 12F);
            this.five.Location = new System.Drawing.Point(93, 208);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 50);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.Gainsboro;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.six.Font = new System.Drawing.Font("Calibri", 12F);
            this.six.Location = new System.Drawing.Point(174, 208);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 50);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.DarkGray;
            this.division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.division.Font = new System.Drawing.Font("Calibri", 12F);
            this.division.Location = new System.Drawing.Point(255, 96);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 50);
            this.division.TabIndex = 12;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.Gainsboro;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seven.Font = new System.Drawing.Font("Calibri", 12F);
            this.seven.Location = new System.Drawing.Point(12, 152);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 50);
            this.seven.TabIndex = 13;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.Gainsboro;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eight.Font = new System.Drawing.Font("Calibri", 12F);
            this.eight.Location = new System.Drawing.Point(93, 152);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 50);
            this.eight.TabIndex = 14;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.Gainsboro;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nine.Font = new System.Drawing.Font("Calibri", 12F);
            this.nine.Location = new System.Drawing.Point(174, 152);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 50);
            this.nine.TabIndex = 15;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.DarkGray;
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplication.Font = new System.Drawing.Font("Calibri", 12F);
            this.multiplication.Location = new System.Drawing.Point(255, 152);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 50);
            this.multiplication.TabIndex = 16;
            this.multiplication.Text = "x";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.Color.DarkGray;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.percent.Font = new System.Drawing.Font("Calibri", 12F);
            this.percent.Location = new System.Drawing.Point(93, 96);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(75, 50);
            this.percent.TabIndex = 17;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Gainsboro;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zero.Font = new System.Drawing.Font("Calibri", 12F);
            this.zero.Location = new System.Drawing.Point(93, 323);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(156, 50);
            this.zero.TabIndex = 18;
            this.zero.Text = "0\r\n";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.Tomato;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equals.Font = new System.Drawing.Font("Calibri", 12F);
            this.equals.Location = new System.Drawing.Point(255, 323);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(75, 50);
            this.equals.TabIndex = 19;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // esc
            // 
            this.esc.BackColor = System.Drawing.Color.DimGray;
            this.esc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.esc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esc.Location = new System.Drawing.Point(255, 379);
            this.esc.Name = "esc";
            this.esc.Size = new System.Drawing.Size(75, 33);
            this.esc.TabIndex = 20;
            this.esc.Text = "Back";
            this.esc.UseVisualStyleBackColor = false;
            this.esc.Click += new System.EventHandler(this.esc_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(346, 421);
            this.Controls.Add(this.esc);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.division);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.pos_neg);
            this.Controls.Add(this.decimal_point);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Basic Calculator";
            this.Load += new System.EventHandler(this.simple_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button decimal_point;
        private System.Windows.Forms.Button pos_neg;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button esc;
    }
}