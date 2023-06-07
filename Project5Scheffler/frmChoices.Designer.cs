
namespace Project5Scheffler
{
    partial class frmChoices
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoices));
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.txtbxLeft = new System.Windows.Forms.TextBox();
            this.txtbxRight = new System.Windows.Forms.TextBox();
            this.lblCheck = new System.Windows.Forms.Label();
            this.txtbxCheck = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(776, 49);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // lblLeft
            // 
            this.lblLeft.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLeft.Location = new System.Drawing.Point(12, 58);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(348, 37);
            this.lblLeft.TabIndex = 1;
            this.lblLeft.Text = "Left Number";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRight
            // 
            this.lblRight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRight.Location = new System.Drawing.Point(440, 58);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(348, 37);
            this.lblRight.TabIndex = 2;
            this.lblRight.Text = "Right Number";
            this.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxLeft
            // 
            this.txtbxLeft.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxLeft.Location = new System.Drawing.Point(12, 98);
            this.txtbxLeft.Multiline = true;
            this.txtbxLeft.Name = "txtbxLeft";
            this.txtbxLeft.Size = new System.Drawing.Size(348, 37);
            this.txtbxLeft.TabIndex = 3;
            this.txtbxLeft.TabStop = false;
            // 
            // txtbxRight
            // 
            this.txtbxRight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxRight.Location = new System.Drawing.Point(440, 98);
            this.txtbxRight.Multiline = true;
            this.txtbxRight.Name = "txtbxRight";
            this.txtbxRight.Size = new System.Drawing.Size(348, 37);
            this.txtbxRight.TabIndex = 4;
            this.txtbxRight.TabStop = false;
            // 
            // lblCheck
            // 
            this.lblCheck.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCheck.Location = new System.Drawing.Point(226, 138);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(348, 37);
            this.lblCheck.TabIndex = 5;
            this.lblCheck.Text = "Number to be Checked";
            this.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxCheck
            // 
            this.txtbxCheck.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbxCheck.Location = new System.Drawing.Point(226, 178);
            this.txtbxCheck.Multiline = true;
            this.txtbxCheck.Name = "txtbxCheck";
            this.txtbxCheck.Size = new System.Drawing.Size(348, 37);
            this.txtbxCheck.TabIndex = 6;
            this.txtbxCheck.TabStop = false;
            this.txtbxCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxCheck_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 221);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(178, 117);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(310, 221);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(178, 117);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCheck_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(610, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 117);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.BackColor = System.Drawing.Color.PowderBlue;
            this.lblUserMessage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserMessage.Location = new System.Drawing.Point(12, 341);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(776, 100);
            this.lblUserMessage.TabIndex = 10;
            this.lblUserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtbxCheck);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.txtbxRight);
            this.Controls.Add(this.txtbxLeft);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmChoices";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.TextBox txtbxLeft;
        private System.Windows.Forms.TextBox txtbxRight;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.TextBox txtbxCheck;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUserMessage;
    }
}

