namespace Lab12_1B
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
            this.radio1BD = new System.Windows.Forms.RadioButton();
            this.radio2BD = new System.Windows.Forms.RadioButton();
            this.radio3BD = new System.Windows.Forms.RadioButton();
            this.radio1BR = new System.Windows.Forms.RadioButton();
            this.radio2BR = new System.Windows.Forms.RadioButton();
            this.checkLakeV = new System.Windows.Forms.CheckBox();
            this.lblCalcR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio1BD
            // 
            this.radio1BD.AutoSize = true;
            this.radio1BD.Location = new System.Drawing.Point(3, 7);
            this.radio1BD.Name = "radio1BD";
            this.radio1BD.Size = new System.Drawing.Size(53, 17);
            this.radio1BD.TabIndex = 0;
            this.radio1BD.TabStop = true;
            this.radio1BD.Text = "1 Bed";
            this.radio1BD.UseVisualStyleBackColor = true;
            this.radio1BD.CheckedChanged += new System.EventHandler(this.radio1BD_CheckedChanged);
            // 
            // radio2BD
            // 
            this.radio2BD.AutoSize = true;
            this.radio2BD.Location = new System.Drawing.Point(62, 7);
            this.radio2BD.Name = "radio2BD";
            this.radio2BD.Size = new System.Drawing.Size(53, 17);
            this.radio2BD.TabIndex = 1;
            this.radio2BD.TabStop = true;
            this.radio2BD.Text = "2 Bed";
            this.radio2BD.UseVisualStyleBackColor = true;
            this.radio2BD.CheckedChanged += new System.EventHandler(this.radio2BD_CheckedChanged);
            // 
            // radio3BD
            // 
            this.radio3BD.AutoSize = true;
            this.radio3BD.Location = new System.Drawing.Point(121, 6);
            this.radio3BD.Name = "radio3BD";
            this.radio3BD.Size = new System.Drawing.Size(53, 17);
            this.radio3BD.TabIndex = 2;
            this.radio3BD.TabStop = true;
            this.radio3BD.Text = "3 Bed";
            this.radio3BD.UseVisualStyleBackColor = true;
            this.radio3BD.CheckedChanged += new System.EventHandler(this.radio3BD_CheckedChanged);
            // 
            // radio1BR
            // 
            this.radio1BR.AutoSize = true;
            this.radio1BR.Location = new System.Drawing.Point(3, 7);
            this.radio1BR.Name = "radio1BR";
            this.radio1BR.Size = new System.Drawing.Size(56, 17);
            this.radio1BR.TabIndex = 3;
            this.radio1BR.TabStop = true;
            this.radio1BR.Text = "1 Bath";
            this.radio1BR.UseVisualStyleBackColor = true;
            this.radio1BR.CheckedChanged += new System.EventHandler(this.radio1BR_CheckedChanged);
            // 
            // radio2BR
            // 
            this.radio2BR.AutoSize = true;
            this.radio2BR.Location = new System.Drawing.Point(65, 6);
            this.radio2BR.Name = "radio2BR";
            this.radio2BR.Size = new System.Drawing.Size(56, 17);
            this.radio2BR.TabIndex = 4;
            this.radio2BR.TabStop = true;
            this.radio2BR.Text = "2 Bath";
            this.radio2BR.UseVisualStyleBackColor = true;
            this.radio2BR.CheckedChanged += new System.EventHandler(this.radio2BR_CheckedChanged);
            // 
            // checkLakeV
            // 
            this.checkLakeV.AutoSize = true;
            this.checkLakeV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.checkLakeV.Location = new System.Drawing.Point(331, 121);
            this.checkLakeV.Name = "checkLakeV";
            this.checkLakeV.Size = new System.Drawing.Size(76, 17);
            this.checkLakeV.TabIndex = 5;
            this.checkLakeV.Text = "Lake View";
            this.checkLakeV.UseVisualStyleBackColor = false;
            this.checkLakeV.CheckedChanged += new System.EventHandler(this.checkLakeV_CheckedChanged);
            // 
            // lblCalcR
            // 
            this.lblCalcR.AutoSize = true;
            this.lblCalcR.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCalcR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalcR.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lblCalcR.Location = new System.Drawing.Point(231, 169);
            this.lblCalcR.Name = "lblCalcR";
            this.lblCalcR.Size = new System.Drawing.Size(307, 53);
            this.lblCalcR.TabIndex = 6;
            this.lblCalcR.Text = "Calculate Rent";
            this.lblCalcR.Click += new System.EventHandler(this.lblCalcR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(137, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bedrooms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(170, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bathrooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(225, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lake View";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblRent.Location = new System.Drawing.Point(234, 274);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(268, 33);
            this.lblRent.TabIndex = 10;
            this.lblRent.Text = "                                    ";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.radio3BD);
            this.panel1.Controls.Add(this.radio2BD);
            this.panel1.Controls.Add(this.radio1BD);
            this.panel1.Location = new System.Drawing.Point(240, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 27);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.radio2BR);
            this.panel2.Controls.Add(this.radio1BR);
            this.panel2.Location = new System.Drawing.Point(276, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 27);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCalcR);
            this.Controls.Add(this.checkLakeV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio1BD;
        private System.Windows.Forms.RadioButton radio2BD;
        private System.Windows.Forms.RadioButton radio3BD;
        private System.Windows.Forms.RadioButton radio1BR;
        private System.Windows.Forms.RadioButton radio2BR;
        private System.Windows.Forms.CheckBox checkLakeV;
        private System.Windows.Forms.Label lblCalcR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

