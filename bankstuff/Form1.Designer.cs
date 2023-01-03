namespace BankStuff
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
            this.findtextfile = new System.Windows.Forms.OpenFileDialog();
            this.sevendigetinputTB = new System.Windows.Forms.TextBox();
            this.sevendigetinputGB = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkusernumber = new System.Windows.Forms.Button();
            this.sevendigetinputGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // findtextfile
            // 
            this.findtextfile.FileName = "openFileDialog1";
            // 
            // sevendigetinputTB
            // 
            this.sevendigetinputTB.Location = new System.Drawing.Point(6, 27);
            this.sevendigetinputTB.Name = "sevendigetinputTB";
            this.sevendigetinputTB.Size = new System.Drawing.Size(100, 20);
            this.sevendigetinputTB.TabIndex = 0;
            // 
            // sevendigetinputGB
            // 
            this.sevendigetinputGB.Controls.Add(this.sevendigetinputTB);
            this.sevendigetinputGB.Location = new System.Drawing.Point(13, 13);
            this.sevendigetinputGB.Name = "sevendigetinputGB";
            this.sevendigetinputGB.Size = new System.Drawing.Size(117, 53);
            this.sevendigetinputGB.TabIndex = 1;
            this.sevendigetinputGB.TabStop = false;
            this.sevendigetinputGB.Text = "Input your 7 diget number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // checkusernumber
            // 
            this.checkusernumber.Location = new System.Drawing.Point(32, 72);
            this.checkusernumber.Name = "checkusernumber";
            this.checkusernumber.Size = new System.Drawing.Size(75, 23);
            this.checkusernumber.TabIndex = 3;
            this.checkusernumber.Text = "Next";
            this.checkusernumber.UseVisualStyleBackColor = true;
            this.checkusernumber.Click += new System.EventHandler(this.checkusernumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 110);
            this.Controls.Add(this.checkusernumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sevendigetinputGB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sevendigetinputGB.ResumeLayout(false);
            this.sevendigetinputGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog findtextfile;
        private System.Windows.Forms.TextBox sevendigetinputTB;
        private System.Windows.Forms.GroupBox sevendigetinputGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkusernumber;
    }
}

