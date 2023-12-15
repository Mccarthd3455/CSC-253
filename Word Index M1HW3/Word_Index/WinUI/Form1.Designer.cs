
namespace WinUI
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
            this.indexFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // indexFileButton
            // 
            this.indexFileButton.Location = new System.Drawing.Point(23, 234);
            this.indexFileButton.Name = "indexFileButton";
            this.indexFileButton.Size = new System.Drawing.Size(686, 23);
            this.indexFileButton.TabIndex = 0;
            this.indexFileButton.Text = "Index the File";
            this.indexFileButton.UseVisualStyleBackColor = true;
            this.indexFileButton.Click += new System.EventHandler(this.indexFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indexFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button indexFileButton;
    }
}

