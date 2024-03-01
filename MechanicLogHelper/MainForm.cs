using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MechanicLogHelper
{
    public partial class MainForm : Form
    {
        private LogManager logManager;
        private List<UpgradeOption> upgradeOptions = new List<UpgradeOption>();

        public MainForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            logManager = new LogManager();
            RefreshTreeView();

            // init performance upgrade options
            upgradeOptions.Add(new UpgradeOption { Checkbox = armorCheckbox, InputField = armorAmountInput, TypeField = armorTypeInput, UpgradeName = "Armor" });
            upgradeOptions.Add(new UpgradeOption { Checkbox = brakeCheckbox, InputField = brakeAmountInput, TypeField = brakeTypeInput, UpgradeName = "Brake" });
            upgradeOptions.Add(new UpgradeOption { Checkbox = engineCheckbox, InputField = engineAmountInput, TypeField = engineTypeInput, UpgradeName = "Engine" });
            upgradeOptions.Add(new UpgradeOption { Checkbox = suspensionCheckbox, InputField = suspensionAmountInput, TypeField = suspensionTypeInput, UpgradeName = "Suspension" });
            upgradeOptions.Add(new UpgradeOption { Checkbox = transmissionCheckbox, InputField = transmissionAmountInput, TypeField = transmissionTypeInput, UpgradeName = "Transmission" });
            upgradeOptions.Add(new UpgradeOption { Checkbox = turboCheckbox, InputField = turboAmountInput, TypeField = turboTypeInput, UpgradeName = "Turbo" });

            // init cosmetic upgrade options
            upgradeOptions.Add(new UpgradeOption { Checkbox = dialCheckbox, InputField = dialAmountInput, TypeField = dialTypeInput, UpgradeName = "Dial" });
            upgradeOptions.Add(new UpgradeOption { Checkbox = engineBlockCheckbox, InputField = engineBlockAmountInput, TypeField = engineBlockTypeInput, UpgradeName = "Engine Block" });
            upgradeOptions.Add(new UpgradeOption { Checkbox = exhaustCheckbox, InputField = exhaustAmountInput, TypeField = exhaustTypeInput, UpgradeName = "Exhaust" });
            upgradeOptions.Add(new UpgradeOption { Checkbox = frontBumperCheckbox, InputField = frontBumperAmountInput, TypeField = frontBumperTypeInput, UpgradeName = "Front Bumper" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = hoodCheckbox, InputField = hoodAmountInput, TypeField = hoodTypeInput, UpgradeName = "Hood" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = hornCheckbox, InputField = hornAmountInput, TypeField = hornTypeInput, UpgradeName = "Horn" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = leftFenderCheckbox, InputField = leftFenderAmountInput, TypeField = leftFenderTypeInput, UpgradeName = "Left Fender" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = liveryCheckbox, InputField = liveryAmountInput, TypeField = liveryTypeInput, UpgradeName = "Livery" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = ornamentsCheckbox, InputField = ornamentsAmountInput, TypeField = ornamentsTypeInput, UpgradeName = "Ornaments" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = plateCheckbox, InputField = plateAmountInput, TypeField = plateTypeInput, UpgradeName = "Plate" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = rearBumperCheckbox, InputField = rearBumperAmountInput, TypeField = rearBumperTypeInput, UpgradeName = "Rear Bumper" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = resprayPearlCheckbox, InputField = resprayPearlAmountInput, TypeField = resprayPearlTypeInput, UpgradeName = "Respray Pearl" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = resprayPrimaryCheckbox, InputField = resprayPrimaryAmountInput, TypeField = resprayPrimaryTypeInput, UpgradeName = "Respray Prim" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = respraySecondaryCheckbox, InputField = respraySecondaryAmountInput, TypeField = respraySecondaryTypeInput, UpgradeName = "Respray S" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = rimColorCheckbox, InputField = rimColorAmountInput, TypeField = rimColorTypeInput, UpgradeName = "Rim Color" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = rimsCheckbox, InputField = rimsAmountInput, TypeField = rimsTypeInput, UpgradeName = "Rims" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = roofCheckbox, InputField = roofAmountInput, TypeField = roofTypeInput, UpgradeName = "Roof" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = seatsCheckbox, InputField = seatsAmountInput, TypeField = seatsTypeInput, UpgradeName = "Seats" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = sideSkirtCheckbox, InputField = sideSkirtAmountInput, TypeField = sideSkirtTypeInput, UpgradeName = "Side Skirt" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = spoilerCheckbox, InputField = spoilerAmountInput, TypeField = spoilerTypeInput, UpgradeName = "Spoiler" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = steeringWheelCheckbox, InputField = steeringWheelAmountInput, TypeField = steeringWheelTypeInput, UpgradeName = "Steering Wheel" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = strutCheckbox, InputField = strutAmountInput, TypeField = strutTypeInput, UpgradeName = "Strut" }); 
            upgradeOptions.Add(new UpgradeOption { Checkbox = tintCheckbox, InputField = tintAmountInput, TypeField = tintTypeInput, UpgradeName = "Tint" });
            upgradeOptions.Add(new UpgradeOption { Checkbox = tireSmokeCheckbox, InputField = tireSmokeAmountInput, TypeField = tireSmokeTypeInput, UpgradeName = "Tire Smoke" }); 

            // button settings
            saveLogBtn.Click += new EventHandler(SaveLogButton_Click);
            clearLogsBtn.Click += new EventHandler(ClearAllLogs_Click);
            deleteLogBtn.Click += new EventHandler(DeleteLogButton_Click);
            resetBtn.Click += new EventHandler(ResetButton_Click);

            // tree view setting
            this.treeViewLogs.AfterSelect += new TreeViewEventHandler(TreeViewLogs_AfterSelect);

            // input settings
            licenseInput.KeyPress += AlphanumericTextBox_KeyPress;
            armorAmountInput.KeyPress += NumberTextBox_KeyPress;
            brakeAmountInput.KeyPress += NumberTextBox_KeyPress;

            // checkbox settings
            armorCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            brakeCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            engineCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            suspensionCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            transmissionCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            turboCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            dialCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            engineBlockCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            exhaustCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            frontBumperCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            hoodCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            hornCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            leftFenderCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            liveryCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            ornamentsCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            plateCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            rearBumperCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            resprayPearlCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            resprayPrimaryCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            respraySecondaryCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            rimColorCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            rimsCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            roofCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            seatsCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            sideSkirtCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            spoilerCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            steeringWheelCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            strutCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            tintCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
            tireSmokeCheckbox.CheckedChanged += UpgradeCheckbox_CheckedChanged;
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            (sender as TextBox).MaxLength = 5;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AlphanumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            (sender as TextBox).MaxLength = 8;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RefreshTreeView()
        {
            treeViewLogs.Nodes.Clear();
            var logs = logManager.LoadLogs();

            if (logs == null || !logs.Any())
            {
                TreeNode emptyNode = new TreeNode(DateTime.Now.ToString("yyyy-MM-dd"));
                treeViewLogs.Nodes.Add(emptyNode);
            }
            else
            {
                var groupedLogs = logs.GroupBy(log => log.Date.ToString("yyyy-MM-dd"));

                foreach (var group in groupedLogs)
                {
                    TreeNode dateNode = new TreeNode(group.Key);
                    foreach (var log in group)
                    {
                        TreeNode logNode = new TreeNode($"{log.CustomerName} - {log.Vehicle}");
                        logNode.Tag = log;
                        dateNode.Nodes.Add(logNode);
                    }
                    treeViewLogs.Nodes.Add(dateNode);
                }
            }

            treeViewLogs.ExpandAll();
        }

        private void GenerateInfoString()
        {
            string customerName = employeeCheckbox.Checked ? $"{customerNameInput.Text} (MECH)" : customerNameInput.Text;
            string vehicle = vehicleInput.Text;
            string plate = licenseInput.Text;
            string upgrades = GetFormattedUpgrades();
            int priceCharged = CalculateTotalPrice();
            string shop = shopInput.Text;

            string formattedString = $@"```
Customer Name: {customerName}
Vehicle | [Make/Model]: {vehicle}
Plate: {plate}
Upgrades Purchased: {upgrades}
Price Charged: ${priceCharged}
SHOP: {shop}
```";

            infoDisplayTextBox.Text = formattedString;
        }

        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(infoDisplayTextBox.Text))
            {
                Clipboard.SetText(infoDisplayTextBox.Text);
                MessageBox.Show("Log copied to clilpboard");
            }
        }

        private string GetFormattedUpgrades()
        {
            List<string> resprayTypes = new List<string>();
            List<string> otherUpgrades = new List<string>();

            foreach (UpgradeOption upgrade in upgradeOptions)
            {
                if (upgrade.Checkbox.Checked)
                {
                    if (upgrade.UpgradeName.Contains("Respray"))
                    {
                        var words = upgrade.UpgradeName.Split(' ');
                        var type = "";

                        if (words.Length > 1 && words[0] == "Respray")
                        {
                            type = words[1].Substring(0, 1);
                        }

                        resprayTypes.Add(type);
                    }
                    else
                    {
                        otherUpgrades.Add(upgrade.UpgradeName);
                    }
                }
            }

            string resprayFormatted = resprayTypes.Count > 0 ? $"Respray {string.Join("/", resprayTypes)}" : String.Empty;

            List<String> allUpgrades = otherUpgrades.ToList();
            if (!string.IsNullOrEmpty(resprayFormatted))
            {
                allUpgrades.Add(resprayFormatted);
            }

            return string.Join(", ", allUpgrades);
        }

        private int CalculateTotalPrice()
        {
            int totalPrice = 0;

            foreach (UpgradeOption upgrade in upgradeOptions)
            {
                if (upgrade.Checkbox.Checked)
                {
                    totalPrice += int.Parse(upgrade.InputField.Text);
                }
            }

            return totalPrice;
        }

        private void SaveLogButton_Click(object sender, EventArgs e)
        {
            if (!IsInputValid()) { return; }

            var logs = logManager.LoadLogs();

            LogEntry logEntry = new LogEntry
            {
                CustomerName = customerNameInput.Text,
                Vehicle = vehicleInput.Text,
                LicensePlate = licenseInput.Text,
                IsEmployee = employeeCheckbox.Checked,
                Date = DateTime.Now,
                Shop = shopInput.Text,
                Upgrades = GetInstalledUpgrades()
            };

            var existingLog = logs.FirstOrDefault(log => log.CustomerName == logEntry.CustomerName && log.Date.Date == logEntry.Date.Date);
            if (existingLog != null)
            {
                logs[logs.IndexOf(existingLog)] = logEntry;
            }
            else
            {
                logs.Add(logEntry);
            }

            logManager.SaveLogs(logs);

            RefreshTreeView();
            ClearFormFields();
        }

        private void ClearLogsButton_Click(object sender, EventArgs e)
        {
            logManager.ClearLogs();
            RefreshTreeView();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            RefreshTreeView();
        }

        private void DeleteLogButton_Click(object sender, EventArgs e)
        {
            if (treeViewLogs.SelectedNode != null && treeViewLogs.SelectedNode.Level == 1)
            {
                var logEntry = treeViewLogs.SelectedNode.Tag as LogEntry;
                if (logEntry != null)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this log?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        logManager.DeleteLog(logEntry);
                        ClearFormFields();
                        RefreshTreeView();
                    }
                }
            }
        }

        private void UpgradeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)sender;
            if (checkBox != null)
            {
                var upgradeOption = upgradeOptions.FirstOrDefault(uo => uo.Checkbox == checkBox);
                if (upgradeOption != null)
                {
                    upgradeOption.InputField.Enabled = checkBox.Checked;
                    upgradeOption.TypeField.Enabled = checkBox.Checked;

                    if (!upgradeOption.Checkbox.Checked)
                    {
                        upgradeOption.InputField.Text = String.Empty;
                        upgradeOption.TypeField.Text = String.Empty;
                    }
                }
            }
        }

        private bool IsInputValid()
        {
            List<string> errorMessages = new List<string>();
            errorMessages.Add("Required fields missing:");

            if (string.IsNullOrWhiteSpace(customerNameInput.Text))
            {
                errorMessages.Add("Customer Name");
            }

            if (string.IsNullOrWhiteSpace(vehicleInput.Text))
            {
                errorMessages.Add("Vehicle Make/Model");
            }

            if (string.IsNullOrWhiteSpace(licenseInput.Text))
            {
                errorMessages.Add("License Plate");
            }

            if (!IsAtleastOneUpgradeSelected())
            {
                errorMessages.Add("Minimum of one upgrade");
            }

            if (!IsUpgradeInputValid())
            {
                errorMessages.Add("Installed upgrade price");
            }

            if (errorMessages.Count > 1)
            {
                string errorMessage = string.Join("\n", errorMessages);
                MessageBox.Show(errorMessage);
                return false;
            }

            return true;
        }

        private void ClearFormFields()
        {
            customerNameInput.Text = String.Empty;
            vehicleInput.Text = String.Empty;
            licenseInput.Text = String.Empty;
            employeeCheckbox.Checked = false;
            // add upgrade field clearing
            foreach (UpgradeOption option in upgradeOptions)
            {
                option.Checkbox.Checked = false;
                option.InputField.Text = "";
            }
            infoDisplayTextBox.Text = String.Empty;
        }

        private void TreeViewLogs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 1)
            {
                var selectedLog = e.Node.Tag as LogEntry;

                if (selectedLog != null)
                {
                    ClearFormFields();

                    customerNameInput.Text = selectedLog.CustomerName;
                    vehicleInput.Text = selectedLog.Vehicle;
                    licenseInput.Text = selectedLog.LicensePlate;
                    employeeCheckbox.Checked = selectedLog.IsEmployee;
                    shopInput.Text = selectedLog.Shop;

                    foreach (var upgrade in selectedLog.Upgrades)
                    {
                        var upgradeOption = upgradeOptions.FirstOrDefault(uo => uo.UpgradeName == upgrade.UpgradeName);
                        if (upgradeOption != null)
                        {
                            upgradeOption.Checkbox.Checked = true;
                            upgradeOption.InputField.Text = upgrade.UpgradeAmount.ToString();
                            upgradeOption.TypeField.Text = upgrade.UpgradeType;
                            GenerateInfoString();
                        }
                    }
                }
            }
        }

        private void ClearAllLogs_Click(object sender, EventArgs e)
        {
            logManager.ClearLogs();
            RefreshTreeView();
        }

        private List<UpgradeInfo> GetInstalledUpgrades()
        {
            List<UpgradeInfo> installedUpgrades = new List<UpgradeInfo>();

            foreach (UpgradeOption upgrade in upgradeOptions)
            {
                if (upgrade.Checkbox.Checked)
                {
                    installedUpgrades.Add(new UpgradeInfo
                    {
                        UpgradeName = upgrade.UpgradeName,
                        UpgradeAmount = int.Parse(upgrade.InputField.Text),
                        UpgradeType = upgrade.TypeField.Text
                    });
                }
            }

            return installedUpgrades;
        }

        private bool IsAtleastOneUpgradeSelected()
        {
            foreach (UpgradeOption upgrade in upgradeOptions)
            {
                if (upgrade.Checkbox.Checked)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsUpgradeInputValid()
        {
            foreach (UpgradeOption upgrade in upgradeOptions)
            {
                if (upgrade.Checkbox.Checked && String.IsNullOrEmpty(upgrade.InputField.Text))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
