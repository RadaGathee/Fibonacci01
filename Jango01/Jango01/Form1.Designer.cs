namespace Jango01
{
    partial class Bado
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
			this.input1 = new System.Windows.Forms.TextBox();
			this.input2 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.SumBtn = new System.Windows.Forms.Button();
			this.MultBtn = new System.Windows.Forms.Button();
			this.FiboBtn = new System.Windows.Forms.Button();
			this.Reset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// input1
			// 
			this.input1.Location = new System.Drawing.Point(157, 66);
			this.input1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.input1.Name = "input1";
			this.input1.Size = new System.Drawing.Size(313, 22);
			this.input1.TabIndex = 0;
			// 
			// input2
			// 
			this.input2.Location = new System.Drawing.Point(157, 109);
			this.input2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.input2.Name = "input2";
			this.input2.Size = new System.Drawing.Size(313, 22);
			this.input2.TabIndex = 1;
			this.input2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(58, 66);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(49, 16);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Value1";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(58, 109);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(49, 16);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Value2";
			// 
			// SumBtn
			// 
			this.SumBtn.Location = new System.Drawing.Point(157, 151);
			this.SumBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.SumBtn.Name = "SumBtn";
			this.SumBtn.Size = new System.Drawing.Size(140, 27);
			this.SumBtn.TabIndex = 4;
			this.SumBtn.Text = "SUM";
			this.SumBtn.UseVisualStyleBackColor = true;
			this.SumBtn.Click += new System.EventHandler(this.SumBtn_Click);
			// 
			// MultBtn
			// 
			this.MultBtn.Location = new System.Drawing.Point(319, 151);
			this.MultBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MultBtn.Name = "MultBtn";
			this.MultBtn.Size = new System.Drawing.Size(151, 27);
			this.MultBtn.TabIndex = 5;
			this.MultBtn.Text = "Multiply";
			this.MultBtn.UseVisualStyleBackColor = true;
			this.MultBtn.Click += new System.EventHandler(this.MultBtn_Click);
			// 
			// FiboBtn
			// 
			this.FiboBtn.Location = new System.Drawing.Point(243, 203);
			this.FiboBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.FiboBtn.Name = "FiboBtn";
			this.FiboBtn.Size = new System.Drawing.Size(143, 27);
			this.FiboBtn.TabIndex = 6;
			this.FiboBtn.Text = "Fibonacci";
			this.FiboBtn.UseVisualStyleBackColor = true;
			this.FiboBtn.Click += new System.EventHandler(this.FiboBtn_Click);
			// 
			// Reset
			// 
			this.Reset.Location = new System.Drawing.Point(157, 252);
			this.Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Reset.Name = "Reset";
			this.Reset.Size = new System.Drawing.Size(313, 30);
			this.Reset.TabIndex = 7;
			this.Reset.Text = "Reset";
			this.Reset.UseVisualStyleBackColor = true;
			this.Reset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// Bado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 392);
			this.Controls.Add(this.Reset);
			this.Controls.Add(this.FiboBtn);
			this.Controls.Add(this.MultBtn);
			this.Controls.Add(this.SumBtn);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.input2);
			this.Controls.Add(this.input1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MinimumSize = new System.Drawing.Size(616, 416);
			this.Name = "Bado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Fibonacci Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button SumBtn;
        private System.Windows.Forms.Button MultBtn;
        private System.Windows.Forms.Button FiboBtn;
        private System.Windows.Forms.Button Reset;
    }
}

