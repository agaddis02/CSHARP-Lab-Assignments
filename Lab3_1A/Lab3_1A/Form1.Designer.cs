namespace Lab3_1A
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
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.convertBtn = new System.Windows.Forms.Button();
            this.lblQuarters = new System.Windows.Forms.Label();
            this.lblDimes = new System.Windows.Forms.Label();
            this.lblNickel = new System.Windows.Forms.Label();
            this.lblPennies = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalAmount
            // 
            this.totalAmount.Location = new System.Drawing.Point(324, 38);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(127, 20);
            this.totalAmount.TabIndex = 0;
            this.totalAmount.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a Currency amount in cents and click the button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(253, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // convertBtn
            // 
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.convertBtn.Location = new System.Drawing.Point(257, 79);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(193, 29);
            this.convertBtn.TabIndex = 3;
            this.convertBtn.Text = "Conversion Calculation";
            this.convertBtn.UseVisualStyleBackColor = true;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // lblQuarters
            // 
            this.lblQuarters.AutoSize = true;
            this.lblQuarters.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblQuarters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuarters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuarters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuarters.Location = new System.Drawing.Point(326, 123);
            this.lblQuarters.Name = "lblQuarters";
            this.lblQuarters.Size = new System.Drawing.Size(71, 22);
            this.lblQuarters.TabIndex = 4;
            this.lblQuarters.Text = "               ";
            // 
            // lblDimes
            // 
            this.lblDimes.AutoSize = true;
            this.lblDimes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDimes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDimes.Location = new System.Drawing.Point(326, 174);
            this.lblDimes.Name = "lblDimes";
            this.lblDimes.Size = new System.Drawing.Size(71, 22);
            this.lblDimes.TabIndex = 5;
            this.lblDimes.Text = "               ";
            // 
            // lblNickel
            // 
            this.lblNickel.AutoSize = true;
            this.lblNickel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNickel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNickel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNickel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNickel.Location = new System.Drawing.Point(326, 228);
            this.lblNickel.Name = "lblNickel";
            this.lblNickel.Size = new System.Drawing.Size(71, 22);
            this.lblNickel.TabIndex = 6;
            this.lblNickel.Text = "               ";
            // 
            // lblPennies
            // 
            this.lblPennies.AutoSize = true;
            this.lblPennies.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPennies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPennies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPennies.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPennies.Location = new System.Drawing.Point(326, 282);
            this.lblPennies.Name = "lblPennies";
            this.lblPennies.Size = new System.Drawing.Size(71, 22);
            this.lblPennies.TabIndex = 7;
            this.lblPennies.Text = "               ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(12, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(777, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "convertor that changes your change less than one dollar, into the amount of quart" +
    "ers, dimes, nickels, and pennies needed to equal the amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(255, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quarters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(255, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dimes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(255, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nickels";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(255, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pennies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPennies);
            this.Controls.Add(this.lblNickel);
            this.Controls.Add(this.lblDimes);
            this.Controls.Add(this.lblQuarters);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalAmount);
            this.Name = "Form1";
            this.Text = "Currency Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label lblQuarters;
        private System.Windows.Forms.Label lblDimes;
        private System.Windows.Forms.Label lblNickel;
        private System.Windows.Forms.Label lblPennies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

