namespace Challenges
{
    partial class frmSpeedTracker
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
            this.btnHome = new System.Windows.Forms.Button();
            this.lblFirstcam = new System.Windows.Forms.Label();
            this.lblSecondCam = new System.Windows.Forms.Label();
            this.lblHourFirst = new System.Windows.Forms.Label();
            this.lblMinFirst = new System.Windows.Forms.Label();
            this.lblSecondFirst = new System.Windows.Forms.Label();
            this.txtHourFirst = new System.Windows.Forms.TextBox();
            this.txtMinFirst = new System.Windows.Forms.TextBox();
            this.txtSecondFirst = new System.Windows.Forms.TextBox();
            this.cbAmPmFirst = new System.Windows.Forms.ComboBox();
            this.cbAmPmSecond = new System.Windows.Forms.ComboBox();
            this.txtSecondSecond = new System.Windows.Forms.TextBox();
            this.txtMinSecond = new System.Windows.Forms.TextBox();
            this.txtHourSecond = new System.Windows.Forms.TextBox();
            this.lblSecondSecond = new System.Windows.Forms.Label();
            this.lblMinSecond = new System.Windows.Forms.Label();
            this.lblHourSecond = new System.Windows.Forms.Label();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtValid = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblValid = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(178, 376);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblFirstcam
            // 
            this.lblFirstcam.AutoSize = true;
            this.lblFirstcam.Location = new System.Drawing.Point(48, 33);
            this.lblFirstcam.Name = "lblFirstcam";
            this.lblFirstcam.Size = new System.Drawing.Size(91, 13);
            this.lblFirstcam.TabIndex = 1;
            this.lblFirstcam.Text = "First Camera Time";
            // 
            // lblSecondCam
            // 
            this.lblSecondCam.AutoSize = true;
            this.lblSecondCam.Location = new System.Drawing.Point(267, 33);
            this.lblSecondCam.Name = "lblSecondCam";
            this.lblSecondCam.Size = new System.Drawing.Size(109, 13);
            this.lblSecondCam.TabIndex = 2;
            this.lblSecondCam.Text = "Second Camera Time";
            // 
            // lblHourFirst
            // 
            this.lblHourFirst.AutoSize = true;
            this.lblHourFirst.Location = new System.Drawing.Point(59, 59);
            this.lblHourFirst.Name = "lblHourFirst";
            this.lblHourFirst.Size = new System.Drawing.Size(26, 13);
            this.lblHourFirst.TabIndex = 3;
            this.lblHourFirst.Text = "HH:";
            // 
            // lblMinFirst
            // 
            this.lblMinFirst.AutoSize = true;
            this.lblMinFirst.Location = new System.Drawing.Point(59, 81);
            this.lblMinFirst.Name = "lblMinFirst";
            this.lblMinFirst.Size = new System.Drawing.Size(28, 13);
            this.lblMinFirst.TabIndex = 4;
            this.lblMinFirst.Text = "MM:";
            // 
            // lblSecondFirst
            // 
            this.lblSecondFirst.AutoSize = true;
            this.lblSecondFirst.Location = new System.Drawing.Point(61, 103);
            this.lblSecondFirst.Name = "lblSecondFirst";
            this.lblSecondFirst.Size = new System.Drawing.Size(24, 13);
            this.lblSecondFirst.TabIndex = 5;
            this.lblSecondFirst.Text = "SS:";
            // 
            // txtHourFirst
            // 
            this.txtHourFirst.Location = new System.Drawing.Point(91, 56);
            this.txtHourFirst.Name = "txtHourFirst";
            this.txtHourFirst.Size = new System.Drawing.Size(33, 20);
            this.txtHourFirst.TabIndex = 6;
            this.txtHourFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinFirst
            // 
            this.txtMinFirst.Location = new System.Drawing.Point(91, 78);
            this.txtMinFirst.Name = "txtMinFirst";
            this.txtMinFirst.Size = new System.Drawing.Size(33, 20);
            this.txtMinFirst.TabIndex = 7;
            this.txtMinFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSecondFirst
            // 
            this.txtSecondFirst.Location = new System.Drawing.Point(91, 100);
            this.txtSecondFirst.Name = "txtSecondFirst";
            this.txtSecondFirst.Size = new System.Drawing.Size(33, 20);
            this.txtSecondFirst.TabIndex = 8;
            this.txtSecondFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbAmPmFirst
            // 
            this.cbAmPmFirst.FormattingEnabled = true;
            this.cbAmPmFirst.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbAmPmFirst.Location = new System.Drawing.Point(83, 126);
            this.cbAmPmFirst.Name = "cbAmPmFirst";
            this.cbAmPmFirst.Size = new System.Drawing.Size(41, 21);
            this.cbAmPmFirst.TabIndex = 9;
            this.cbAmPmFirst.Text = "AM";
            // 
            // cbAmPmSecond
            // 
            this.cbAmPmSecond.FormattingEnabled = true;
            this.cbAmPmSecond.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbAmPmSecond.Location = new System.Drawing.Point(310, 122);
            this.cbAmPmSecond.Name = "cbAmPmSecond";
            this.cbAmPmSecond.Size = new System.Drawing.Size(41, 21);
            this.cbAmPmSecond.TabIndex = 16;
            this.cbAmPmSecond.Text = "AM";
            // 
            // txtSecondSecond
            // 
            this.txtSecondSecond.Location = new System.Drawing.Point(318, 96);
            this.txtSecondSecond.Name = "txtSecondSecond";
            this.txtSecondSecond.Size = new System.Drawing.Size(33, 20);
            this.txtSecondSecond.TabIndex = 15;
            this.txtSecondSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinSecond
            // 
            this.txtMinSecond.Location = new System.Drawing.Point(318, 74);
            this.txtMinSecond.Name = "txtMinSecond";
            this.txtMinSecond.Size = new System.Drawing.Size(33, 20);
            this.txtMinSecond.TabIndex = 14;
            this.txtMinSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHourSecond
            // 
            this.txtHourSecond.Location = new System.Drawing.Point(318, 52);
            this.txtHourSecond.Name = "txtHourSecond";
            this.txtHourSecond.Size = new System.Drawing.Size(33, 20);
            this.txtHourSecond.TabIndex = 13;
            this.txtHourSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSecondSecond
            // 
            this.lblSecondSecond.AutoSize = true;
            this.lblSecondSecond.Location = new System.Drawing.Point(288, 99);
            this.lblSecondSecond.Name = "lblSecondSecond";
            this.lblSecondSecond.Size = new System.Drawing.Size(24, 13);
            this.lblSecondSecond.TabIndex = 12;
            this.lblSecondSecond.Text = "SS:";
            // 
            // lblMinSecond
            // 
            this.lblMinSecond.AutoSize = true;
            this.lblMinSecond.Location = new System.Drawing.Point(286, 77);
            this.lblMinSecond.Name = "lblMinSecond";
            this.lblMinSecond.Size = new System.Drawing.Size(28, 13);
            this.lblMinSecond.TabIndex = 11;
            this.lblMinSecond.Text = "MM:";
            // 
            // lblHourSecond
            // 
            this.lblHourSecond.AutoSize = true;
            this.lblHourSecond.Location = new System.Drawing.Point(286, 55);
            this.lblHourSecond.Name = "lblHourSecond";
            this.lblHourSecond.Size = new System.Drawing.Size(26, 13);
            this.lblHourSecond.TabIndex = 10;
            this.lblHourSecond.Text = "HH:";
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(165, 191);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(100, 20);
            this.txtLicense.TabIndex = 17;
            this.txtLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(130, 166);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(184, 13);
            this.lblLicense.TabIndex = 18;
            this.lblLicense.Text = "Optional License Plate - ex: XXX XXX";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(178, 228);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 19;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(62, 316);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 20;
            this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValid
            // 
            this.txtValid.Location = new System.Drawing.Point(251, 316);
            this.txtValid.Name = "txtValid";
            this.txtValid.Size = new System.Drawing.Size(100, 20);
            this.txtValid.TabIndex = 21;
            this.txtValid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(59, 297);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(114, 13);
            this.lblSpeed.TabIndex = 22;
            this.lblSpeed.Text = "Average Speed - MPH";
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(248, 297);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(107, 13);
            this.lblValid.TabIndex = 23;
            this.lblValid.Text = "License Plate Validity";
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(140, 55);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(140, 65);
            this.lblError.TabIndex = 24;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSpeedTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.txtValid);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.cbAmPmSecond);
            this.Controls.Add(this.txtSecondSecond);
            this.Controls.Add(this.txtMinSecond);
            this.Controls.Add(this.txtHourSecond);
            this.Controls.Add(this.lblSecondSecond);
            this.Controls.Add(this.lblMinSecond);
            this.Controls.Add(this.lblHourSecond);
            this.Controls.Add(this.cbAmPmFirst);
            this.Controls.Add(this.txtSecondFirst);
            this.Controls.Add(this.txtMinFirst);
            this.Controls.Add(this.txtHourFirst);
            this.Controls.Add(this.lblSecondFirst);
            this.Controls.Add(this.lblMinFirst);
            this.Controls.Add(this.lblHourFirst);
            this.Controls.Add(this.lblSecondCam);
            this.Controls.Add(this.lblFirstcam);
            this.Controls.Add(this.btnHome);
            this.Name = "frmSpeedTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speed Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblFirstcam;
        private System.Windows.Forms.Label lblSecondCam;
        private System.Windows.Forms.Label lblHourFirst;
        private System.Windows.Forms.Label lblMinFirst;
        private System.Windows.Forms.Label lblSecondFirst;
        private System.Windows.Forms.TextBox txtHourFirst;
        private System.Windows.Forms.TextBox txtMinFirst;
        private System.Windows.Forms.TextBox txtSecondFirst;
        private System.Windows.Forms.ComboBox cbAmPmFirst;
        private System.Windows.Forms.ComboBox cbAmPmSecond;
        private System.Windows.Forms.TextBox txtSecondSecond;
        private System.Windows.Forms.TextBox txtMinSecond;
        private System.Windows.Forms.TextBox txtHourSecond;
        private System.Windows.Forms.Label lblSecondSecond;
        private System.Windows.Forms.Label lblMinSecond;
        private System.Windows.Forms.Label lblHourSecond;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtValid;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Label lblError;
    }
}