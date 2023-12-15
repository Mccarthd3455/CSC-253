
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
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.howToCheckLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(128, 159);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(222, 88);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.Text = "Encrypt File";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(466, 159);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(222, 88);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.Text = "Decrypt File";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLabel.Location = new System.Drawing.Point(210, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(383, 39);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "File Encrypter/Decrypter";
            // 
            // howToCheckLabel
            // 
            this.howToCheckLabel.AutoSize = true;
            this.howToCheckLabel.Location = new System.Drawing.Point(182, 97);
            this.howToCheckLabel.Name = "howToCheckLabel";
            this.howToCheckLabel.Size = new System.Drawing.Size(428, 17);
            this.howToCheckLabel.TabIndex = 3;
            this.howToCheckLabel.Text = "Check the debug bin folder for the text files after hitting the buttons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.howToCheckLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label howToCheckLabel;
    }
}

