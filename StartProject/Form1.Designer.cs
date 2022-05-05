namespace StartProject
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonTrace = new System.Windows.Forms.Button();
            this.buttonDebug = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonWarn = new System.Windows.Forms.Button();
            this.buttonFatal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonError = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(121, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 259);
            this.listBox1.TabIndex = 0;
            // 
            // buttonTrace
            // 
            this.buttonTrace.Location = new System.Drawing.Point(6, 31);
            this.buttonTrace.Name = "buttonTrace";
            this.buttonTrace.Size = new System.Drawing.Size(75, 23);
            this.buttonTrace.TabIndex = 1;
            this.buttonTrace.Text = "Trace";
            this.buttonTrace.UseVisualStyleBackColor = true;
            this.buttonTrace.Click += new System.EventHandler(this.buttonTrace_Click);
            // 
            // buttonDebug
            // 
            this.buttonDebug.Location = new System.Drawing.Point(6, 60);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(75, 23);
            this.buttonDebug.TabIndex = 2;
            this.buttonDebug.Text = "Debug";
            this.buttonDebug.UseVisualStyleBackColor = true;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(6, 89);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonWarn
            // 
            this.buttonWarn.Location = new System.Drawing.Point(6, 118);
            this.buttonWarn.Name = "buttonWarn";
            this.buttonWarn.Size = new System.Drawing.Size(75, 23);
            this.buttonWarn.TabIndex = 4;
            this.buttonWarn.Text = "Warn";
            this.buttonWarn.UseVisualStyleBackColor = true;
            this.buttonWarn.Click += new System.EventHandler(this.buttonWarn_Click);
            // 
            // buttonFatal
            // 
            this.buttonFatal.Location = new System.Drawing.Point(6, 176);
            this.buttonFatal.Name = "buttonFatal";
            this.buttonFatal.Size = new System.Drawing.Size(75, 23);
            this.buttonFatal.TabIndex = 5;
            this.buttonFatal.Text = "Fatal";
            this.buttonFatal.UseVisualStyleBackColor = true;
            this.buttonFatal.Click += new System.EventHandler(this.buttonFatal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonError);
            this.groupBox1.Controls.Add(this.buttonTrace);
            this.groupBox1.Controls.Add(this.buttonFatal);
            this.groupBox1.Controls.Add(this.buttonDebug);
            this.groupBox1.Controls.Add(this.buttonWarn);
            this.groupBox1.Controls.Add(this.buttonInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 259);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Level";
            // 
            // buttonError
            // 
            this.buttonError.Location = new System.Drawing.Point(6, 147);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(75, 23);
            this.buttonError.TabIndex = 6;
            this.buttonError.Text = "Error";
            this.buttonError.UseVisualStyleBackColor = true;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button buttonTrace;
        private Button buttonDebug;
        private Button buttonInfo;
        private Button buttonWarn;
        private Button buttonFatal;
        private GroupBox groupBox1;
        private Button buttonError;
    }
}