using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicLogHelper
{
    public partial class MainForm : MaterialForm
    {
        private LogManager logManager;
        private List<UpgradeOption> upgradeOptions = new List<UpgradeOption>();

        public MainForm()
        {
            InitializeComponent();
            InitializeForm();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void InitializeForm()
        {
            logManager = new LogManager();
            RefreshTreeView();

            // performance upgrade options
            upgradeOptions.Add(new UpgradeOptionDropdown { UpgradeInput = armorDropwdown, UpgradeName = "Armor", UpgradeType = "Performance" });
            upgradeOptions.Add(new UpgradeOptionDropdown { UpgradeInput = brakesDropdown, UpgradeName = "Brakes", UpgradeType = "Performance" });
            upgradeOptions.Add(new UpgradeOptionDropdown { UpgradeInput = engineDropdown, UpgradeName = "Engine", UpgradeType = "Performance" });
            upgradeOptions.Add(new UpgradeOptionDropdown { UpgradeInput = suspensionDropdown, UpgradeName = "Suspension", UpgradeType = "Performance" });
            upgradeOptions.Add(new UpgradeOptionDropdown { UpgradeInput = transmissionDropdown, UpgradeName = "Transmission", UpgradeType = "Performance" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = turboCheckbox, UpgradeName = "Turbo", Price = 10000, UpgradeType = "Performance" });

            // cosmetic upgrade options
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = archCoverCheckbox, UpgradeName = "Arch Cover", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = aerialCheckbox, UpgradeName = "Aerial", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = customTiresCheckbox, UpgradeName = "Custom Tires", Price = 600, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = dialCheckbox, UpgradeName = "Dial", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = engineBlockCheckbox, UpgradeName = "Engine Block", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = exhaustCheckbox, UpgradeName = "Exhaust", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = fBumperCheckbox, UpgradeName = "Front Bumper", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = grilleCheckbox, UpgradeName = "Grille", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = hoodCheckbox, UpgradeName = "Hood", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = hornCheckbox, UpgradeName = "Horn", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = leftFenderCheckbox, UpgradeName = "Left Fender", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = liveryCheckbox, UpgradeName = "Livery", Price = 400, UpgradeType = "Cosmetic" });

            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = ornamentsCheckbox, UpgradeName = "Ornaments", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = oldLiveryCheckbox, UpgradeName = "Old Livery", Price = 100, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = plateCheckbox, UpgradeName = "Plate", Price = 1000, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = rBumperCheckbox, UpgradeName = "Rear Bumper", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = dResprayCheckbox, UpgradeName = "Respray Dashboard", Price = 1000, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = interiorResprayCheckbox, UpgradeName = "Respray Interior", Price = 1000, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = pearlResprayCheckbox, UpgradeName = "Respray Pearlescent", Price = 1000, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = pResprayCheckbox, UpgradeName = "Respray Primary", Price = 1000, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = sResprayCheckbox, UpgradeName = "Respray Secondary", Price = 1000, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = rimColorCheckbox, UpgradeName = "Rim Color", Price = 1000, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = rimsCheckbox, UpgradeName = "Rims", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = rollcageCheckbox, UpgradeName = "Roll Cage", Price = 400, UpgradeType = "Cosmetic" });

            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = roofCheckbox, UpgradeName = "Roof", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = seatsCheckbox, UpgradeName = "Seats", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = skirtsCheckbox, UpgradeName = "Side Skirt", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = spoilerCheckbox, UpgradeName = "Spoiler", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = steeringWheelCheckbox, UpgradeName = "Steering Wheel", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = strutCheckbox, UpgradeName = "Strut", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = speakerCheckbox, UpgradeName = "Speaker", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = tintCheckbox, UpgradeName = "Tint", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = tireSmokeCheckbox, UpgradeName = "Tire Smoke", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = trimAChekbox, UpgradeName = "Trim A", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = trimBCheckbox, UpgradeName = "Trim B", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = trunkCheckbox, UpgradeName = "Trunk", Price = 400, UpgradeType = "Cosmetic" });

            // remove upgrade options
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = removeNeonCheckbox, UpgradeName = "Remove Neon Kit", Price = 400, UpgradeType = "Cosmetic" });

            // button settings
            saveLogButton.Click += new EventHandler(SaveLogButton_Click);
            deleteLogButton.Click += new EventHandler(DeleteLogButton_Click);
            newLogButton.Click += new EventHandler(ResetButton_Click);
            clearLogButton.Click += new EventHandler(ClearLogsButton_Click);
            updateBillButton.Click += new EventHandler(BillCustomerButton_Click);
            

            // tree view setting
            this.treeViewLogs.AfterSelect += new TreeViewEventHandler(TreeViewLogs_AfterSelect);

            // input settings
            plateInput.KeyPress += AlphanumericTextBox_KeyPress;
            repairInput.KeyPress += NumberTextBox_KeyPress;

            // input update settings
            AssignUpdateEventHandlers(this.Controls);
        }

        private void AssignUpdateEventHandlers(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "exclude") { continue; }

                if (control is MaterialCheckbox matCheckbox)
                {
                    matCheckbox.CheckedChanged += UpgradeInput_Changed;
                }
                else if (control is MaterialComboBox matComboBox)
                {
                    matComboBox.SelectedValueChanged += UpgradeInput_Changed;
                }
                else if (control is MaterialTextBox matTextBox)
                {
                    matTextBox.TextChanged += UpgradeInput_Changed;
                }

                if (control.HasChildren) { AssignUpdateEventHandlers(control.Controls); }
            }
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            (sender as MaterialTextBox).MaxLength = 5;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AlphanumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            (sender as MaterialTextBox).MaxLength = 8;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void UpgradeInput_Changed(object sender, EventArgs e)
        {
            var installedUpgrades = GetInstalledUpgrades();

            UpdateUnbilledPrice(installedUpgrades);
            GenerateLogString();
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

        private List<UpgradeInfo> GetInstalledUpgrades()
        {
            List<UpgradeInfo> installedUpgrades = new List<UpgradeInfo>();

            foreach (var option in upgradeOptions)
            {
                if (option is UpgradeOptionDropdown dropdownOption)
                {
                    if (!String.IsNullOrEmpty(dropdownOption.UpgradeInput.SelectedItem.ToString()))
                    {
                        string selectedUpgrade = dropdownOption.UpgradeInput.SelectedItem.ToString();

                        var match = Regex.Match(selectedUpgrade, @"\d+");
                        if (match.Success)
                        {
                            int selectedLevel = int.Parse(match.Value);

                            if (dropdownOption.Price.TryGetValue(selectedLevel, out int price))
                            {
                                var upgradeInfo = new UpgradeInfo
                                {
                                    UpgradeName = dropdownOption.UpgradeName,
                                    UpgradeType = dropdownOption.UpgradeType,
                                    UpgradeAmount = price,
                                    UpgradeOption = selectedUpgrade,
                                    UpgradePaid = !dropdownOption.UpgradeInput.Enabled
                                };

                                int totalCost = CalculateUpgradeMargin(upgradeInfo);
                                upgradeInfo.UpgradeAmount = totalCost;
                                installedUpgrades.Add(upgradeInfo);
                            }
                        }
                    }
                }
                else if (option is UpgradeOptionCheckbox checkboxOption)
                {
                    if (checkboxOption.UpgradeInput.Checked)
                    {
                        var upgradeInfo = new UpgradeInfo
                        {
                            UpgradeName = checkboxOption.UpgradeName,
                            UpgradeType = checkboxOption.UpgradeType,
                            UpgradeAmount = checkboxOption.Price,
                            UpgradePaid = !checkboxOption.UpgradeInput.Enabled
                        };

                        int totalCost = CalculateUpgradeMargin(upgradeInfo);
                        upgradeInfo.UpgradeAmount = totalCost;
                        installedUpgrades.Add(upgradeInfo);
                    }
                }
            }

            if (!String.IsNullOrEmpty(repairInput.Text))
            {
                installedUpgrades.Add(new UpgradeInfo
                {
                    UpgradeName = "Repair",
                    UpgradeType = "Repair",
                    UpgradeAmount = int.Parse(repairInput.Text),
                    UpgradePaid = !repairInput.Enabled
                });
            }

            return installedUpgrades;
        }

        private void UpdateUnbilledPrice(List<UpgradeInfo> installedUpgrades)
        {
            int total = 0;

            foreach (var upgrade in installedUpgrades)
            {
                if (!upgrade.UpgradePaid)
                {
                    total += upgrade.UpgradeAmount;
                }
            }

            unbilledTextbox.Text = total.ToString();
        }

        private int CalculateUpgradeMargin(UpgradeInfo upgrade)
        {
            int margin = 0;

            if (!employeeCheckbox.Checked)
            {
                if (upgrade.UpgradeType == "Performance") { margin = 1000; }
                else if (upgrade.UpgradeType == "Cosmetic") { margin = 100; }
            }

            return upgrade.UpgradeAmount + margin;
        }
        
        private void GenerateLogString()
        {
            string customerName = employeeCheckbox.Checked ? $"{customerInput.Text} (MECH)" : customerInput.Text;
            string vehicle = vehicleInput.Text;
            string plate = plateInput.Text;
            string upgrades = GetFormattedUpgrades();
            int priceCharged = CalculateTotalPrice();
            string shop = "Hayes";

            string formattedString = $@"```
Customer Name: {customerName}
Vehicle | [Make/Model]: {vehicle}
Plate: {plate}
Upgrades Purchased: {upgrades}
Price Charged: ${priceCharged:n0}
SHOP: {shop}
```";

            logdisplayTextBox.Text = formattedString;
        }
        

        
        private void CopyToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(logdisplayTextBox.Text))
            {
                Clipboard.SetText(logdisplayTextBox.Text);
                MaterialMessageBox.Show("Log copied to clilpboard");
            }
        }

        private void GenerateCommissionLog_Click(object sender, EventArgs e)
        {
            string name = "Mike Lee";
            DateTime clockIn = DateTime.Now;
            DateTime clockOut = DateTime.Now;
            int hoursWorked = 1;
            int upgradeLogs = 1;
            int performanceParts = 1;
            int assistedLogs = 0;
            int totalCommission = performanceParts * 200;

            string formattedString = $@"```
Name: {name}
Clock In Time: {clockIn}
Clock Out Time: {clockOut}
Hours Worked: {hoursWorked}
Upgrade Logs: {upgradeLogs}
Performance Parts: {performanceParts}
Assisted Logs: {assistedLogs}
Total Commission: ${totalCommission:n0}
```";
        }


        private string GetFormattedUpgrades()
        {
            List<string> resprayTypes = new List<string>();
            List<string> bumperTypes = new List<string>();
            List<string> otherUpgrades = new List<string>();

            foreach (UpgradeInfo upgrade in GetInstalledUpgrades())
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
                else if (upgrade.UpgradeName.Contains("Bumper"))
                {
                    var words = upgrade.UpgradeName.Split(' ');
                    var type = "";

                    if (words.Length > 1 && words[1] == "Bumper")
                    {
                        type = words[0].Substring(0, 1);
                    }

                    bumperTypes.Add(type);
                }
                else if (upgrade.UpgradeName.Contains("Repair"))
                {
                    continue;
                }
                else if (upgrade.UpgradeName.Contains("Left Fender"))
                {
                    otherUpgrades.Add("L Fender");
                }
                else if (upgrade.UpgradeName.Contains("Side Skirt"))
                {
                    otherUpgrades.Add("Skirts");
                }
                else
                {
                    otherUpgrades.Add(upgrade.UpgradeName);
                }
            }

            string resprayFormatted = resprayTypes.Count > 0 ? $"{string.Join("/", resprayTypes)} Respray" : String.Empty;
            string bumperFormatted = bumperTypes.Count > 0 ? $"{string.Join ("/", bumperTypes)} Bumper" : String.Empty;

            List<String> allUpgrades = otherUpgrades.ToList();
            if (!string.IsNullOrEmpty(resprayFormatted))
            {
                allUpgrades.Add(resprayFormatted);
            }

            if (!string.IsNullOrEmpty(bumperFormatted))
            {
                allUpgrades.Add(bumperFormatted);
            }

            return string.Join(", ", allUpgrades);
        }

        
        private int CalculateTotalPrice()
        {
            int totalPrice = 0;

            foreach (UpgradeInfo upgrade in GetInstalledUpgrades())
            {
                totalPrice += upgrade.UpgradeAmount;
            }

            return totalPrice;
        }

        
        private void SaveLogButton_Click(object sender, EventArgs e)
        {
            if (!IsInputValid()) { return; }

            var logs = logManager.LoadLogs();

            LogEntry logEntry = new LogEntry
            {
                CustomerName = customerInput.Text,
                Vehicle = vehicleInput.Text,
                LicensePlate = plateInput.Text,
                IsEmployee = employeeCheckbox.Checked,
                Date = DateTime.Now,
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
            ClearFormFields();
            RefreshTreeView();
        }

        
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            RefreshTreeView();
        }

        private void BillCustomerButton_Click(object sender, EventArgs e)
        {
            foreach (var upgrade in GetInstalledUpgrades())
            {
                foreach (var option in upgradeOptions)
                {
                    if (upgrade.UpgradeName == option.UpgradeName)
                    {
                        if (option is UpgradeOptionDropdown dropdown)
                        {
                            dropdown.UpgradeInput.Enabled = false;
                            upgrade.UpgradePaid = true;
                        }
                        else if (option is UpgradeOptionCheckbox checkbox)
                        {
                            checkbox.UpgradeInput.Enabled = false;
                            upgrade.UpgradePaid = true;
                        }
                    }
                }

                if (upgrade.UpgradeName.Contains("Repair"))
                {
                    repairInput.Enabled = false;
                    upgrade.UpgradePaid = true;
                }
            }

            UpdateUnbilledPrice(GetInstalledUpgrades());
        }

        private void DeleteLogButton_Click(object sender, EventArgs e)
        {
            if (treeViewLogs.SelectedNode != null && treeViewLogs.SelectedNode.Level == 1)
            {
                var logEntry = treeViewLogs.SelectedNode.Tag as LogEntry;
                if (logEntry != null)
                {
                    logManager.DeleteLog(logEntry);
                    ClearFormFields();
                    RefreshTreeView();
                }
            }
        }
        
        private bool IsInputValid()
        {
            List<string> errorMessages = new List<string>();
            errorMessages.Add("Required fields missing:");

            if (string.IsNullOrWhiteSpace(customerInput.Text))
            {
                errorMessages.Add("Customer Name");
            }

            if (string.IsNullOrWhiteSpace(vehicleInput.Text))
            {
                errorMessages.Add("Vehicle Make/Model");
            }

            if (string.IsNullOrWhiteSpace(plateInput.Text))
            {
                errorMessages.Add("License Plate");
            }

            if (errorMessages.Count > 1)
            {
                string errorMessage = string.Join("\n", errorMessages);
                MaterialMessageBox.Show(errorMessage);
                return false;
            }

            return true;
        }

        private void ClearFormFields()
        {
            customerInput.Text = String.Empty;
            vehicleInput.Text = String.Empty;
            plateInput.Text = String.Empty;
            employeeCheckbox.Checked = false;
            logdisplayTextBox.Text = String.Empty;
            repairInput.Text = String.Empty;
            repairInput.Enabled = true;

            foreach (UpgradeOption option in upgradeOptions)
            {
                if (option is UpgradeOptionDropdown dropdown)
                {
                    dropdown.UpgradeInput.ResetText();
                    dropdown.UpgradeInput.Enabled = true;
                    dropdown.UpgradeInput.Refresh();
                }
                else if (option is UpgradeOptionCheckbox checkbox)
                {
                    checkbox.UpgradeInput.Checked = false;
                    checkbox.UpgradeInput.Enabled = true;
                }
            }

            GenerateLogString();
        }

        
        private void TreeViewLogs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 1)
            {
                var selectedLog = e.Node.Tag as LogEntry;

                if (selectedLog != null)
                {
                    ClearFormFields();

                    customerInput.Text = selectedLog.CustomerName;
                    vehicleInput.Text = selectedLog.Vehicle;
                    plateInput.Text = selectedLog.LicensePlate;
                    employeeCheckbox.Checked = selectedLog.IsEmployee;

                    foreach (var upgrade in selectedLog.Upgrades)
                    {
                        foreach (var upgradeOption in upgradeOptions)
                        {
                            if (upgradeOption.UpgradeName == upgrade.UpgradeName)
                            {
                                if (upgradeOption is UpgradeOptionCheckbox checkboxOption)
                                {
                                    checkboxOption.UpgradeInput.Checked = true;
                                    checkboxOption.UpgradeInput.Enabled = !upgrade.UpgradePaid;
                                }
                                else if (upgradeOption is UpgradeOptionDropdown dropdownOption)
                                {
                                    dropdownOption.UpgradeInput.Text = upgrade.UpgradeOption;
                                    dropdownOption.UpgradeInput.Enabled = !upgrade.UpgradePaid;
                                    dropdownOption.UpgradeInput.Refresh();
                                }
                            }
                        }

                        if (upgrade.UpgradeName.Contains("Repair"))
                        {
                            repairInput.Text = upgrade.UpgradeAmount.ToString();
                            repairInput.Enabled = !upgrade.UpgradePaid;
                        }
                    }

                    GenerateLogString();
                }
            }
        }
    }
}
