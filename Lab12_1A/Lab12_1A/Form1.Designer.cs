namespace Lab12_1A
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
            this.radioMP = new System.Windows.Forms.RadioButton();
            this.radioGrey = new System.Windows.Forms.RadioButton();
            this.radioRB = new System.Windows.Forms.RadioButton();
            this.radioLY = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioMP
            // 
            this.radioMP.AutoSize = true;
            this.radioMP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.radioMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radioMP.Location = new System.Drawing.Point(13, 173);
            this.radioMP.Name = "radioMP";
            this.radioMP.Size = new System.Drawing.Size(200, 33);
            this.radioMP.TabIndex = 0;
            this.radioMP.TabStop = true;
            this.radioMP.Text = "Midnight Purple";
            this.radioMP.UseVisualStyleBackColor = false;
            this.radioMP.CheckedChanged += new System.EventHandler(this.radioMP_CheckedChanged);
            // 
            // radioGrey
            // 
            this.radioGrey.AutoSize = true;
            this.radioGrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radioGrey.Location = new System.Drawing.Point(255, 173);
            this.radioGrey.Name = "radioGrey";
            this.radioGrey.Size = new System.Drawing.Size(82, 33);
            this.radioGrey.TabIndex = 1;
            this.radioGrey.TabStop = true;
            this.radioGrey.Text = "Grey";
            this.radioGrey.UseVisualStyleBackColor = true;
            this.radioGrey.CheckedChanged += new System.EventHandler(this.radioGrey_CheckedChanged);
            // 
            // radioRB
            // 
            this.radioRB.AutoSize = true;
            this.radioRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radioRB.Location = new System.Drawing.Point(401, 173);
            this.radioRB.Name = "radioRB";
            this.radioRB.Size = new System.Drawing.Size(147, 33);
            this.radioRB.TabIndex = 2;
            this.radioRB.TabStop = true;
            this.radioRB.Text = "Royal Blue";
            this.radioRB.UseVisualStyleBackColor = true;
            this.radioRB.CheckedChanged += new System.EventHandler(this.radioRB_CheckedChanged);
            // 
            // radioLY
            // 
            this.radioLY.AutoSize = true;
            this.radioLY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.radioLY.Location = new System.Drawing.Point(592, 173);
            this.radioLY.Name = "radioLY";
            this.radioLY.Size = new System.Drawing.Size(196, 33);
            this.radioLY.TabIndex = 3;
            this.radioLY.TabStop = true;
            this.radioLY.Text = "Lighting Yellow";
            this.radioLY.UseVisualStyleBackColor = true;
            this.radioLY.CheckedChanged += new System.EventHandler(this.radioLY_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioLY);
            this.Controls.Add(this.radioRB);
            this.Controls.Add(this.radioGrey);
            this.Controls.Add(this.radioMP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioMP;
        private System.Windows.Forms.RadioButton radioGrey;
        private System.Windows.Forms.RadioButton radioRB;
        private System.Windows.Forms.RadioButton radioLY;
    }
}

