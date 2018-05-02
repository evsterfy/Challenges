namespace Challenges
{
    partial class frmThief
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
            this.lblDigits = new System.Windows.Forms.Label();
            this.txtDigits = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblCombos = new System.Windows.Forms.Label();
            this.listCombos = new System.Windows.Forms.ListBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.Location = new System.Drawing.Point(158, 32);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(114, 13);
            this.lblDigits.TabIndex = 0;
            this.lblDigits.Text = "Enter 5 or Fewer Digits";
            // 
            // txtDigits
            // 
            this.txtDigits.Location = new System.Drawing.Point(165, 64);
            this.txtDigits.Name = "txtDigits";
            this.txtDigits.Size = new System.Drawing.Size(100, 20);
            this.txtDigits.TabIndex = 1;
            this.txtDigits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(63, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(305, 23);
            this.lblError.TabIndex = 2;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(178, 95);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblCombos
            // 
            this.lblCombos.AutoSize = true;
            this.lblCombos.Location = new System.Drawing.Point(160, 157);
            this.lblCombos.Name = "lblCombos";
            this.lblCombos.Size = new System.Drawing.Size(112, 13);
            this.lblCombos.TabIndex = 4;
            this.lblCombos.Text = "Possible Combinations";
            // 
            // listCombos
            // 
            this.listCombos.FormattingEnabled = true;
            this.listCombos.Location = new System.Drawing.Point(178, 183);
            this.listCombos.Name = "listCombos";
            this.listCombos.Size = new System.Drawing.Size(75, 95);
            this.listCombos.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(178, 376);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(165, 295);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(100, 23);
            this.lblCount.TabIndex = 7;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThief
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.listCombos);
            this.Controls.Add(this.lblCombos);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtDigits);
            this.Controls.Add(this.lblDigits);
            this.Name = "frmThief";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thief!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDigits;
        private System.Windows.Forms.TextBox txtDigits;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblCombos;
        private System.Windows.Forms.ListBox listCombos;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblCount;
    }
}