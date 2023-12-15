
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
            this.courseInfoLabel = new System.Windows.Forms.Label();
            this.courseInfoTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.meetingTimeLabel = new System.Windows.Forms.Label();
            this.findCourseInfoButton = new System.Windows.Forms.Button();
            this.programTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseInfoLabel
            // 
            this.courseInfoLabel.AutoSize = true;
            this.courseInfoLabel.Location = new System.Drawing.Point(14, 100);
            this.courseInfoLabel.Name = "courseInfoLabel";
            this.courseInfoLabel.Size = new System.Drawing.Size(96, 17);
            this.courseInfoLabel.TabIndex = 0;
            this.courseInfoLabel.Text = "Insert Course:";
            // 
            // courseInfoTextBox
            // 
            this.courseInfoTextBox.Location = new System.Drawing.Point(126, 100);
            this.courseInfoTextBox.Name = "courseInfoTextBox";
            this.courseInfoTextBox.Size = new System.Drawing.Size(100, 22);
            this.courseInfoTextBox.TabIndex = 1;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(14, 135);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.roomNumberLabel.TabIndex = 2;
            this.roomNumberLabel.Text = "Room Number:";
            // 
            // instructorLabel
            // 
            this.instructorLabel.AutoSize = true;
            this.instructorLabel.Location = new System.Drawing.Point(14, 172);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(71, 17);
            this.instructorLabel.TabIndex = 3;
            this.instructorLabel.Text = "Instructor:";
            // 
            // meetingTimeLabel
            // 
            this.meetingTimeLabel.AutoSize = true;
            this.meetingTimeLabel.Location = new System.Drawing.Point(12, 206);
            this.meetingTimeLabel.Name = "meetingTimeLabel";
            this.meetingTimeLabel.Size = new System.Drawing.Size(97, 17);
            this.meetingTimeLabel.TabIndex = 4;
            this.meetingTimeLabel.Text = "Meeting Time:";
            // 
            // findCourseInfoButton
            // 
            this.findCourseInfoButton.Location = new System.Drawing.Point(34, 249);
            this.findCourseInfoButton.Name = "findCourseInfoButton";
            this.findCourseInfoButton.Size = new System.Drawing.Size(180, 23);
            this.findCourseInfoButton.TabIndex = 5;
            this.findCourseInfoButton.Text = "Find Course Info";
            this.findCourseInfoButton.UseVisualStyleBackColor = true;
            this.findCourseInfoButton.Click += new System.EventHandler(this.findCourseInfoButton_Click);
            // 
            // programTitleLabel
            // 
            this.programTitleLabel.AutoSize = true;
            this.programTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.programTitleLabel.Font = new System.Drawing.Font("Mongolian Baiti", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programTitleLabel.Location = new System.Drawing.Point(116, 25);
            this.programTitleLabel.Name = "programTitleLabel";
            this.programTitleLabel.Size = new System.Drawing.Size(588, 55);
            this.programTitleLabel.TabIndex = 6;
            this.programTitleLabel.Text = "Course Information Finder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.programTitleLabel);
            this.Controls.Add(this.findCourseInfoButton);
            this.Controls.Add(this.meetingTimeLabel);
            this.Controls.Add(this.instructorLabel);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.courseInfoTextBox);
            this.Controls.Add(this.courseInfoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseInfoLabel;
        private System.Windows.Forms.TextBox courseInfoTextBox;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label instructorLabel;
        private System.Windows.Forms.Label meetingTimeLabel;
        private System.Windows.Forms.Button findCourseInfoButton;
        private System.Windows.Forms.Label programTitleLabel;
    }
}

