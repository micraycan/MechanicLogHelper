namespace MechanicLogHelper
{
    partial class MainForm
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
            this.treeViewLogs = new System.Windows.Forms.TreeView();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.vehicleInput = new System.Windows.Forms.TextBox();
            this.licenseInput = new System.Windows.Forms.TextBox();
            this.vehicleLabel = new System.Windows.Forms.Label();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.customerGroup = new System.Windows.Forms.GroupBox();
            this.employeeCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.armorAmountInput = new System.Windows.Forms.TextBox();
            this.brakeAmountInput = new System.Windows.Forms.TextBox();
            this.brakeCheckbox = new System.Windows.Forms.CheckBox();
            this.armorCheckbox = new System.Windows.Forms.CheckBox();
            this.saveLogBtn = new System.Windows.Forms.Button();
            this.clearLogsBtn = new System.Windows.Forms.Button();
            this.deleteLogBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.customerGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewLogs
            // 
            this.treeViewLogs.Location = new System.Drawing.Point(24, 83);
            this.treeViewLogs.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.treeViewLogs.Name = "treeViewLogs";
            this.treeViewLogs.Size = new System.Drawing.Size(532, 678);
            this.treeViewLogs.TabIndex = 0;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(34, 48);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(172, 25);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // customerNameInput
            // 
            this.customerNameInput.Location = new System.Drawing.Point(286, 42);
            this.customerNameInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(316, 31);
            this.customerNameInput.TabIndex = 2;
            // 
            // vehicleInput
            // 
            this.vehicleInput.Location = new System.Drawing.Point(286, 92);
            this.vehicleInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.vehicleInput.Name = "vehicleInput";
            this.vehicleInput.Size = new System.Drawing.Size(316, 31);
            this.vehicleInput.TabIndex = 2;
            // 
            // licenseInput
            // 
            this.licenseInput.Location = new System.Drawing.Point(286, 142);
            this.licenseInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.licenseInput.Name = "licenseInput";
            this.licenseInput.Size = new System.Drawing.Size(316, 31);
            this.licenseInput.TabIndex = 2;
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Location = new System.Drawing.Point(34, 98);
            this.vehicleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(236, 25);
            this.vehicleLabel.TabIndex = 1;
            this.vehicleLabel.Text = "Vehicle | [Make/Model]:";
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Location = new System.Drawing.Point(34, 148);
            this.licenseLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(148, 25);
            this.licenseLabel.TabIndex = 1;
            this.licenseLabel.Text = "License Plate:";
            // 
            // customerGroup
            // 
            this.customerGroup.Controls.Add(this.employeeCheckbox);
            this.customerGroup.Controls.Add(this.vehicleLabel);
            this.customerGroup.Controls.Add(this.licenseInput);
            this.customerGroup.Controls.Add(this.customerNameLabel);
            this.customerGroup.Controls.Add(this.vehicleInput);
            this.customerGroup.Controls.Add(this.licenseLabel);
            this.customerGroup.Controls.Add(this.customerNameInput);
            this.customerGroup.Location = new System.Drawing.Point(572, 83);
            this.customerGroup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.customerGroup.Name = "customerGroup";
            this.customerGroup.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.customerGroup.Size = new System.Drawing.Size(648, 258);
            this.customerGroup.TabIndex = 3;
            this.customerGroup.TabStop = false;
            this.customerGroup.Text = "Customer Info";
            // 
            // employeeCheckbox
            // 
            this.employeeCheckbox.AutoSize = true;
            this.employeeCheckbox.Location = new System.Drawing.Point(286, 194);
            this.employeeCheckbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.employeeCheckbox.Name = "employeeCheckbox";
            this.employeeCheckbox.Size = new System.Drawing.Size(188, 29);
            this.employeeCheckbox.TabIndex = 3;
            this.employeeCheckbox.Text = "Employee Sale";
            this.employeeCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.armorAmountInput);
            this.groupBox1.Controls.Add(this.brakeAmountInput);
            this.groupBox1.Controls.Add(this.brakeCheckbox);
            this.groupBox1.Controls.Add(this.armorCheckbox);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(574, 352);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1184, 409);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installed Upgrades";
            // 
            // armorAmountInput
            // 
            this.armorAmountInput.Location = new System.Drawing.Point(284, 62);
            this.armorAmountInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.armorAmountInput.Name = "armorAmountInput";
            this.armorAmountInput.Size = new System.Drawing.Size(316, 31);
            this.armorAmountInput.TabIndex = 5;
            // 
            // brakeAmountInput
            // 
            this.brakeAmountInput.Location = new System.Drawing.Point(284, 115);
            this.brakeAmountInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.brakeAmountInput.Name = "brakeAmountInput";
            this.brakeAmountInput.Size = new System.Drawing.Size(316, 31);
            this.brakeAmountInput.TabIndex = 5;
            // 
            // brakeCheckbox
            // 
            this.brakeCheckbox.AutoSize = true;
            this.brakeCheckbox.Location = new System.Drawing.Point(38, 115);
            this.brakeCheckbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.brakeCheckbox.Name = "brakeCheckbox";
            this.brakeCheckbox.Size = new System.Drawing.Size(111, 29);
            this.brakeCheckbox.TabIndex = 0;
            this.brakeCheckbox.Text = "Brakes";
            this.brakeCheckbox.UseVisualStyleBackColor = true;
            // 
            // armorCheckbox
            // 
            this.armorCheckbox.AutoSize = true;
            this.armorCheckbox.Location = new System.Drawing.Point(38, 65);
            this.armorCheckbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.armorCheckbox.Name = "armorCheckbox";
            this.armorCheckbox.Size = new System.Drawing.Size(101, 29);
            this.armorCheckbox.TabIndex = 0;
            this.armorCheckbox.Text = "Armor";
            this.armorCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveLogBtn
            // 
            this.saveLogBtn.Location = new System.Drawing.Point(574, 773);
            this.saveLogBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.saveLogBtn.Name = "saveLogBtn";
            this.saveLogBtn.Size = new System.Drawing.Size(272, 44);
            this.saveLogBtn.TabIndex = 5;
            this.saveLogBtn.Text = "Save Log";
            this.saveLogBtn.UseVisualStyleBackColor = true;
            // 
            // clearLogsBtn
            // 
            this.clearLogsBtn.Location = new System.Drawing.Point(24, 773);
            this.clearLogsBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clearLogsBtn.Name = "clearLogsBtn";
            this.clearLogsBtn.Size = new System.Drawing.Size(272, 44);
            this.clearLogsBtn.TabIndex = 5;
            this.clearLogsBtn.Text = "Clear All Logs";
            this.clearLogsBtn.UseVisualStyleBackColor = true;
            // 
            // deleteLogBtn
            // 
            this.deleteLogBtn.Location = new System.Drawing.Point(858, 773);
            this.deleteLogBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deleteLogBtn.Name = "deleteLogBtn";
            this.deleteLogBtn.Size = new System.Drawing.Size(272, 44);
            this.deleteLogBtn.TabIndex = 5;
            this.deleteLogBtn.Text = "Delete Log";
            this.deleteLogBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(1142, 773);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(272, 44);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 836);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteLogBtn);
            this.Controls.Add(this.clearLogsBtn);
            this.Controls.Add(this.saveLogBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerGroup);
            this.Controls.Add(this.treeViewLogs);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Mechanic Log Helper v1.0";
            this.customerGroup.ResumeLayout(false);
            this.customerGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewLogs;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.TextBox vehicleInput;
        private System.Windows.Forms.TextBox licenseInput;
        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.GroupBox customerGroup;
        private System.Windows.Forms.CheckBox employeeCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox armorCheckbox;
        private System.Windows.Forms.Button saveLogBtn;
        private System.Windows.Forms.Button clearLogsBtn;
        private System.Windows.Forms.Button deleteLogBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.CheckBox brakeCheckbox;
        private System.Windows.Forms.TextBox armorAmountInput;
        private System.Windows.Forms.TextBox brakeAmountInput;
    }
}

