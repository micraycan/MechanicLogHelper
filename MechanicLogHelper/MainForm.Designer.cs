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
            this.brakeCheckbox = new System.Windows.Forms.CheckBox();
            this.armorCheckbox = new System.Windows.Forms.CheckBox();
            this.saveLogBtn = new System.Windows.Forms.Button();
            this.clearLogsBtn = new System.Windows.Forms.Button();
            this.updateCurrentBtn = new System.Windows.Forms.Button();
            this.deleteLogBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.brakeAmountInput = new System.Windows.Forms.TextBox();
            this.armorAmountInput = new System.Windows.Forms.TextBox();
            this.customerGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewLogs
            // 
            this.treeViewLogs.Location = new System.Drawing.Point(12, 43);
            this.treeViewLogs.Name = "treeViewLogs";
            this.treeViewLogs.Size = new System.Drawing.Size(268, 535);
            this.treeViewLogs.TabIndex = 0;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(17, 25);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(85, 13);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer Name:";
            // 
            // customerNameInput
            // 
            this.customerNameInput.Location = new System.Drawing.Point(143, 22);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(160, 20);
            this.customerNameInput.TabIndex = 2;
            // 
            // vehicleInput
            // 
            this.vehicleInput.Location = new System.Drawing.Point(143, 48);
            this.vehicleInput.Name = "vehicleInput";
            this.vehicleInput.Size = new System.Drawing.Size(160, 20);
            this.vehicleInput.TabIndex = 2;
            // 
            // licenseInput
            // 
            this.licenseInput.Location = new System.Drawing.Point(143, 74);
            this.licenseInput.Name = "licenseInput";
            this.licenseInput.Size = new System.Drawing.Size(160, 20);
            this.licenseInput.TabIndex = 2;
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Location = new System.Drawing.Point(17, 51);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(120, 13);
            this.vehicleLabel.TabIndex = 1;
            this.vehicleLabel.Text = "Vehicle | [Make/Model]:";
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Location = new System.Drawing.Point(17, 77);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(74, 13);
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
            this.customerGroup.Location = new System.Drawing.Point(286, 43);
            this.customerGroup.Name = "customerGroup";
            this.customerGroup.Size = new System.Drawing.Size(324, 134);
            this.customerGroup.TabIndex = 3;
            this.customerGroup.TabStop = false;
            this.customerGroup.Text = "Customer Info";
            // 
            // employeeCheckbox
            // 
            this.employeeCheckbox.AutoSize = true;
            this.employeeCheckbox.Location = new System.Drawing.Point(143, 101);
            this.employeeCheckbox.Name = "employeeCheckbox";
            this.employeeCheckbox.Size = new System.Drawing.Size(105, 17);
            this.employeeCheckbox.TabIndex = 3;
            this.employeeCheckbox.Text = "Hayes Employee";
            this.employeeCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.armorAmountInput);
            this.groupBox1.Controls.Add(this.brakeAmountInput);
            this.groupBox1.Controls.Add(this.brakeCheckbox);
            this.groupBox1.Controls.Add(this.armorCheckbox);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(287, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 344);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installed Upgrades";
            // 
            // brakeCheckbox
            // 
            this.brakeCheckbox.AutoSize = true;
            this.brakeCheckbox.Location = new System.Drawing.Point(19, 60);
            this.brakeCheckbox.Name = "brakeCheckbox";
            this.brakeCheckbox.Size = new System.Drawing.Size(59, 17);
            this.brakeCheckbox.TabIndex = 0;
            this.brakeCheckbox.Text = "Brakes";
            this.brakeCheckbox.UseVisualStyleBackColor = true;
            // 
            // armorCheckbox
            // 
            this.armorCheckbox.AutoSize = true;
            this.armorCheckbox.Location = new System.Drawing.Point(19, 34);
            this.armorCheckbox.Name = "armorCheckbox";
            this.armorCheckbox.Size = new System.Drawing.Size(53, 17);
            this.armorCheckbox.TabIndex = 0;
            this.armorCheckbox.Text = "Armor";
            this.armorCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveLogBtn
            // 
            this.saveLogBtn.Location = new System.Drawing.Point(286, 555);
            this.saveLogBtn.Name = "saveLogBtn";
            this.saveLogBtn.Size = new System.Drawing.Size(136, 23);
            this.saveLogBtn.TabIndex = 5;
            this.saveLogBtn.Text = "Save Log";
            this.saveLogBtn.UseVisualStyleBackColor = true;
            // 
            // clearLogsBtn
            // 
            this.clearLogsBtn.Location = new System.Drawing.Point(429, 555);
            this.clearLogsBtn.Name = "clearLogsBtn";
            this.clearLogsBtn.Size = new System.Drawing.Size(136, 23);
            this.clearLogsBtn.TabIndex = 5;
            this.clearLogsBtn.Text = "Clear All Logs";
            this.clearLogsBtn.UseVisualStyleBackColor = true;
            // 
            // updateCurrentBtn
            // 
            this.updateCurrentBtn.Location = new System.Drawing.Point(571, 555);
            this.updateCurrentBtn.Name = "updateCurrentBtn";
            this.updateCurrentBtn.Size = new System.Drawing.Size(136, 23);
            this.updateCurrentBtn.TabIndex = 5;
            this.updateCurrentBtn.Text = "Update Current Log";
            this.updateCurrentBtn.UseVisualStyleBackColor = true;
            // 
            // deleteLogBtn
            // 
            this.deleteLogBtn.Location = new System.Drawing.Point(713, 555);
            this.deleteLogBtn.Name = "deleteLogBtn";
            this.deleteLogBtn.Size = new System.Drawing.Size(136, 23);
            this.deleteLogBtn.TabIndex = 5;
            this.deleteLogBtn.Text = "Delete Log";
            this.deleteLogBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(855, 555);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(136, 23);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // brakeAmountInput
            // 
            this.brakeAmountInput.Location = new System.Drawing.Point(142, 60);
            this.brakeAmountInput.Name = "brakeAmountInput";
            this.brakeAmountInput.Size = new System.Drawing.Size(160, 20);
            this.brakeAmountInput.TabIndex = 5;
            // 
            // armorAmountInput
            // 
            this.armorAmountInput.Location = new System.Drawing.Point(142, 32);
            this.armorAmountInput.Name = "armorAmountInput";
            this.armorAmountInput.Size = new System.Drawing.Size(160, 20);
            this.armorAmountInput.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 590);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteLogBtn);
            this.Controls.Add(this.updateCurrentBtn);
            this.Controls.Add(this.clearLogsBtn);
            this.Controls.Add(this.saveLogBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerGroup);
            this.Controls.Add(this.treeViewLogs);
            this.Name = "MainForm";
            this.Text = " Hayes Mechanic Helper v1.0";
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
        private System.Windows.Forms.Button updateCurrentBtn;
        private System.Windows.Forms.Button deleteLogBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.CheckBox brakeCheckbox;
        private System.Windows.Forms.TextBox armorAmountInput;
        private System.Windows.Forms.TextBox brakeAmountInput;
    }
}

