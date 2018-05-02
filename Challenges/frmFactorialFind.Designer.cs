namespace Challenges
{
    partial class frmFactorialFind
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
            this.txtFactorialInput = new System.Windows.Forms.TextBox();
            this.lblFactorial = new System.Windows.Forms.Label();
            this.btnSolveFactorial = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFactorialInput
            // 
            this.txtFactorialInput.Location = new System.Drawing.Point(87, 106);
            this.txtFactorialInput.Name = "txtFactorialInput";
            this.txtFactorialInput.Size = new System.Drawing.Size(237, 20);
            this.txtFactorialInput.TabIndex = 1;
            this.txtFactorialInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFactorial
            // 
            this.lblFactorial.AutoSize = true;
            this.lblFactorial.Location = new System.Drawing.Point(154, 77);
            this.lblFactorial.Name = "lblFactorial";
            this.lblFactorial.Size = new System.Drawing.Size(106, 13);
            this.lblFactorial.TabIndex = 2;
            this.lblFactorial.Text = "Enter Whole Number";
            // 
            // btnSolveFactorial
            // 
            this.btnSolveFactorial.Location = new System.Drawing.Point(170, 142);
            this.btnSolveFactorial.Name = "btnSolveFactorial";
            this.btnSolveFactorial.Size = new System.Drawing.Size(75, 34);
            this.btnSolveFactorial.TabIndex = 3;
            this.btnSolveFactorial.Text = "Solve Factorial";
            this.btnSolveFactorial.UseVisualStyleBackColor = true;
            this.btnSolveFactorial.Click += new System.EventHandler(this.btnSolveFactorial_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(170, 353);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmFactorialFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSolveFactorial);
            this.Controls.Add(this.lblFactorial);
            this.Controls.Add(this.txtFactorialInput);
            this.Name = "frmFactorialFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factorial Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFactorialInput;
        private System.Windows.Forms.Label lblFactorial;
        private System.Windows.Forms.Button btnSolveFactorial;
        private System.Windows.Forms.Button btnHome;
    }
}