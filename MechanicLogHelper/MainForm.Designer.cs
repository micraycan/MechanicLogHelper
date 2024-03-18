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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeViewLogs = new System.Windows.Forms.TreeView();
            this.customerInput = new MaterialSkin.Controls.MaterialTextBox();
            this.vehicleInput = new MaterialSkin.Controls.MaterialTextBox();
            this.plateInput = new MaterialSkin.Controls.MaterialTextBox();
            this.employeeCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.logdisplayTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.armorDropwdown = new MaterialSkin.Controls.MaterialComboBox();
            this.brakesDropdown = new MaterialSkin.Controls.MaterialComboBox();
            this.engineDropdown = new MaterialSkin.Controls.MaterialComboBox();
            this.suspensionDropdown = new MaterialSkin.Controls.MaterialComboBox();
            this.transmissionDropdown = new MaterialSkin.Controls.MaterialComboBox();
            this.turboCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.archCoverCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.aerialCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.customTiresCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.dResprayCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.dialCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.engineBlockCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.exhaustCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.fBumperCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.grilleCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.newLogButton = new MaterialSkin.Controls.MaterialButton();
            this.hoodCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.interiorResprayCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.hornCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.leftFenderCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.liveryCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.ornamentsCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.oldLiveryCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.plateCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.rBumperCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.pearlResprayCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.pResprayCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.sResprayCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.rimColorCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.rimsCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.roofCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.rollcageCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.seatsCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.skirtsCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.spoilerCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.steeringWheelCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.strutCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.speakerCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.tintCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.tireSmokeCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.trimAChekbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.trimBCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.trunkCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.installTab = new System.Windows.Forms.TabPage();
            this.removeTab = new System.Windows.Forms.TabPage();
            this.removeNeonCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.clearLogButton = new MaterialSkin.Controls.MaterialButton();
            this.repairInput = new MaterialSkin.Controls.MaterialTextBox();
            this.unbilledTextbox = new MaterialSkin.Controls.MaterialTextBox();
            this.saveLogButton = new MaterialSkin.Controls.MaterialButton();
            this.deleteLogButton = new MaterialSkin.Controls.MaterialButton();
            this.updateBillButton = new MaterialSkin.Controls.MaterialButton();
            this.getCommissionLogButton = new MaterialSkin.Controls.MaterialButton();
            this.comDateInput = new MaterialSkin.Controls.MaterialTextBox();
            this.clockInInput = new MaterialSkin.Controls.MaterialTextBox();
            this.clockInButton = new MaterialSkin.Controls.MaterialButton();
            this.clockOutInput = new MaterialSkin.Controls.MaterialTextBox();
            this.clockOutButton = new MaterialSkin.Controls.MaterialButton();
            this.commissionLogTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.clearCommissionLogButton = new MaterialSkin.Controls.MaterialButton();
            this.tabControl.SuspendLayout();
            this.installTab.SuspendLayout();
            this.removeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewLogs
            // 
            this.treeViewLogs.Location = new System.Drawing.Point(17, 305);
            this.treeViewLogs.Name = "treeViewLogs";
            this.treeViewLogs.Size = new System.Drawing.Size(334, 283);
            this.treeViewLogs.TabIndex = 12;
            // 
            // customerInput
            // 
            this.customerInput.AnimateReadOnly = false;
            this.customerInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerInput.Depth = 0;
            this.customerInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customerInput.Hint = "Customer name";
            this.customerInput.LeadingIcon = null;
            this.customerInput.Location = new System.Drawing.Point(17, 77);
            this.customerInput.MaxLength = 50;
            this.customerInput.MouseState = MaterialSkin.MouseState.OUT;
            this.customerInput.Multiline = false;
            this.customerInput.Name = "customerInput";
            this.customerInput.Size = new System.Drawing.Size(334, 50);
            this.customerInput.TabIndex = 0;
            this.customerInput.Tag = "exclude";
            this.customerInput.Text = "";
            this.customerInput.TrailingIcon = null;
            // 
            // vehicleInput
            // 
            this.vehicleInput.AnimateReadOnly = false;
            this.vehicleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vehicleInput.Depth = 0;
            this.vehicleInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.vehicleInput.Hint = "Vehicle make/model";
            this.vehicleInput.LeadingIcon = null;
            this.vehicleInput.Location = new System.Drawing.Point(17, 133);
            this.vehicleInput.MaxLength = 50;
            this.vehicleInput.MouseState = MaterialSkin.MouseState.OUT;
            this.vehicleInput.Multiline = false;
            this.vehicleInput.Name = "vehicleInput";
            this.vehicleInput.Size = new System.Drawing.Size(334, 50);
            this.vehicleInput.TabIndex = 1;
            this.vehicleInput.Tag = "exclude";
            this.vehicleInput.Text = "";
            this.vehicleInput.TrailingIcon = null;
            // 
            // plateInput
            // 
            this.plateInput.AnimateReadOnly = false;
            this.plateInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plateInput.Depth = 0;
            this.plateInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plateInput.Hint = "License plate";
            this.plateInput.LeadingIcon = null;
            this.plateInput.Location = new System.Drawing.Point(17, 189);
            this.plateInput.MaxLength = 50;
            this.plateInput.MouseState = MaterialSkin.MouseState.OUT;
            this.plateInput.Multiline = false;
            this.plateInput.Name = "plateInput";
            this.plateInput.Size = new System.Drawing.Size(334, 50);
            this.plateInput.TabIndex = 2;
            this.plateInput.Tag = "exclude";
            this.plateInput.Text = "";
            this.plateInput.TrailingIcon = null;
            // 
            // employeeCheckbox
            // 
            this.employeeCheckbox.AutoSize = true;
            this.employeeCheckbox.Depth = 0;
            this.employeeCheckbox.Location = new System.Drawing.Point(17, 251);
            this.employeeCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.employeeCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.employeeCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.employeeCheckbox.Name = "employeeCheckbox";
            this.employeeCheckbox.ReadOnly = false;
            this.employeeCheckbox.Ripple = true;
            this.employeeCheckbox.Size = new System.Drawing.Size(139, 37);
            this.employeeCheckbox.TabIndex = 3;
            this.employeeCheckbox.Text = "Employee Sale";
            this.employeeCheckbox.UseVisualStyleBackColor = true;
            // 
            // logdisplayTextBox
            // 
            this.logdisplayTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logdisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logdisplayTextBox.Depth = 0;
            this.logdisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.logdisplayTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logdisplayTextBox.Location = new System.Drawing.Point(17, 597);
            this.logdisplayTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.logdisplayTextBox.Name = "logdisplayTextBox";
            this.logdisplayTextBox.ReadOnly = true;
            this.logdisplayTextBox.Size = new System.Drawing.Size(334, 229);
            this.logdisplayTextBox.TabIndex = 11;
            this.logdisplayTextBox.Tag = "exclude";
            this.logdisplayTextBox.Text = "";
            this.logdisplayTextBox.Click += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // armorDropwdown
            // 
            this.armorDropwdown.AutoResize = false;
            this.armorDropwdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.armorDropwdown.Depth = 0;
            this.armorDropwdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.armorDropwdown.DropDownHeight = 174;
            this.armorDropwdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.armorDropwdown.DropDownWidth = 121;
            this.armorDropwdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.armorDropwdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.armorDropwdown.FormattingEnabled = true;
            this.armorDropwdown.Hint = "Armor";
            this.armorDropwdown.IntegralHeight = false;
            this.armorDropwdown.ItemHeight = 43;
            this.armorDropwdown.Items.AddRange(new object[] {
            "",
            "Armor 2",
            "Armor 3",
            "Armor 4",
            "Armor 5",
            "Armor 6"});
            this.armorDropwdown.Location = new System.Drawing.Point(28, 16);
            this.armorDropwdown.MaxDropDownItems = 4;
            this.armorDropwdown.MouseState = MaterialSkin.MouseState.OUT;
            this.armorDropwdown.Name = "armorDropwdown";
            this.armorDropwdown.Size = new System.Drawing.Size(160, 49);
            this.armorDropwdown.StartIndex = 0;
            this.armorDropwdown.TabIndex = 0;
            // 
            // brakesDropdown
            // 
            this.brakesDropdown.AutoResize = false;
            this.brakesDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.brakesDropdown.Depth = 0;
            this.brakesDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.brakesDropdown.DropDownHeight = 174;
            this.brakesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brakesDropdown.DropDownWidth = 121;
            this.brakesDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.brakesDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brakesDropdown.FormattingEnabled = true;
            this.brakesDropdown.Hint = "Brakes";
            this.brakesDropdown.IntegralHeight = false;
            this.brakesDropdown.ItemHeight = 43;
            this.brakesDropdown.Items.AddRange(new object[] {
            "",
            "Brakes 2",
            "Brakes 3",
            "Brakes 4"});
            this.brakesDropdown.Location = new System.Drawing.Point(194, 16);
            this.brakesDropdown.MaxDropDownItems = 4;
            this.brakesDropdown.MouseState = MaterialSkin.MouseState.OUT;
            this.brakesDropdown.Name = "brakesDropdown";
            this.brakesDropdown.Size = new System.Drawing.Size(160, 49);
            this.brakesDropdown.StartIndex = 0;
            this.brakesDropdown.TabIndex = 1;
            // 
            // engineDropdown
            // 
            this.engineDropdown.AutoResize = false;
            this.engineDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.engineDropdown.Depth = 0;
            this.engineDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.engineDropdown.DropDownHeight = 174;
            this.engineDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.engineDropdown.DropDownWidth = 121;
            this.engineDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.engineDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.engineDropdown.FormattingEnabled = true;
            this.engineDropdown.Hint = "Engine";
            this.engineDropdown.IntegralHeight = false;
            this.engineDropdown.ItemHeight = 43;
            this.engineDropdown.Items.AddRange(new object[] {
            "",
            "Engine 2",
            "Engine 3",
            "Engine 4",
            "Engine 5"});
            this.engineDropdown.Location = new System.Drawing.Point(360, 16);
            this.engineDropdown.MaxDropDownItems = 4;
            this.engineDropdown.MouseState = MaterialSkin.MouseState.OUT;
            this.engineDropdown.Name = "engineDropdown";
            this.engineDropdown.Size = new System.Drawing.Size(160, 49);
            this.engineDropdown.StartIndex = 0;
            this.engineDropdown.TabIndex = 2;
            // 
            // suspensionDropdown
            // 
            this.suspensionDropdown.AutoResize = false;
            this.suspensionDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.suspensionDropdown.Depth = 0;
            this.suspensionDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.suspensionDropdown.DropDownHeight = 174;
            this.suspensionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suspensionDropdown.DropDownWidth = 121;
            this.suspensionDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.suspensionDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.suspensionDropdown.FormattingEnabled = true;
            this.suspensionDropdown.Hint = "Suspension";
            this.suspensionDropdown.IntegralHeight = false;
            this.suspensionDropdown.ItemHeight = 43;
            this.suspensionDropdown.Items.AddRange(new object[] {
            "",
            "Suspension 2",
            "Suspension 3",
            "Suspension 4"});
            this.suspensionDropdown.Location = new System.Drawing.Point(526, 16);
            this.suspensionDropdown.MaxDropDownItems = 4;
            this.suspensionDropdown.MouseState = MaterialSkin.MouseState.OUT;
            this.suspensionDropdown.Name = "suspensionDropdown";
            this.suspensionDropdown.Size = new System.Drawing.Size(160, 49);
            this.suspensionDropdown.StartIndex = 0;
            this.suspensionDropdown.TabIndex = 3;
            // 
            // transmissionDropdown
            // 
            this.transmissionDropdown.AutoResize = false;
            this.transmissionDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.transmissionDropdown.Depth = 0;
            this.transmissionDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.transmissionDropdown.DropDownHeight = 174;
            this.transmissionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transmissionDropdown.DropDownWidth = 121;
            this.transmissionDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.transmissionDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transmissionDropdown.FormattingEnabled = true;
            this.transmissionDropdown.Hint = "Transmission";
            this.transmissionDropdown.IntegralHeight = false;
            this.transmissionDropdown.ItemHeight = 43;
            this.transmissionDropdown.Items.AddRange(new object[] {
            "",
            "Transmission 2",
            "Transmission 3",
            "Transmission 4"});
            this.transmissionDropdown.Location = new System.Drawing.Point(692, 16);
            this.transmissionDropdown.MaxDropDownItems = 4;
            this.transmissionDropdown.MouseState = MaterialSkin.MouseState.OUT;
            this.transmissionDropdown.Name = "transmissionDropdown";
            this.transmissionDropdown.Size = new System.Drawing.Size(160, 49);
            this.transmissionDropdown.StartIndex = 0;
            this.transmissionDropdown.TabIndex = 4;
            // 
            // turboCheckbox
            // 
            this.turboCheckbox.AutoSize = true;
            this.turboCheckbox.Depth = 0;
            this.turboCheckbox.Location = new System.Drawing.Point(860, 22);
            this.turboCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.turboCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.turboCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.turboCheckbox.Name = "turboCheckbox";
            this.turboCheckbox.ReadOnly = false;
            this.turboCheckbox.Ripple = true;
            this.turboCheckbox.Size = new System.Drawing.Size(77, 37);
            this.turboCheckbox.TabIndex = 5;
            this.turboCheckbox.Text = "Turbo";
            this.turboCheckbox.UseVisualStyleBackColor = true;
            // 
            // archCoverCheckbox
            // 
            this.archCoverCheckbox.AutoSize = true;
            this.archCoverCheckbox.Depth = 0;
            this.archCoverCheckbox.Location = new System.Drawing.Point(28, 78);
            this.archCoverCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.archCoverCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.archCoverCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.archCoverCheckbox.Name = "archCoverCheckbox";
            this.archCoverCheckbox.ReadOnly = false;
            this.archCoverCheckbox.Ripple = true;
            this.archCoverCheckbox.Size = new System.Drawing.Size(111, 37);
            this.archCoverCheckbox.TabIndex = 6;
            this.archCoverCheckbox.Text = "Arch Cover";
            this.archCoverCheckbox.UseVisualStyleBackColor = true;
            // 
            // aerialCheckbox
            // 
            this.aerialCheckbox.AutoSize = true;
            this.aerialCheckbox.Depth = 0;
            this.aerialCheckbox.Location = new System.Drawing.Point(28, 115);
            this.aerialCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.aerialCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.aerialCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.aerialCheckbox.Name = "aerialCheckbox";
            this.aerialCheckbox.ReadOnly = false;
            this.aerialCheckbox.Ripple = true;
            this.aerialCheckbox.Size = new System.Drawing.Size(75, 37);
            this.aerialCheckbox.TabIndex = 7;
            this.aerialCheckbox.Text = "Aerial";
            this.aerialCheckbox.UseVisualStyleBackColor = true;
            // 
            // customTiresCheckbox
            // 
            this.customTiresCheckbox.AutoSize = true;
            this.customTiresCheckbox.Depth = 0;
            this.customTiresCheckbox.Location = new System.Drawing.Point(28, 152);
            this.customTiresCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.customTiresCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.customTiresCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.customTiresCheckbox.Name = "customTiresCheckbox";
            this.customTiresCheckbox.ReadOnly = false;
            this.customTiresCheckbox.Ripple = true;
            this.customTiresCheckbox.Size = new System.Drawing.Size(129, 37);
            this.customTiresCheckbox.TabIndex = 8;
            this.customTiresCheckbox.Text = "Custom Tires";
            this.customTiresCheckbox.UseVisualStyleBackColor = true;
            // 
            // dResprayCheckbox
            // 
            this.dResprayCheckbox.AutoSize = true;
            this.dResprayCheckbox.Depth = 0;
            this.dResprayCheckbox.Location = new System.Drawing.Point(326, 226);
            this.dResprayCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.dResprayCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dResprayCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.dResprayCheckbox.Name = "dResprayCheckbox";
            this.dResprayCheckbox.ReadOnly = false;
            this.dResprayCheckbox.Ripple = true;
            this.dResprayCheckbox.Size = new System.Drawing.Size(174, 37);
            this.dResprayCheckbox.TabIndex = 22;
            this.dResprayCheckbox.Text = "Respray Dashboard";
            this.dResprayCheckbox.UseVisualStyleBackColor = true;
            // 
            // dialCheckbox
            // 
            this.dialCheckbox.AutoSize = true;
            this.dialCheckbox.Depth = 0;
            this.dialCheckbox.Location = new System.Drawing.Point(28, 189);
            this.dialCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.dialCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dialCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.dialCheckbox.Name = "dialCheckbox";
            this.dialCheckbox.ReadOnly = false;
            this.dialCheckbox.Ripple = true;
            this.dialCheckbox.Size = new System.Drawing.Size(63, 37);
            this.dialCheckbox.TabIndex = 9;
            this.dialCheckbox.Text = "Dial";
            this.dialCheckbox.UseVisualStyleBackColor = true;
            // 
            // engineBlockCheckbox
            // 
            this.engineBlockCheckbox.AutoSize = true;
            this.engineBlockCheckbox.Depth = 0;
            this.engineBlockCheckbox.Location = new System.Drawing.Point(28, 226);
            this.engineBlockCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.engineBlockCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.engineBlockCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.engineBlockCheckbox.Name = "engineBlockCheckbox";
            this.engineBlockCheckbox.ReadOnly = false;
            this.engineBlockCheckbox.Ripple = true;
            this.engineBlockCheckbox.Size = new System.Drawing.Size(126, 37);
            this.engineBlockCheckbox.TabIndex = 10;
            this.engineBlockCheckbox.Text = "Engine Block";
            this.engineBlockCheckbox.UseVisualStyleBackColor = true;
            // 
            // exhaustCheckbox
            // 
            this.exhaustCheckbox.AutoSize = true;
            this.exhaustCheckbox.Depth = 0;
            this.exhaustCheckbox.Location = new System.Drawing.Point(28, 263);
            this.exhaustCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.exhaustCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.exhaustCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.exhaustCheckbox.Name = "exhaustCheckbox";
            this.exhaustCheckbox.ReadOnly = false;
            this.exhaustCheckbox.Ripple = true;
            this.exhaustCheckbox.Size = new System.Drawing.Size(92, 37);
            this.exhaustCheckbox.TabIndex = 11;
            this.exhaustCheckbox.Text = "Exhaust";
            this.exhaustCheckbox.UseVisualStyleBackColor = true;
            // 
            // fBumperCheckbox
            // 
            this.fBumperCheckbox.AutoSize = true;
            this.fBumperCheckbox.Depth = 0;
            this.fBumperCheckbox.Location = new System.Drawing.Point(28, 300);
            this.fBumperCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.fBumperCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fBumperCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fBumperCheckbox.Name = "fBumperCheckbox";
            this.fBumperCheckbox.ReadOnly = false;
            this.fBumperCheckbox.Ripple = true;
            this.fBumperCheckbox.Size = new System.Drawing.Size(131, 37);
            this.fBumperCheckbox.TabIndex = 12;
            this.fBumperCheckbox.Text = "Front Bumper";
            this.fBumperCheckbox.UseVisualStyleBackColor = true;
            // 
            // grilleCheckbox
            // 
            this.grilleCheckbox.AutoSize = true;
            this.grilleCheckbox.Depth = 0;
            this.grilleCheckbox.Location = new System.Drawing.Point(28, 337);
            this.grilleCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.grilleCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.grilleCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.grilleCheckbox.Name = "grilleCheckbox";
            this.grilleCheckbox.ReadOnly = false;
            this.grilleCheckbox.Ripple = true;
            this.grilleCheckbox.Size = new System.Drawing.Size(71, 37);
            this.grilleCheckbox.TabIndex = 13;
            this.grilleCheckbox.Text = "Grille";
            this.grilleCheckbox.UseVisualStyleBackColor = true;
            // 
            // newLogButton
            // 
            this.newLogButton.AutoSize = false;
            this.newLogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newLogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.newLogButton.Depth = 0;
            this.newLogButton.HighEmphasis = true;
            this.newLogButton.Icon = null;
            this.newLogButton.Location = new System.Drawing.Point(803, 790);
            this.newLogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newLogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.newLogButton.Name = "newLogButton";
            this.newLogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.newLogButton.Size = new System.Drawing.Size(160, 36);
            this.newLogButton.TabIndex = 8;
            this.newLogButton.Text = "New Log";
            this.newLogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.newLogButton.UseAccentColor = false;
            this.newLogButton.UseVisualStyleBackColor = true;
            // 
            // hoodCheckbox
            // 
            this.hoodCheckbox.AutoSize = true;
            this.hoodCheckbox.Depth = 0;
            this.hoodCheckbox.Location = new System.Drawing.Point(28, 374);
            this.hoodCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.hoodCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.hoodCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.hoodCheckbox.Name = "hoodCheckbox";
            this.hoodCheckbox.ReadOnly = false;
            this.hoodCheckbox.Ripple = true;
            this.hoodCheckbox.Size = new System.Drawing.Size(73, 37);
            this.hoodCheckbox.TabIndex = 14;
            this.hoodCheckbox.Text = "Hood";
            this.hoodCheckbox.UseVisualStyleBackColor = true;
            // 
            // interiorResprayCheckbox
            // 
            this.interiorResprayCheckbox.AutoSize = true;
            this.interiorResprayCheckbox.Depth = 0;
            this.interiorResprayCheckbox.Location = new System.Drawing.Point(326, 263);
            this.interiorResprayCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.interiorResprayCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.interiorResprayCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.interiorResprayCheckbox.Name = "interiorResprayCheckbox";
            this.interiorResprayCheckbox.ReadOnly = false;
            this.interiorResprayCheckbox.Ripple = true;
            this.interiorResprayCheckbox.Size = new System.Drawing.Size(145, 37);
            this.interiorResprayCheckbox.TabIndex = 23;
            this.interiorResprayCheckbox.Text = "Respray Interior";
            this.interiorResprayCheckbox.UseVisualStyleBackColor = true;
            // 
            // hornCheckbox
            // 
            this.hornCheckbox.AutoSize = true;
            this.hornCheckbox.Depth = 0;
            this.hornCheckbox.Location = new System.Drawing.Point(28, 411);
            this.hornCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.hornCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.hornCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.hornCheckbox.Name = "hornCheckbox";
            this.hornCheckbox.ReadOnly = false;
            this.hornCheckbox.Ripple = true;
            this.hornCheckbox.Size = new System.Drawing.Size(69, 37);
            this.hornCheckbox.TabIndex = 15;
            this.hornCheckbox.Text = "Horn";
            this.hornCheckbox.UseVisualStyleBackColor = true;
            // 
            // leftFenderCheckbox
            // 
            this.leftFenderCheckbox.AutoSize = true;
            this.leftFenderCheckbox.Depth = 0;
            this.leftFenderCheckbox.Location = new System.Drawing.Point(28, 448);
            this.leftFenderCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.leftFenderCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.leftFenderCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.leftFenderCheckbox.Name = "leftFenderCheckbox";
            this.leftFenderCheckbox.ReadOnly = false;
            this.leftFenderCheckbox.Ripple = true;
            this.leftFenderCheckbox.Size = new System.Drawing.Size(115, 37);
            this.leftFenderCheckbox.TabIndex = 16;
            this.leftFenderCheckbox.Text = "Left Fender";
            this.leftFenderCheckbox.UseVisualStyleBackColor = true;
            // 
            // liveryCheckbox
            // 
            this.liveryCheckbox.AutoSize = true;
            this.liveryCheckbox.Depth = 0;
            this.liveryCheckbox.Location = new System.Drawing.Point(28, 485);
            this.liveryCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.liveryCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.liveryCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.liveryCheckbox.Name = "liveryCheckbox";
            this.liveryCheckbox.ReadOnly = false;
            this.liveryCheckbox.Ripple = true;
            this.liveryCheckbox.Size = new System.Drawing.Size(77, 37);
            this.liveryCheckbox.TabIndex = 17;
            this.liveryCheckbox.Text = "Livery";
            this.liveryCheckbox.UseVisualStyleBackColor = true;
            // 
            // ornamentsCheckbox
            // 
            this.ornamentsCheckbox.AutoSize = true;
            this.ornamentsCheckbox.Depth = 0;
            this.ornamentsCheckbox.Location = new System.Drawing.Point(326, 78);
            this.ornamentsCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.ornamentsCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ornamentsCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ornamentsCheckbox.Name = "ornamentsCheckbox";
            this.ornamentsCheckbox.ReadOnly = false;
            this.ornamentsCheckbox.Ripple = true;
            this.ornamentsCheckbox.Size = new System.Drawing.Size(113, 37);
            this.ornamentsCheckbox.TabIndex = 18;
            this.ornamentsCheckbox.Text = "Ornaments";
            this.ornamentsCheckbox.UseVisualStyleBackColor = true;
            // 
            // oldLiveryCheckbox
            // 
            this.oldLiveryCheckbox.AutoSize = true;
            this.oldLiveryCheckbox.Depth = 0;
            this.oldLiveryCheckbox.Location = new System.Drawing.Point(326, 115);
            this.oldLiveryCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.oldLiveryCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.oldLiveryCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.oldLiveryCheckbox.Name = "oldLiveryCheckbox";
            this.oldLiveryCheckbox.ReadOnly = false;
            this.oldLiveryCheckbox.Ripple = true;
            this.oldLiveryCheckbox.Size = new System.Drawing.Size(105, 37);
            this.oldLiveryCheckbox.TabIndex = 19;
            this.oldLiveryCheckbox.Text = "Old Livery";
            this.oldLiveryCheckbox.UseVisualStyleBackColor = true;
            // 
            // plateCheckbox
            // 
            this.plateCheckbox.AutoSize = true;
            this.plateCheckbox.Depth = 0;
            this.plateCheckbox.Location = new System.Drawing.Point(326, 152);
            this.plateCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.plateCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.plateCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.plateCheckbox.Name = "plateCheckbox";
            this.plateCheckbox.ReadOnly = false;
            this.plateCheckbox.Ripple = true;
            this.plateCheckbox.Size = new System.Drawing.Size(113, 37);
            this.plateCheckbox.TabIndex = 20;
            this.plateCheckbox.Text = "Plate Index";
            this.plateCheckbox.UseVisualStyleBackColor = true;
            // 
            // rBumperCheckbox
            // 
            this.rBumperCheckbox.AutoSize = true;
            this.rBumperCheckbox.Depth = 0;
            this.rBumperCheckbox.Location = new System.Drawing.Point(326, 189);
            this.rBumperCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.rBumperCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rBumperCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.rBumperCheckbox.Name = "rBumperCheckbox";
            this.rBumperCheckbox.ReadOnly = false;
            this.rBumperCheckbox.Ripple = true;
            this.rBumperCheckbox.Size = new System.Drawing.Size(126, 37);
            this.rBumperCheckbox.TabIndex = 21;
            this.rBumperCheckbox.Text = "Rear Bumper";
            this.rBumperCheckbox.UseVisualStyleBackColor = true;
            // 
            // pearlResprayCheckbox
            // 
            this.pearlResprayCheckbox.AutoSize = true;
            this.pearlResprayCheckbox.Depth = 0;
            this.pearlResprayCheckbox.Location = new System.Drawing.Point(326, 300);
            this.pearlResprayCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.pearlResprayCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pearlResprayCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.pearlResprayCheckbox.Name = "pearlResprayCheckbox";
            this.pearlResprayCheckbox.ReadOnly = false;
            this.pearlResprayCheckbox.Ripple = true;
            this.pearlResprayCheckbox.Size = new System.Drawing.Size(178, 37);
            this.pearlResprayCheckbox.TabIndex = 24;
            this.pearlResprayCheckbox.Text = "Respray Pearlescent";
            this.pearlResprayCheckbox.UseVisualStyleBackColor = true;
            // 
            // pResprayCheckbox
            // 
            this.pResprayCheckbox.AutoSize = true;
            this.pResprayCheckbox.Depth = 0;
            this.pResprayCheckbox.Location = new System.Drawing.Point(326, 337);
            this.pResprayCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.pResprayCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pResprayCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.pResprayCheckbox.Name = "pResprayCheckbox";
            this.pResprayCheckbox.ReadOnly = false;
            this.pResprayCheckbox.Ripple = true;
            this.pResprayCheckbox.Size = new System.Drawing.Size(151, 37);
            this.pResprayCheckbox.TabIndex = 25;
            this.pResprayCheckbox.Text = "Respray Primary";
            this.pResprayCheckbox.UseVisualStyleBackColor = true;
            // 
            // sResprayCheckbox
            // 
            this.sResprayCheckbox.AutoSize = true;
            this.sResprayCheckbox.Depth = 0;
            this.sResprayCheckbox.Location = new System.Drawing.Point(326, 374);
            this.sResprayCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.sResprayCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sResprayCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.sResprayCheckbox.Name = "sResprayCheckbox";
            this.sResprayCheckbox.ReadOnly = false;
            this.sResprayCheckbox.Ripple = true;
            this.sResprayCheckbox.Size = new System.Drawing.Size(171, 37);
            this.sResprayCheckbox.TabIndex = 26;
            this.sResprayCheckbox.Text = "Respray Secondary";
            this.sResprayCheckbox.UseVisualStyleBackColor = true;
            // 
            // rimColorCheckbox
            // 
            this.rimColorCheckbox.AutoSize = true;
            this.rimColorCheckbox.Depth = 0;
            this.rimColorCheckbox.Location = new System.Drawing.Point(326, 411);
            this.rimColorCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.rimColorCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rimColorCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.rimColorCheckbox.Name = "rimColorCheckbox";
            this.rimColorCheckbox.ReadOnly = false;
            this.rimColorCheckbox.Ripple = true;
            this.rimColorCheckbox.Size = new System.Drawing.Size(104, 37);
            this.rimColorCheckbox.TabIndex = 27;
            this.rimColorCheckbox.Text = "Rim Color";
            this.rimColorCheckbox.UseVisualStyleBackColor = true;
            // 
            // rimsCheckbox
            // 
            this.rimsCheckbox.AutoSize = true;
            this.rimsCheckbox.Depth = 0;
            this.rimsCheckbox.Location = new System.Drawing.Point(326, 448);
            this.rimsCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.rimsCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rimsCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.rimsCheckbox.Name = "rimsCheckbox";
            this.rimsCheckbox.ReadOnly = false;
            this.rimsCheckbox.Ripple = true;
            this.rimsCheckbox.Size = new System.Drawing.Size(71, 37);
            this.rimsCheckbox.TabIndex = 28;
            this.rimsCheckbox.Text = "Rims";
            this.rimsCheckbox.UseVisualStyleBackColor = true;
            // 
            // roofCheckbox
            // 
            this.roofCheckbox.AutoSize = true;
            this.roofCheckbox.Depth = 0;
            this.roofCheckbox.Location = new System.Drawing.Point(624, 78);
            this.roofCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.roofCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.roofCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.roofCheckbox.Name = "roofCheckbox";
            this.roofCheckbox.ReadOnly = false;
            this.roofCheckbox.Ripple = true;
            this.roofCheckbox.Size = new System.Drawing.Size(69, 37);
            this.roofCheckbox.TabIndex = 30;
            this.roofCheckbox.Text = "Roof";
            this.roofCheckbox.UseVisualStyleBackColor = true;
            // 
            // rollcageCheckbox
            // 
            this.rollcageCheckbox.AutoSize = true;
            this.rollcageCheckbox.Depth = 0;
            this.rollcageCheckbox.Location = new System.Drawing.Point(326, 485);
            this.rollcageCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.rollcageCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rollcageCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.rollcageCheckbox.Name = "rollcageCheckbox";
            this.rollcageCheckbox.ReadOnly = false;
            this.rollcageCheckbox.Ripple = true;
            this.rollcageCheckbox.Size = new System.Drawing.Size(102, 37);
            this.rollcageCheckbox.TabIndex = 29;
            this.rollcageCheckbox.Text = "Roll Cage";
            this.rollcageCheckbox.UseVisualStyleBackColor = true;
            // 
            // seatsCheckbox
            // 
            this.seatsCheckbox.AutoSize = true;
            this.seatsCheckbox.Depth = 0;
            this.seatsCheckbox.Location = new System.Drawing.Point(624, 115);
            this.seatsCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.seatsCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.seatsCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.seatsCheckbox.Name = "seatsCheckbox";
            this.seatsCheckbox.ReadOnly = false;
            this.seatsCheckbox.Ripple = true;
            this.seatsCheckbox.Size = new System.Drawing.Size(75, 37);
            this.seatsCheckbox.TabIndex = 31;
            this.seatsCheckbox.Text = "Seats";
            this.seatsCheckbox.UseVisualStyleBackColor = true;
            // 
            // skirtsCheckbox
            // 
            this.skirtsCheckbox.AutoSize = true;
            this.skirtsCheckbox.Depth = 0;
            this.skirtsCheckbox.Location = new System.Drawing.Point(624, 152);
            this.skirtsCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.skirtsCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.skirtsCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.skirtsCheckbox.Name = "skirtsCheckbox";
            this.skirtsCheckbox.ReadOnly = false;
            this.skirtsCheckbox.Ripple = true;
            this.skirtsCheckbox.Size = new System.Drawing.Size(102, 37);
            this.skirtsCheckbox.TabIndex = 32;
            this.skirtsCheckbox.Text = "Side Skirt";
            this.skirtsCheckbox.UseVisualStyleBackColor = true;
            // 
            // spoilerCheckbox
            // 
            this.spoilerCheckbox.AutoSize = true;
            this.spoilerCheckbox.Depth = 0;
            this.spoilerCheckbox.Location = new System.Drawing.Point(624, 189);
            this.spoilerCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.spoilerCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.spoilerCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.spoilerCheckbox.Name = "spoilerCheckbox";
            this.spoilerCheckbox.ReadOnly = false;
            this.spoilerCheckbox.Ripple = true;
            this.spoilerCheckbox.Size = new System.Drawing.Size(84, 37);
            this.spoilerCheckbox.TabIndex = 33;
            this.spoilerCheckbox.Text = "Spoiler";
            this.spoilerCheckbox.UseVisualStyleBackColor = true;
            // 
            // steeringWheelCheckbox
            // 
            this.steeringWheelCheckbox.AutoSize = true;
            this.steeringWheelCheckbox.Depth = 0;
            this.steeringWheelCheckbox.Location = new System.Drawing.Point(624, 226);
            this.steeringWheelCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.steeringWheelCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.steeringWheelCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.steeringWheelCheckbox.Name = "steeringWheelCheckbox";
            this.steeringWheelCheckbox.ReadOnly = false;
            this.steeringWheelCheckbox.Ripple = true;
            this.steeringWheelCheckbox.Size = new System.Drawing.Size(140, 37);
            this.steeringWheelCheckbox.TabIndex = 34;
            this.steeringWheelCheckbox.Text = "Steering Wheel";
            this.steeringWheelCheckbox.UseVisualStyleBackColor = true;
            // 
            // strutCheckbox
            // 
            this.strutCheckbox.AutoSize = true;
            this.strutCheckbox.Depth = 0;
            this.strutCheckbox.Location = new System.Drawing.Point(624, 263);
            this.strutCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.strutCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.strutCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.strutCheckbox.Name = "strutCheckbox";
            this.strutCheckbox.ReadOnly = false;
            this.strutCheckbox.Ripple = true;
            this.strutCheckbox.Size = new System.Drawing.Size(69, 37);
            this.strutCheckbox.TabIndex = 35;
            this.strutCheckbox.Text = "Strut";
            this.strutCheckbox.UseVisualStyleBackColor = true;
            // 
            // speakerCheckbox
            // 
            this.speakerCheckbox.AutoSize = true;
            this.speakerCheckbox.Depth = 0;
            this.speakerCheckbox.Location = new System.Drawing.Point(624, 300);
            this.speakerCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.speakerCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.speakerCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.speakerCheckbox.Name = "speakerCheckbox";
            this.speakerCheckbox.ReadOnly = false;
            this.speakerCheckbox.Ripple = true;
            this.speakerCheckbox.Size = new System.Drawing.Size(92, 37);
            this.speakerCheckbox.TabIndex = 36;
            this.speakerCheckbox.Text = "Speaker";
            this.speakerCheckbox.UseVisualStyleBackColor = true;
            // 
            // tintCheckbox
            // 
            this.tintCheckbox.AutoSize = true;
            this.tintCheckbox.Depth = 0;
            this.tintCheckbox.Location = new System.Drawing.Point(624, 337);
            this.tintCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.tintCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.tintCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.tintCheckbox.Name = "tintCheckbox";
            this.tintCheckbox.ReadOnly = false;
            this.tintCheckbox.Ripple = true;
            this.tintCheckbox.Size = new System.Drawing.Size(63, 37);
            this.tintCheckbox.TabIndex = 37;
            this.tintCheckbox.Text = "Tint";
            this.tintCheckbox.UseVisualStyleBackColor = true;
            // 
            // tireSmokeCheckbox
            // 
            this.tireSmokeCheckbox.AutoSize = true;
            this.tireSmokeCheckbox.Depth = 0;
            this.tireSmokeCheckbox.Location = new System.Drawing.Point(624, 374);
            this.tireSmokeCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.tireSmokeCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.tireSmokeCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.tireSmokeCheckbox.Name = "tireSmokeCheckbox";
            this.tireSmokeCheckbox.ReadOnly = false;
            this.tireSmokeCheckbox.Ripple = true;
            this.tireSmokeCheckbox.Size = new System.Drawing.Size(115, 37);
            this.tireSmokeCheckbox.TabIndex = 38;
            this.tireSmokeCheckbox.Text = "Tire Smoke";
            this.tireSmokeCheckbox.UseVisualStyleBackColor = true;
            // 
            // trimAChekbox
            // 
            this.trimAChekbox.AutoSize = true;
            this.trimAChekbox.Depth = 0;
            this.trimAChekbox.Location = new System.Drawing.Point(624, 411);
            this.trimAChekbox.Margin = new System.Windows.Forms.Padding(0);
            this.trimAChekbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.trimAChekbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.trimAChekbox.Name = "trimAChekbox";
            this.trimAChekbox.ReadOnly = false;
            this.trimAChekbox.Ripple = true;
            this.trimAChekbox.Size = new System.Drawing.Size(82, 37);
            this.trimAChekbox.TabIndex = 39;
            this.trimAChekbox.Text = "Trim A";
            this.trimAChekbox.UseVisualStyleBackColor = true;
            // 
            // trimBCheckbox
            // 
            this.trimBCheckbox.AutoSize = true;
            this.trimBCheckbox.Depth = 0;
            this.trimBCheckbox.Location = new System.Drawing.Point(624, 448);
            this.trimBCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.trimBCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.trimBCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.trimBCheckbox.Name = "trimBCheckbox";
            this.trimBCheckbox.ReadOnly = false;
            this.trimBCheckbox.Ripple = true;
            this.trimBCheckbox.Size = new System.Drawing.Size(82, 37);
            this.trimBCheckbox.TabIndex = 40;
            this.trimBCheckbox.Text = "Trim B";
            this.trimBCheckbox.UseVisualStyleBackColor = true;
            // 
            // trunkCheckbox
            // 
            this.trunkCheckbox.AutoSize = true;
            this.trunkCheckbox.Depth = 0;
            this.trunkCheckbox.Location = new System.Drawing.Point(624, 485);
            this.trunkCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.trunkCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.trunkCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.trunkCheckbox.Name = "trunkCheckbox";
            this.trunkCheckbox.ReadOnly = false;
            this.trunkCheckbox.Ripple = true;
            this.trunkCheckbox.Size = new System.Drawing.Size(76, 37);
            this.trunkCheckbox.TabIndex = 41;
            this.trunkCheckbox.Text = "Trunk";
            this.trunkCheckbox.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.installTab);
            this.tabControl.Controls.Add(this.removeTab);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(358, 131);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(954, 589);
            this.tabControl.TabIndex = 5;
            // 
            // installTab
            // 
            this.installTab.Controls.Add(this.archCoverCheckbox);
            this.installTab.Controls.Add(this.ornamentsCheckbox);
            this.installTab.Controls.Add(this.oldLiveryCheckbox);
            this.installTab.Controls.Add(this.plateCheckbox);
            this.installTab.Controls.Add(this.rBumperCheckbox);
            this.installTab.Controls.Add(this.hornCheckbox);
            this.installTab.Controls.Add(this.aerialCheckbox);
            this.installTab.Controls.Add(this.liveryCheckbox);
            this.installTab.Controls.Add(this.customTiresCheckbox);
            this.installTab.Controls.Add(this.leftFenderCheckbox);
            this.installTab.Controls.Add(this.dResprayCheckbox);
            this.installTab.Controls.Add(this.rollcageCheckbox);
            this.installTab.Controls.Add(this.armorDropwdown);
            this.installTab.Controls.Add(this.brakesDropdown);
            this.installTab.Controls.Add(this.dialCheckbox);
            this.installTab.Controls.Add(this.turboCheckbox);
            this.installTab.Controls.Add(this.trunkCheckbox);
            this.installTab.Controls.Add(this.engineDropdown);
            this.installTab.Controls.Add(this.engineBlockCheckbox);
            this.installTab.Controls.Add(this.transmissionDropdown);
            this.installTab.Controls.Add(this.trimBCheckbox);
            this.installTab.Controls.Add(this.suspensionDropdown);
            this.installTab.Controls.Add(this.exhaustCheckbox);
            this.installTab.Controls.Add(this.trimAChekbox);
            this.installTab.Controls.Add(this.fBumperCheckbox);
            this.installTab.Controls.Add(this.tireSmokeCheckbox);
            this.installTab.Controls.Add(this.grilleCheckbox);
            this.installTab.Controls.Add(this.tintCheckbox);
            this.installTab.Controls.Add(this.hoodCheckbox);
            this.installTab.Controls.Add(this.speakerCheckbox);
            this.installTab.Controls.Add(this.interiorResprayCheckbox);
            this.installTab.Controls.Add(this.strutCheckbox);
            this.installTab.Controls.Add(this.pearlResprayCheckbox);
            this.installTab.Controls.Add(this.steeringWheelCheckbox);
            this.installTab.Controls.Add(this.pResprayCheckbox);
            this.installTab.Controls.Add(this.spoilerCheckbox);
            this.installTab.Controls.Add(this.sResprayCheckbox);
            this.installTab.Controls.Add(this.skirtsCheckbox);
            this.installTab.Controls.Add(this.rimColorCheckbox);
            this.installTab.Controls.Add(this.seatsCheckbox);
            this.installTab.Controls.Add(this.rimsCheckbox);
            this.installTab.Controls.Add(this.roofCheckbox);
            this.installTab.Location = new System.Drawing.Point(4, 22);
            this.installTab.Name = "installTab";
            this.installTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.installTab.Size = new System.Drawing.Size(946, 563);
            this.installTab.TabIndex = 0;
            this.installTab.Text = "Install Parts";
            this.installTab.UseVisualStyleBackColor = true;
            // 
            // removeTab
            // 
            this.removeTab.Controls.Add(this.removeNeonCheckbox);
            this.removeTab.Location = new System.Drawing.Point(4, 22);
            this.removeTab.Name = "removeTab";
            this.removeTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.removeTab.Size = new System.Drawing.Size(946, 563);
            this.removeTab.TabIndex = 1;
            this.removeTab.Text = "Remove Parts";
            this.removeTab.UseVisualStyleBackColor = true;
            // 
            // removeNeonCheckbox
            // 
            this.removeNeonCheckbox.AutoSize = true;
            this.removeNeonCheckbox.Depth = 0;
            this.removeNeonCheckbox.Location = new System.Drawing.Point(24, 25);
            this.removeNeonCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.removeNeonCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.removeNeonCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeNeonCheckbox.Name = "removeNeonCheckbox";
            this.removeNeonCheckbox.ReadOnly = false;
            this.removeNeonCheckbox.Ripple = true;
            this.removeNeonCheckbox.Size = new System.Drawing.Size(156, 37);
            this.removeNeonCheckbox.TabIndex = 0;
            this.removeNeonCheckbox.Text = "Remove Neon Kit";
            this.removeNeonCheckbox.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.clockOutButton);
            this.tabPage1.Controls.Add(this.clockInButton);
            this.tabPage1.Controls.Add(this.clearCommissionLogButton);
            this.tabPage1.Controls.Add(this.getCommissionLogButton);
            this.tabPage1.Controls.Add(this.clockOutInput);
            this.tabPage1.Controls.Add(this.commissionLogTextBox);
            this.tabPage1.Controls.Add(this.clockInInput);
            this.tabPage1.Controls.Add(this.comDateInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(946, 563);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Commission Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(358, 77);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(954, 48);
            this.materialTabSelector1.TabIndex = 7;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // clearLogButton
            // 
            this.clearLogButton.AutoSize = false;
            this.clearLogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearLogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearLogButton.Depth = 0;
            this.clearLogButton.HighEmphasis = true;
            this.clearLogButton.Icon = null;
            this.clearLogButton.Location = new System.Drawing.Point(1139, 790);
            this.clearLogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearLogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clearLogButton.Size = new System.Drawing.Size(160, 36);
            this.clearLogButton.TabIndex = 10;
            this.clearLogButton.Text = "Clear Logs";
            this.clearLogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearLogButton.UseAccentColor = false;
            this.clearLogButton.UseVisualStyleBackColor = true;
            // 
            // repairInput
            // 
            this.repairInput.AnimateReadOnly = false;
            this.repairInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repairInput.Depth = 0;
            this.repairInput.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.repairInput.Hint = "Repair";
            this.repairInput.LeadingIcon = null;
            this.repairInput.Location = new System.Drawing.Point(191, 245);
            this.repairInput.MaxLength = 50;
            this.repairInput.MouseState = MaterialSkin.MouseState.OUT;
            this.repairInput.Multiline = false;
            this.repairInput.Name = "repairInput";
            this.repairInput.Size = new System.Drawing.Size(160, 50);
            this.repairInput.TabIndex = 4;
            this.repairInput.Text = "";
            this.repairInput.TrailingIcon = null;
            // 
            // unbilledTextbox
            // 
            this.unbilledTextbox.AnimateReadOnly = false;
            this.unbilledTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unbilledTextbox.Depth = 0;
            this.unbilledTextbox.Enabled = false;
            this.unbilledTextbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.unbilledTextbox.Hint = "Unbilled Amount";
            this.unbilledTextbox.LeadingIcon = null;
            this.unbilledTextbox.Location = new System.Drawing.Point(390, 726);
            this.unbilledTextbox.MaxLength = 50;
            this.unbilledTextbox.MouseState = MaterialSkin.MouseState.OUT;
            this.unbilledTextbox.Multiline = false;
            this.unbilledTextbox.Name = "unbilledTextbox";
            this.unbilledTextbox.Size = new System.Drawing.Size(160, 50);
            this.unbilledTextbox.TabIndex = 8;
            this.unbilledTextbox.Tag = "exclude";
            this.unbilledTextbox.Text = "";
            this.unbilledTextbox.TrailingIcon = null;
            // 
            // saveLogButton
            // 
            this.saveLogButton.AutoSize = false;
            this.saveLogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveLogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveLogButton.Depth = 0;
            this.saveLogButton.HighEmphasis = true;
            this.saveLogButton.Icon = null;
            this.saveLogButton.Location = new System.Drawing.Point(630, 790);
            this.saveLogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveLogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveLogButton.Name = "saveLogButton";
            this.saveLogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveLogButton.Size = new System.Drawing.Size(160, 36);
            this.saveLogButton.TabIndex = 7;
            this.saveLogButton.Text = "Save Log";
            this.saveLogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveLogButton.UseAccentColor = false;
            this.saveLogButton.UseVisualStyleBackColor = true;
            // 
            // deleteLogButton
            // 
            this.deleteLogButton.AutoSize = false;
            this.deleteLogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteLogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteLogButton.Depth = 0;
            this.deleteLogButton.HighEmphasis = true;
            this.deleteLogButton.Icon = null;
            this.deleteLogButton.Location = new System.Drawing.Point(971, 790);
            this.deleteLogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteLogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteLogButton.Name = "deleteLogButton";
            this.deleteLogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteLogButton.Size = new System.Drawing.Size(160, 36);
            this.deleteLogButton.TabIndex = 9;
            this.deleteLogButton.Text = "Delete Log";
            this.deleteLogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteLogButton.UseAccentColor = false;
            this.deleteLogButton.UseVisualStyleBackColor = true;
            // 
            // updateBillButton
            // 
            this.updateBillButton.AutoSize = false;
            this.updateBillButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateBillButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateBillButton.Depth = 0;
            this.updateBillButton.HighEmphasis = true;
            this.updateBillButton.Icon = null;
            this.updateBillButton.Location = new System.Drawing.Point(390, 790);
            this.updateBillButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateBillButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateBillButton.Name = "updateBillButton";
            this.updateBillButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateBillButton.Size = new System.Drawing.Size(160, 36);
            this.updateBillButton.TabIndex = 6;
            this.updateBillButton.Text = "Bill Customer";
            this.updateBillButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateBillButton.UseAccentColor = false;
            this.updateBillButton.UseVisualStyleBackColor = true;
            // 
            // getCommissionLogButton
            // 
            this.getCommissionLogButton.AutoSize = false;
            this.getCommissionLogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.getCommissionLogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.getCommissionLogButton.Depth = 0;
            this.getCommissionLogButton.HighEmphasis = true;
            this.getCommissionLogButton.Icon = null;
            this.getCommissionLogButton.Location = new System.Drawing.Point(28, 207);
            this.getCommissionLogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.getCommissionLogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.getCommissionLogButton.Name = "getCommissionLogButton";
            this.getCommissionLogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.getCommissionLogButton.Size = new System.Drawing.Size(334, 50);
            this.getCommissionLogButton.TabIndex = 5;
            this.getCommissionLogButton.Text = "Generate Commission Log";
            this.getCommissionLogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.getCommissionLogButton.UseAccentColor = false;
            this.getCommissionLogButton.UseVisualStyleBackColor = true;
            // 
            // comDateInput
            // 
            this.comDateInput.AnimateReadOnly = false;
            this.comDateInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comDateInput.Depth = 0;
            this.comDateInput.Enabled = false;
            this.comDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comDateInput.Hint = "Date";
            this.comDateInput.LeadingIcon = null;
            this.comDateInput.Location = new System.Drawing.Point(28, 36);
            this.comDateInput.MaxLength = 50;
            this.comDateInput.MouseState = MaterialSkin.MouseState.OUT;
            this.comDateInput.Multiline = false;
            this.comDateInput.Name = "comDateInput";
            this.comDateInput.Size = new System.Drawing.Size(334, 50);
            this.comDateInput.TabIndex = 0;
            this.comDateInput.Tag = "exclude";
            this.comDateInput.Text = "";
            this.comDateInput.TrailingIcon = null;
            // 
            // clockInInput
            // 
            this.clockInInput.AnimateReadOnly = false;
            this.clockInInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clockInInput.Depth = 0;
            this.clockInInput.Enabled = false;
            this.clockInInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clockInInput.Hint = "Clock in time";
            this.clockInInput.LeadingIcon = null;
            this.clockInInput.Location = new System.Drawing.Point(28, 92);
            this.clockInInput.MaxLength = 50;
            this.clockInInput.MouseState = MaterialSkin.MouseState.OUT;
            this.clockInInput.Multiline = false;
            this.clockInInput.Name = "clockInInput";
            this.clockInInput.Size = new System.Drawing.Size(160, 50);
            this.clockInInput.TabIndex = 1;
            this.clockInInput.Tag = "exclude";
            this.clockInInput.Text = "";
            this.clockInInput.TrailingIcon = null;
            // 
            // clockInButton
            // 
            this.clockInButton.AutoSize = false;
            this.clockInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clockInButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clockInButton.Depth = 0;
            this.clockInButton.HighEmphasis = true;
            this.clockInButton.Icon = null;
            this.clockInButton.Location = new System.Drawing.Point(202, 92);
            this.clockInButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clockInButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clockInButton.Name = "clockInButton";
            this.clockInButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clockInButton.Size = new System.Drawing.Size(160, 50);
            this.clockInButton.TabIndex = 2;
            this.clockInButton.Text = "Clock In";
            this.clockInButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clockInButton.UseAccentColor = false;
            this.clockInButton.UseVisualStyleBackColor = true;
            // 
            // clockOutInput
            // 
            this.clockOutInput.AnimateReadOnly = false;
            this.clockOutInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clockOutInput.Depth = 0;
            this.clockOutInput.Enabled = false;
            this.clockOutInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clockOutInput.Hint = "Clock out time";
            this.clockOutInput.LeadingIcon = null;
            this.clockOutInput.Location = new System.Drawing.Point(28, 148);
            this.clockOutInput.MaxLength = 50;
            this.clockOutInput.MouseState = MaterialSkin.MouseState.OUT;
            this.clockOutInput.Multiline = false;
            this.clockOutInput.Name = "clockOutInput";
            this.clockOutInput.Size = new System.Drawing.Size(160, 50);
            this.clockOutInput.TabIndex = 3;
            this.clockOutInput.Tag = "exclude";
            this.clockOutInput.Text = "";
            this.clockOutInput.TrailingIcon = null;
            // 
            // clockOutButton
            // 
            this.clockOutButton.AutoSize = false;
            this.clockOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clockOutButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clockOutButton.Depth = 0;
            this.clockOutButton.HighEmphasis = true;
            this.clockOutButton.Icon = null;
            this.clockOutButton.Location = new System.Drawing.Point(202, 148);
            this.clockOutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clockOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clockOutButton.Name = "clockOutButton";
            this.clockOutButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clockOutButton.Size = new System.Drawing.Size(160, 50);
            this.clockOutButton.TabIndex = 4;
            this.clockOutButton.Text = "Clock Out";
            this.clockOutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clockOutButton.UseAccentColor = false;
            this.clockOutButton.UseVisualStyleBackColor = true;
            // 
            // commissionLogTextBox
            // 
            this.commissionLogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.commissionLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commissionLogTextBox.Depth = 0;
            this.commissionLogTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.commissionLogTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.commissionLogTextBox.Location = new System.Drawing.Point(369, 36);
            this.commissionLogTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.commissionLogTextBox.Name = "commissionLogTextBox";
            this.commissionLogTextBox.ReadOnly = true;
            this.commissionLogTextBox.Size = new System.Drawing.Size(568, 221);
            this.commissionLogTextBox.TabIndex = 6;
            this.commissionLogTextBox.Tag = "exclude";
            this.commissionLogTextBox.Text = "";
            this.commissionLogTextBox.Click += new System.EventHandler(this.CopyToClipboard_Click);
            // 
            // clearCommissionLogButton
            // 
            this.clearCommissionLogButton.AutoSize = false;
            this.clearCommissionLogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearCommissionLogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearCommissionLogButton.Depth = 0;
            this.clearCommissionLogButton.HighEmphasis = true;
            this.clearCommissionLogButton.Icon = null;
            this.clearCommissionLogButton.Location = new System.Drawing.Point(28, 269);
            this.clearCommissionLogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearCommissionLogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearCommissionLogButton.Name = "clearCommissionLogButton";
            this.clearCommissionLogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clearCommissionLogButton.Size = new System.Drawing.Size(334, 50);
            this.clearCommissionLogButton.TabIndex = 5;
            this.clearCommissionLogButton.Text = "Clear Commission Log";
            this.clearCommissionLogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.clearCommissionLogButton.UseAccentColor = false;
            this.clearCommissionLogButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 843);
            this.Controls.Add(this.unbilledTextbox);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.employeeCheckbox);
            this.Controls.Add(this.logdisplayTextBox);
            this.Controls.Add(this.plateInput);
            this.Controls.Add(this.vehicleInput);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.repairInput);
            this.Controls.Add(this.customerInput);
            this.Controls.Add(this.updateBillButton);
            this.Controls.Add(this.deleteLogButton);
            this.Controls.Add(this.saveLogButton);
            this.Controls.Add(this.newLogButton);
            this.Controls.Add(this.treeViewLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Hayes Log Helper v2.0";
            this.tabControl.ResumeLayout(false);
            this.installTab.ResumeLayout(false);
            this.installTab.PerformLayout();
            this.removeTab.ResumeLayout(false);
            this.removeTab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewLogs;
        private MaterialSkin.Controls.MaterialTextBox customerInput;
        private MaterialSkin.Controls.MaterialTextBox vehicleInput;
        private MaterialSkin.Controls.MaterialTextBox plateInput;
        private MaterialSkin.Controls.MaterialCheckbox employeeCheckbox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox logdisplayTextBox;
        private MaterialSkin.Controls.MaterialComboBox armorDropwdown;
        private MaterialSkin.Controls.MaterialComboBox brakesDropdown;
        private MaterialSkin.Controls.MaterialComboBox transmissionDropdown;
        private MaterialSkin.Controls.MaterialComboBox suspensionDropdown;
        private MaterialSkin.Controls.MaterialComboBox engineDropdown;
        private MaterialSkin.Controls.MaterialCheckbox turboCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox customTiresCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox aerialCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox archCoverCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox grilleCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox fBumperCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox exhaustCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox engineBlockCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox dialCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox dResprayCheckbox;
        private MaterialSkin.Controls.MaterialButton newLogButton;
        private MaterialSkin.Controls.MaterialCheckbox hoodCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox interiorResprayCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox hornCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox leftFenderCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox liveryCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox ornamentsCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox oldLiveryCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox plateCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox rBumperCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox pearlResprayCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox pResprayCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox sResprayCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox rimColorCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox rimsCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox roofCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox rollcageCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox seatsCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox skirtsCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox spoilerCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox steeringWheelCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox strutCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox speakerCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox tintCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox tireSmokeCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox trimAChekbox;
        private MaterialSkin.Controls.MaterialCheckbox trimBCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox trunkCheckbox;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage installTab;
        private System.Windows.Forms.TabPage removeTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialCheckbox removeNeonCheckbox;
        private MaterialSkin.Controls.MaterialButton clearLogButton;
        private MaterialSkin.Controls.MaterialTextBox repairInput;
        private MaterialSkin.Controls.MaterialTextBox unbilledTextbox;
        private MaterialSkin.Controls.MaterialButton saveLogButton;
        private MaterialSkin.Controls.MaterialButton deleteLogButton;
        private MaterialSkin.Controls.MaterialButton updateBillButton;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialButton getCommissionLogButton;
        private MaterialSkin.Controls.MaterialTextBox comDateInput;
        private MaterialSkin.Controls.MaterialButton clockInButton;
        private MaterialSkin.Controls.MaterialTextBox clockInInput;
        private MaterialSkin.Controls.MaterialButton clockOutButton;
        private MaterialSkin.Controls.MaterialTextBox clockOutInput;
        private MaterialSkin.Controls.MaterialMultiLineTextBox commissionLogTextBox;
        private MaterialSkin.Controls.MaterialButton clearCommissionLogButton;
    }
}

