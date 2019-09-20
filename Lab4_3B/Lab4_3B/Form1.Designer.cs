namespace Lab4_3B
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.operatorBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num2Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter 2 integers with an operator between them";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(273, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valid operators are +, -, *, /, or ^";
            // 
            // num1Box
            // 
            this.num1Box.Location = new System.Drawing.Point(162, 82);
            this.num1Box.Name = "num1Box";
            this.num1Box.Size = new System.Drawing.Size(100, 20);
            this.num1Box.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Num 1";
            // 
            // operatorBox
            // 
            this.operatorBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.operatorBox.Location = new System.Drawing.Point(342, 82);
            this.operatorBox.Name = "operatorBox";
            this.operatorBox.Size = new System.Drawing.Size(100, 20);
            this.operatorBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Operator";
            // 
            // num2Box
            // 
            this.num2Box.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.num2Box.Location = new System.Drawing.Point(526, 82);
            this.num2Box.Name = "num2Box";
            this.num2Box.Size = new System.Drawing.Size(100, 20);
            this.num2Box.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Num 2";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(342, 147);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 23);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputLbl.Location = new System.Drawing.Point(348, 218);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(85, 20);
            this.outputLbl.TabIndex = 9;
            this.outputLbl.Text = "                   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num2Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.operatorBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num1Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num1Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox operatorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num2Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label outputLbl;
    }
}

