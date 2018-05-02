namespace Challenges
{
    partial class frmMain
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
            this.btnFactorialFind = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnSpeedTrack = new System.Windows.Forms.Button();
            this.btnThief = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFactorialFind
            // 
            this.btnFactorialFind.Location = new System.Drawing.Point(12, 12);
            this.btnFactorialFind.Name = "btnFactorialFind";
            this.btnFactorialFind.Size = new System.Drawing.Size(74, 35);
            this.btnFactorialFind.TabIndex = 0;
            this.btnFactorialFind.Text = "Factorial Finder";
            this.btnFactorialFind.UseVisualStyleBackColor = true;
            this.btnFactorialFind.Click += new System.EventHandler(this.btnFactorialFind_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(347, 376);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next Page";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(12, 376);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "Prev Page";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnSpeedTrack
            // 
            this.btnSpeedTrack.Location = new System.Drawing.Point(92, 12);
            this.btnSpeedTrack.Name = "btnSpeedTrack";
            this.btnSpeedTrack.Size = new System.Drawing.Size(75, 35);
            this.btnSpeedTrack.TabIndex = 3;
            this.btnSpeedTrack.Text = "Speed Tracker";
            this.btnSpeedTrack.UseVisualStyleBackColor = true;
            this.btnSpeedTrack.Click += new System.EventHandler(this.btnSpeedTrack_Click);
            // 
            // btnThief
            // 
            this.btnThief.Location = new System.Drawing.Point(174, 13);
            this.btnThief.Name = "btnThief";
            this.btnThief.Size = new System.Drawing.Size(75, 34);
            this.btnThief.TabIndex = 4;
            this.btnThief.Text = "Thief!";
            this.btnThief.UseVisualStyleBackColor = true;
            this.btnThief.Click += new System.EventHandler(this.btnThief_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.btnThief);
            this.Controls.Add(this.btnSpeedTrack);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFactorialFind);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Challenges";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFactorialFind;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnSpeedTrack;
        private System.Windows.Forms.Button btnThief;
    }
}

