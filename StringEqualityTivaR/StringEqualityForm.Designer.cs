namespace StringEqualityTivaR
{
    partial class frmStringEquality
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.lblString1Text = new System.Windows.Forms.Label();
            this.lblString2Text = new System.Windows.Forms.Label();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblStringsEqualAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(38, 19);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(190, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter two string to see if they are equal";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.Location = new System.Drawing.Point(59, 44);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(130, 15);
            this.lblInstruction2.TabIndex = 1;
            this.lblInstruction2.Text = "(Case does not matter)";
            // 
            // lblString1Text
            // 
            this.lblString1Text.AutoSize = true;
            this.lblString1Text.Location = new System.Drawing.Point(23, 95);
            this.lblString1Text.Name = "lblString1Text";
            this.lblString1Text.Size = new System.Drawing.Size(46, 13);
            this.lblString1Text.TabIndex = 2;
            this.lblString1Text.Text = "String1: ";
            // 
            // lblString2Text
            // 
            this.lblString2Text.AutoSize = true;
            this.lblString2Text.Location = new System.Drawing.Point(23, 130);
            this.lblString2Text.Name = "lblString2Text";
            this.lblString2Text.Size = new System.Drawing.Size(43, 13);
            this.lblString2Text.TabIndex = 3;
            this.lblString2Text.Text = "String2:";
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(89, 95);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(149, 20);
            this.txtString1.TabIndex = 4;
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(89, 130);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(149, 20);
            this.txtString2.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(114, 184);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblStringsEqualAns
            // 
            this.lblStringsEqualAns.AutoSize = true;
            this.lblStringsEqualAns.Location = new System.Drawing.Point(38, 224);
            this.lblStringsEqualAns.Name = "lblStringsEqualAns";
            this.lblStringsEqualAns.Size = new System.Drawing.Size(120, 13);
            this.lblStringsEqualAns.TabIndex = 7;
            this.lblStringsEqualAns.Text = "These strings are equal.";
            // 
            // frmStringEquality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 260);
            this.Controls.Add(this.lblStringsEqualAns);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.lblString2Text);
            this.Controls.Add(this.lblString1Text);
            this.Controls.Add(this.lblInstruction2);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmStringEquality";
            this.Text = "String Equality by Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Label lblString1Text;
        private System.Windows.Forms.Label lblString2Text;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblStringsEqualAns;
    }
}

