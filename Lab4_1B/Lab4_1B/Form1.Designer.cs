namespace Lab4_1B
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
            this.num1Box = new System.Windows.Forms.TextBox();
            this.num2Box = new System.Windows.Forms.TextBox();
            this.valueReader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1Box
            // 
            this.num1Box.Location = new System.Drawing.Point(158, 12);
            this.num1Box.Name = "num1Box";
            this.num1Box.Size = new System.Drawing.Size(100, 20);
            this.num1Box.TabIndex = 0;
            // 
            // num2Box
            // 
            this.num2Box.Location = new System.Drawing.Point(393, 12);
            this.num2Box.Name = "num2Box";
            this.num2Box.Size = new System.Drawing.Size(100, 20);
            this.num2Box.TabIndex = 1;
            // 
            // valueReader
            // 
            this.valueReader.AutoSize = true;
            this.valueReader.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.valueReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valueReader.Location = new System.Drawing.Point(264, 74);
            this.valueReader.Name = "valueReader";
            this.valueReader.Size = new System.Drawing.Size(93, 20);
            this.valueReader.TabIndex = 2;
            this.valueReader.Text = "                     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(309, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number 2";
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calculate.Location = new System.Drawing.Point(155, 59);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(103, 35);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Click Me";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(74, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter 2 numbers, when you click the button it will tell you which one is to 30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueReader);
            this.Controls.Add(this.num2Box);
            this.Controls.Add(this.num1Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1Box;
        private System.Windows.Forms.TextBox num2Box;
        private System.Windows.Forms.Label valueReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label3;
    }
}

