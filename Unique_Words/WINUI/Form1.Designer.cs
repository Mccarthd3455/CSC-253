
namespace WINUI
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
            this.fileLabel = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.unduplicatedFileLabel = new System.Windows.Forms.Label();
            this.readFileAndUnduplicatebutton = new System.Windows.Forms.Button();
            this.undupedWordsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(25, 23);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(26, 13);
            this.fileLabel.TabIndex = 0;
            this.fileLabel.Text = "File:";
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(28, 44);
            this.fileTextBox.Multiline = true;
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileTextBox.Size = new System.Drawing.Size(194, 112);
            this.fileTextBox.TabIndex = 1;
            // 
            // unduplicatedFileLabel
            // 
            this.unduplicatedFileLabel.AutoSize = true;
            this.unduplicatedFileLabel.Location = new System.Drawing.Point(359, 31);
            this.unduplicatedFileLabel.Name = "unduplicatedFileLabel";
            this.unduplicatedFileLabel.Size = new System.Drawing.Size(92, 13);
            this.unduplicatedFileLabel.TabIndex = 2;
            this.unduplicatedFileLabel.Text = "Unduplicated File:";
            // 
            // readFileAndUnduplicatebutton
            // 
            this.readFileAndUnduplicatebutton.Location = new System.Drawing.Point(23, 230);
            this.readFileAndUnduplicatebutton.Name = "readFileAndUnduplicatebutton";
            this.readFileAndUnduplicatebutton.Size = new System.Drawing.Size(199, 24);
            this.readFileAndUnduplicatebutton.TabIndex = 3;
            this.readFileAndUnduplicatebutton.Text = "Read the File and Unduplicate it";
            this.readFileAndUnduplicatebutton.UseVisualStyleBackColor = true;
            this.readFileAndUnduplicatebutton.Click += new System.EventHandler(this.readFileAndUnduplicatebutton_Click);
            // 
            // undupedWordsTextBox
            // 
            this.undupedWordsTextBox.Location = new System.Drawing.Point(365, 53);
            this.undupedWordsTextBox.Multiline = true;
            this.undupedWordsTextBox.Name = "undupedWordsTextBox";
            this.undupedWordsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.undupedWordsTextBox.Size = new System.Drawing.Size(252, 103);
            this.undupedWordsTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.undupedWordsTextBox);
            this.Controls.Add(this.readFileAndUnduplicatebutton);
            this.Controls.Add(this.unduplicatedFileLabel);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.fileLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label unduplicatedFileLabel;
        private System.Windows.Forms.Button readFileAndUnduplicatebutton;
        private System.Windows.Forms.TextBox undupedWordsTextBox;
    }
}

