namespace Kalkulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.simple = new System.Windows.Forms.Button();
            this.Extended = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // simple
            // 
            this.simple.BackColor = System.Drawing.Color.LightSalmon;
            this.simple.Cursor = System.Windows.Forms.Cursors.Default;
            this.simple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.simple.Location = new System.Drawing.Point(31, 96);
            this.simple.Name = "simple";
            this.simple.Size = new System.Drawing.Size(146, 44);
            this.simple.TabIndex = 0;
            this.simple.Text = "Basic";
            this.simple.UseVisualStyleBackColor = false;
            this.simple.Click += new System.EventHandler(this.simple_Click);
            // 
            // Extended
            // 
            this.Extended.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Extended.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Extended.Location = new System.Drawing.Point(31, 146);
            this.Extended.Name = "Extended";
            this.Extended.Size = new System.Drawing.Size(146, 44);
            this.Extended.TabIndex = 1;
            this.Extended.Text = "Extended";
            this.Extended.UseVisualStyleBackColor = false;
            this.Extended.Click += new System.EventHandler(this.Extended_Click);
            // 
            // Welcome
            // 
            this.Welcome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Welcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Welcome.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(31, 35);
            this.Welcome.Name = "Welcome";
            this.Welcome.ReadOnly = true;
            this.Welcome.Size = new System.Drawing.Size(146, 33);
            this.Welcome.TabIndex = 2;
            this.Welcome.Text = "Calculator";
            this.Welcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(214, 224);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.Extended);
            this.Controls.Add(this.simple);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button simple;
        private System.Windows.Forms.Button Extended;
        private System.Windows.Forms.TextBox Welcome;
    }
}

