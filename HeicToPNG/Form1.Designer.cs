namespace HeicToPNG
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.folderNameLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.deleteOriginalCheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать папку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderNameLabel
            // 
            this.folderNameLabel.AutoSize = true;
            this.folderNameLabel.Location = new System.Drawing.Point(12, 62);
            this.folderNameLabel.Name = "folderNameLabel";
            this.folderNameLabel.Size = new System.Drawing.Size(0, 16);
            this.folderNameLabel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Конвертировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteOriginalCheckBox
            // 
            this.deleteOriginalCheckBox.AutoSize = true;
            this.deleteOriginalCheckBox.Location = new System.Drawing.Point(15, 94);
            this.deleteOriginalCheckBox.Name = "deleteOriginalCheckBox";
            this.deleteOriginalCheckBox.Size = new System.Drawing.Size(155, 20);
            this.deleteOriginalCheckBox.TabIndex = 3;
            this.deleteOriginalCheckBox.Text = "Удалить оригиналы";
            this.deleteOriginalCheckBox.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 172);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(309, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 241);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.deleteOriginalCheckBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.folderNameLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label folderNameLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox deleteOriginalCheckBox;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

