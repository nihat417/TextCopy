namespace TextCopy
{
    partial class Form1
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
            this.FileTxt1 = new System.Windows.Forms.TextBox();
            this.FileTxt2 = new System.Windows.Forms.TextBox();
            this.FileBtn1 = new System.Windows.Forms.Button();
            this.FileBtn2 = new System.Windows.Forms.Button();
            this.SuspendBtn = new System.Windows.Forms.Button();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.AbortBtn = new System.Windows.Forms.Button();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // FileTxt1
            // 
            this.FileTxt1.Location = new System.Drawing.Point(12, 12);
            this.FileTxt1.Name = "FileTxt1";
            this.FileTxt1.Size = new System.Drawing.Size(445, 27);
            this.FileTxt1.TabIndex = 0;
            // 
            // FileTxt2
            // 
            this.FileTxt2.Location = new System.Drawing.Point(12, 56);
            this.FileTxt2.Name = "FileTxt2";
            this.FileTxt2.Size = new System.Drawing.Size(445, 27);
            this.FileTxt2.TabIndex = 1;
            // 
            // FileBtn1
            // 
            this.FileBtn1.Location = new System.Drawing.Point(490, 12);
            this.FileBtn1.Name = "FileBtn1";
            this.FileBtn1.Size = new System.Drawing.Size(94, 27);
            this.FileBtn1.TabIndex = 2;
            this.FileBtn1.Text = "File";
            this.FileBtn1.UseVisualStyleBackColor = true;
            this.FileBtn1.Click += new System.EventHandler(this.FileBtn1_Click);
            // 
            // FileBtn2
            // 
            this.FileBtn2.Location = new System.Drawing.Point(490, 56);
            this.FileBtn2.Name = "FileBtn2";
            this.FileBtn2.Size = new System.Drawing.Size(94, 27);
            this.FileBtn2.TabIndex = 3;
            this.FileBtn2.Text = "File";
            this.FileBtn2.UseVisualStyleBackColor = true;
            this.FileBtn2.Click += new System.EventHandler(this.FileBtn2_Click);
            // 
            // SuspendBtn
            // 
            this.SuspendBtn.Location = new System.Drawing.Point(12, 107);
            this.SuspendBtn.Name = "SuspendBtn";
            this.SuspendBtn.Size = new System.Drawing.Size(94, 27);
            this.SuspendBtn.TabIndex = 4;
            this.SuspendBtn.Text = "Suspend";
            this.SuspendBtn.UseVisualStyleBackColor = true;
            this.SuspendBtn.Click += new System.EventHandler(this.SuspendBtn_Click);
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.Location = new System.Drawing.Point(112, 107);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(94, 27);
            this.ResumeBtn.TabIndex = 5;
            this.ResumeBtn.Text = "Resume";
            this.ResumeBtn.UseVisualStyleBackColor = true;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // AbortBtn
            // 
            this.AbortBtn.Location = new System.Drawing.Point(212, 107);
            this.AbortBtn.Name = "AbortBtn";
            this.AbortBtn.Size = new System.Drawing.Size(94, 27);
            this.AbortBtn.TabIndex = 6;
            this.AbortBtn.Text = "Abort";
            this.AbortBtn.UseVisualStyleBackColor = true;
            this.AbortBtn.Click += new System.EventHandler(this.AbortBtn_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(312, 107);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(94, 27);
            this.CopyBtn.TabIndex = 7;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 152);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(445, 25);
            this.progressBar1.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 200);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.AbortBtn);
            this.Controls.Add(this.ResumeBtn);
            this.Controls.Add(this.SuspendBtn);
            this.Controls.Add(this.FileBtn2);
            this.Controls.Add(this.FileBtn1);
            this.Controls.Add(this.FileTxt2);
            this.Controls.Add(this.FileTxt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FileTxt1;
        private TextBox FileTxt2;
        private Button FileBtn1;
        private Button FileBtn2;
        private Button SuspendBtn;
        private Button ResumeBtn;
        private Button AbortBtn;
        private Button CopyBtn;
        private ProgressBar progressBar1;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
    }
}