
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
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.annualSalaryLabel = new System.Windows.Forms.Label();
            this.annualProductionBonus = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.annualSalaryTextBox = new System.Windows.Forms.TextBox();
            this.annualProductionBonusTextBox = new System.Windows.Forms.TextBox();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.displayEmployeeNameLabel = new System.Windows.Forms.Label();
            this.displayEmployeeNumberLabel = new System.Windows.Forms.Label();
            this.displayAnnualSalaryLabel = new System.Windows.Forms.Label();
            this.displayAnnualProductionBonusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(13, 28);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(115, 17);
            this.employeeNameLabel.TabIndex = 0;
            this.employeeNameLabel.Text = "Employee Name:";
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.AutoSize = true;
            this.employeeNumberLabel.Location = new System.Drawing.Point(13, 56);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(128, 17);
            this.employeeNumberLabel.TabIndex = 1;
            this.employeeNumberLabel.Text = "Employee Number:";
            // 
            // annualSalaryLabel
            // 
            this.annualSalaryLabel.AutoSize = true;
            this.annualSalaryLabel.Location = new System.Drawing.Point(16, 88);
            this.annualSalaryLabel.Name = "annualSalaryLabel";
            this.annualSalaryLabel.Size = new System.Drawing.Size(100, 17);
            this.annualSalaryLabel.TabIndex = 2;
            this.annualSalaryLabel.Text = "Annual Salary:";
            // 
            // annualProductionBonus
            // 
            this.annualProductionBonus.AutoSize = true;
            this.annualProductionBonus.Location = new System.Drawing.Point(13, 118);
            this.annualProductionBonus.Name = "annualProductionBonus";
            this.annualProductionBonus.Size = new System.Drawing.Size(172, 17);
            this.annualProductionBonus.TabIndex = 3;
            this.annualProductionBonus.Text = "Annual Production Bonus:";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(135, 28);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.employeeNameTextBox.TabIndex = 4;
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.Location = new System.Drawing.Point(147, 56);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.employeeNumberTextBox.TabIndex = 5;
            // 
            // annualSalaryTextBox
            // 
            this.annualSalaryTextBox.Location = new System.Drawing.Point(122, 88);
            this.annualSalaryTextBox.Name = "annualSalaryTextBox";
            this.annualSalaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.annualSalaryTextBox.TabIndex = 6;
            // 
            // annualProductionBonusTextBox
            // 
            this.annualProductionBonusTextBox.Location = new System.Drawing.Point(192, 117);
            this.annualProductionBonusTextBox.Name = "annualProductionBonusTextBox";
            this.annualProductionBonusTextBox.Size = new System.Drawing.Size(100, 22);
            this.annualProductionBonusTextBox.TabIndex = 7;
            // 
            // createObjectButton
            // 
            this.createObjectButton.Location = new System.Drawing.Point(13, 179);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(342, 61);
            this.createObjectButton.TabIndex = 8;
            this.createObjectButton.Text = "Create Object";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // displayEmployeeNameLabel
            // 
            this.displayEmployeeNameLabel.AutoSize = true;
            this.displayEmployeeNameLabel.Location = new System.Drawing.Point(13, 264);
            this.displayEmployeeNameLabel.Name = "displayEmployeeNameLabel";
            this.displayEmployeeNameLabel.Size = new System.Drawing.Size(115, 17);
            this.displayEmployeeNameLabel.TabIndex = 9;
            this.displayEmployeeNameLabel.Text = "Employee Name:";
            // 
            // displayEmployeeNumberLabel
            // 
            this.displayEmployeeNumberLabel.AutoSize = true;
            this.displayEmployeeNumberLabel.Location = new System.Drawing.Point(13, 289);
            this.displayEmployeeNumberLabel.Name = "displayEmployeeNumberLabel";
            this.displayEmployeeNumberLabel.Size = new System.Drawing.Size(132, 17);
            this.displayEmployeeNumberLabel.TabIndex = 10;
            this.displayEmployeeNumberLabel.Text = "Employee Number: ";
            // 
            // displayAnnualSalaryLabel
            // 
            this.displayAnnualSalaryLabel.AutoSize = true;
            this.displayAnnualSalaryLabel.Location = new System.Drawing.Point(13, 316);
            this.displayAnnualSalaryLabel.Name = "displayAnnualSalaryLabel";
            this.displayAnnualSalaryLabel.Size = new System.Drawing.Size(100, 17);
            this.displayAnnualSalaryLabel.TabIndex = 11;
            this.displayAnnualSalaryLabel.Text = "Annual Salary:";
            // 
            // displayAnnualProductionBonusLabel
            // 
            this.displayAnnualProductionBonusLabel.AutoSize = true;
            this.displayAnnualProductionBonusLabel.Location = new System.Drawing.Point(13, 346);
            this.displayAnnualProductionBonusLabel.Name = "displayAnnualProductionBonusLabel";
            this.displayAnnualProductionBonusLabel.Size = new System.Drawing.Size(172, 17);
            this.displayAnnualProductionBonusLabel.TabIndex = 12;
            this.displayAnnualProductionBonusLabel.Text = "Annual Production Bonus:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayAnnualProductionBonusLabel);
            this.Controls.Add(this.displayAnnualSalaryLabel);
            this.Controls.Add(this.displayEmployeeNumberLabel);
            this.Controls.Add(this.displayEmployeeNameLabel);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.annualProductionBonusTextBox);
            this.Controls.Add(this.annualSalaryTextBox);
            this.Controls.Add(this.employeeNumberTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.annualProductionBonus);
            this.Controls.Add(this.annualSalaryLabel);
            this.Controls.Add(this.employeeNumberLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Label annualSalaryLabel;
        private System.Windows.Forms.Label annualProductionBonus;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.TextBox annualSalaryTextBox;
        private System.Windows.Forms.TextBox annualProductionBonusTextBox;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.Label displayEmployeeNameLabel;
        private System.Windows.Forms.Label displayEmployeeNumberLabel;
        private System.Windows.Forms.Label displayAnnualSalaryLabel;
        private System.Windows.Forms.Label displayAnnualProductionBonusLabel;
    }
}

