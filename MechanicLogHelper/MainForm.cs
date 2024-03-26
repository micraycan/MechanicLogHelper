using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
        private LogEntry selectedLogEntry = null;

        public MainForm()
        {
            InitializeComponent();
            InitializeForm();

            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            string versionString = $"v{version.Major}.{version.Minor}";
            this.Text = $"Mechanic Log Helper {versionString}";

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void InitializeForm()
        {
            // load default string property settings
            mechNameInput.Text = Properties.Settings.Default.MechName;
            mechShopInput.Text = Properties.Settings.Default.MechShop;
            blacklistedInput.Text = Properties.Settings.Default.Blacklisted;

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
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = airFilterCheckbox, UpgradeName = "Air Filter", Price = 400, UpgradeType = "Cosmetic" });
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
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = rightFenderCheckbox, UpgradeName = "Right Fender", Price = 400, UpgradeType = "Cosmetic" });
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
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = vanityCheckbox, UpgradeName = "Vanity Plate", Price = 400, UpgradeType = "Cosmetic" });

            // unlisted upgrade options
            upgradeOptions.Add(new UpgradeOptionUnlisted { UpgradeInput = uName1, UpgradePrice = uPrice1, TypeInput = uType1 });
            upgradeOptions.Add(new UpgradeOptionUnlisted { UpgradeInput = uName2, UpgradePrice = uPrice2, TypeInput = uType2 });
            upgradeOptions.Add(new UpgradeOptionUnlisted { UpgradeInput = uName3, UpgradePrice = uPrice3, TypeInput = uType3 });
            upgradeOptions.Add(new UpgradeOptionUnlisted { UpgradeInput = uName4, UpgradePrice = uPrice4, TypeInput = uType4 });
            upgradeOptions.Add(new UpgradeOptionUnlisted { UpgradeInput = uName5, UpgradePrice = uPrice5, TypeInput = uType5 });
            upgradeOptions.Add(new UpgradeOptionUnlisted { UpgradeInput = uName6, UpgradePrice = uPrice6, TypeInput = uType6 });
            upgradeOptions.Add(new UpgradeOptionUnlisted { UpgradeInput = uName7, UpgradePrice = uPrice7, TypeInput = uType7 });
            upgradeOptions.Add(new UpgradeOptionUnlisted { UpgradeInput = uName8, UpgradePrice = uPrice8, TypeInput = uType8 });

            // remove upgrade options
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = removeNeonCheckbox, UpgradeName = "Remove Neon Kit", Price = 400, UpgradeType = "Cosmetic" });
            upgradeOptions.Add(new UpgradeOptionCheckbox { UpgradeInput = removeXenonCheckbox, UpgradeName = "Remove Xenon Kit", Price = 400, UpgradeType = "Cosmetic" });

            // button settings
            saveLogButton.Click += new EventHandler(SaveLogButton_Click);
            deleteLogButton.Click += new EventHandler(DeleteLogButton_Click);
            newLogButton.Click += new EventHandler(ResetButton_Click);
            clearLogButton.Click += new EventHandler(ClearLogsButton_Click);
            updateBillButton.Click += new EventHandler(BillCustomerButton_Click);
            clockInButton.Click += new EventHandler(ClockInButton_Click);
            clockOutButton.Click += new EventHandler(ClockOutButton_Click);
            getCommissionLogButton.Click += new EventHandler(GenerateCommissionLog_Click);
            clearCommissionLogButton.Click += new EventHandler(ClearCommissionLog_Click);
            setDefaultButton.Click += new EventHandler(SettingsSaveButton_Click);
            newShiftButton.Click += new EventHandler(StartNewShiftButton_Click);

            // tree view setting
            this.treeViewLogs.AfterSelect += new TreeViewEventHandler(TreeViewLogs_AfterSelect);

            // input settings
            plateInput.KeyPress += AlphanumericTextBox_KeyPress;
            repairInput.KeyPress += NumberTextBox_KeyPress;
            uPrice1.KeyPress += NumberTextBox_KeyPress;
            uPrice2.KeyPress += NumberTextBox_KeyPress;
            uPrice3.KeyPress += NumberTextBox_KeyPress;
            uPrice4.KeyPress += NumberTextBox_KeyPress;
            uPrice5.KeyPress += NumberTextBox_KeyPress;
            uPrice6.KeyPress += NumberTextBox_KeyPress;
            uPrice7.KeyPress += NumberTextBox_KeyPress;
            uPrice8.KeyPress += NumberTextBox_KeyPress;
            clockInInput.TextChanged += ClockInOutInput_TextChanged;
            clockOutInput.TextChanged += ClockInOutInput_TextChanged;
            customerInput.TextChanged += CustomerNameInput_Changed;

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

        private void SettingsSaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MechName = mechNameInput.Text;
            Properties.Settings.Default.MechShop = mechShopInput.Text;
            Properties.Settings.Default.Blacklisted = blacklistedInput.Text;
            Properties.Settings.Default.Save();
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

        private void CustomerNameInput_Changed(object sender, EventArgs e)
        {
            List<string> blacklisted = GetBlacklistedNames();

            foreach (var name in blacklisted)
            {
                if (customerInput.Text == name)
                {
                    customerInput.Text = String.Empty;
                    MaterialMessageBox.Show($"{name} is blacklisted, cannot work on vehicle.\n" +
                        $"Check city or shop email for more info.\n" +
                        $"If blacklist has expired, please remove.");
                }
            }
        }

        private void UpgradeInput_Changed(object sender, EventArgs e)
        {
            var installedUpgrades = GetInstalledUpgrades();

            UpdateUnbilledPrice(installedUpgrades);
            GenerateLogString();
        }

        private void StartNewShiftButton_Click(object sender, EventArgs e)
        {
            var logs = logManager.LoadLogs();
            int currentShift = Properties.Settings.Default.CurrentShiftNumber;

            if (logs.Any(log => log.ShiftNumber == currentShift))
            {
                Properties.Settings.Default.CurrentShiftNumber++;
                Properties.Settings.Default.Save();
            }
            
            RefreshTreeView();
        }

        private List<string> GetBlacklistedNames()
        {
            var blacklistedNamesString = Properties.Settings.Default.Blacklisted;

            return blacklistedNamesString
                .Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
        }
        
        private void RefreshTreeView()
        {
            treeViewLogs.Nodes.Clear();
            var logs = logManager.LoadLogs();
            int currentShift = Properties.Settings.Default.CurrentShiftNumber;

            if (!logs.Any(log => log.ShiftNumber == currentShift))
            {
                logs.Add(new LogEntry { ShiftNumber = currentShift, Date = DateTime.Now });
            }

            var groupedLogs = logs.GroupBy(log => log.ShiftNumber)
                    .OrderByDescending(group => group.Key);

            foreach (var group in groupedLogs)
            {
                var earliestDate = group.Where(log => log.Date != DateTime.MinValue)
                    .OrderBy(log => log.Date)
                    .FirstOrDefault()?.Date.ToString("M/dd/yyyy") ?? DateTime.Now.ToString("M/dd/yyyy");

                TreeNode shiftNode = new TreeNode($"Shift #{group.Key} ({earliestDate})");
                foreach (var log in group)
                {
                    if (!string.IsNullOrEmpty(log.CustomerName))
                    {
                        TreeNode logNode = new TreeNode($"{log.CustomerName} - {log.Vehicle}");
                        logNode.Tag = log;
                        shiftNode.Nodes.Add(logNode);
                    }
                }

                treeViewLogs.Nodes.Add(shiftNode);
            }

            treeViewLogs.ExpandAll();

            if (treeViewLogs.Nodes.Count > 0)
            {
                treeViewLogs.SelectedNode = treeViewLogs.Nodes[0];
                treeViewLogs.Nodes[0].EnsureVisible();
            }

            PopulateShiftDropdown();
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
                else if (option is UpgradeOptionUnlisted unlistedOption)
                {
                    if (unlistedOption.UpgradeInput.TextLength > 0 && unlistedOption.UpgradePrice.TextLength > 0 && unlistedOption.TypeInput.SelectedIndex > 0)
                    {
                        if (int.TryParse(unlistedOption.UpgradePrice.Text, out int parsedPrice))
                        {
                            var upgradeInfo = new UpgradeInfo
                            {
                                UpgradeName = unlistedOption.UpgradeInput.Text,
                                UpgradeType = unlistedOption.TypeInput.Text,
                                UpgradeAmount = parsedPrice,
                                UpgradePaid = !unlistedOption.UpgradePrice.Enabled
                            };

                            int totalCost = CalculateUpgradeMargin(upgradeInfo);
                            upgradeInfo.UpgradeAmount = totalCost;
                            installedUpgrades.Add(upgradeInfo);
                        }
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
            string customerName = employeeCheckbox.Checked ? $"{customerInput.Text} [MECH]" : customerInput.Text;
            string vehicle = vehicleInput.Text;
            string plate = plateInput.Text;
            string upgrades = GetFormattedUpgrades();
            int priceCharged = CalculateTotalPrice();
            string shop = Properties.Settings.Default.MechShop;

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
            MaterialMultiLineTextBox sourceTextBox = sender as MaterialMultiLineTextBox;

            if (sourceTextBox != null && !string.IsNullOrEmpty(sourceTextBox.Text))
            {
                Clipboard.SetText(sourceTextBox.Text);
                MaterialMessageBox.Show("Log copied to clilpboard");
            }
        }

        private string RoundTime(DateTime time)
        {
            int minutes = time.Minute;
            int remainder = minutes % 15;
            int change = remainder < 8 ? -remainder : 15 - remainder;

            DateTime roundedTime = time.AddMinutes(change);
            return roundedTime.ToString("hh:mm tt");
        }

        private void ClockInButton_Click(object sender, EventArgs e)
        {
            var roundedTime = RoundTime(DateTime.Now);
            comDateInput.Text = DateTime.Now.ToString("M/dd/yyyy");
            clockInInput.Text = roundedTime;
        }

        private void ClockOutButton_Click(object sender, EventArgs e)
        {
            var roundedTime = RoundTime(DateTime.Now);
            clockOutInput.Text = roundedTime;
        }

        private void ClearCommissionLog_Click(object sender, EventArgs e)
        {
            comDateInput.Clear();
            clockInInput.Clear();
            clockOutInput.Clear();
            commissionLogTextBox.Clear();
        }

        private void GenerateCommissionLog_Click(object sender, EventArgs e)
        {
            if (shiftNumberDropdown.SelectedItem == null)
            {
                return;
            }

            string selectedShiftString = shiftNumberDropdown.SelectedItem.ToString();
            if (int.TryParse(selectedShiftString.Split('#').Last(), out int selectedShiftNumber))
            {
                var logs = logManager.LoadLogs().Where(log => log.ShiftNumber == selectedShiftNumber).ToList();

                string name = Properties.Settings.Default.MechName;
                string date = comDateInput.Text;
                string clockIn = clockInInput.Text;
                string clockOut = clockOutInput.Text;
                string hoursWorked = GetHoursWorked();
                int upgradeLogs = logs.Count;
                int performanceParts = logs.Sum(log => CountPerformancePartInstalls(log));
                int assistedLogs = 0;
                int totalCommission = performanceParts * 200;

                string formattedString = $@"```
Name: {name}
Date: {date}
Clock In Time: {clockIn}
Clock Out Time: {clockOut}
Hours Worked: {hoursWorked}
Upgrade Logs: {upgradeLogs}
Performance Parts: {performanceParts}
Assisted Logs: {assistedLogs}
Total Commission: ${totalCommission:n0}
```";

                commissionLogTextBox.Text = formattedString;
            }
        }

        private void PopulateShiftDropdown()
        {
            var logs = logManager.LoadLogs();
            var shiftNumbers = logs.Select(log => log.ShiftNumber).Distinct().OrderBy(number => number);

            shiftNumberDropdown.Items.Clear();
            foreach (var shiftNumber in shiftNumbers)
            {
                shiftNumberDropdown.Items.Add($"Shift #{shiftNumber}");
            }

            if (shiftNumberDropdown.Items.Count > 0)
            {
                shiftNumberDropdown.SelectedIndex = 0;
            }
        }

        private string GetHoursWorked()
        {
            DateTime clockInTime = DateTime.ParseExact(clockInInput.Text, "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime clockOutTime = DateTime.ParseExact(clockOutInput.Text, "hh:mm tt", CultureInfo.InvariantCulture);

            if (clockOutTime < clockInTime)
            {
                clockOutTime = clockOutTime.AddDays(1);
            }

            TimeSpan hoursWorked = clockOutTime - clockInTime;

            string hoursWorkedString = hoursWorked.TotalHours.ToString("N2");
            hoursWorkedString = hoursWorkedString.TrimEnd('0');

            if (hoursWorkedString.EndsWith("."))
            {
                hoursWorkedString = hoursWorkedString.TrimEnd('.');
            }

            return hoursWorkedString;
        }

        private void ClockInOutInput_TextChanged(object sender, EventArgs e)
        {
            getCommissionLogButton.Enabled = !string.IsNullOrEmpty(clockInInput.Text) && !string.IsNullOrEmpty(clockOutInput.Text);
        }

        private int CountPerformancePartInstalls(LogEntry logEntry)
        {
            int partCount = 0;

            foreach (var upgrade in logEntry.Upgrades)
            {
                if (upgrade.UpgradeType == "Performance")
                {
                    partCount++;
                }
            }

            return partCount;
        }

        private string GetFormattedUpgrades()
        {
            List<string> resprayTypes = new List<string>();
            List<string> fenderTypes = new List<string>();
            List<string> bumperTypes = new List<string>();
            List<string> otherUpgrades = new List<string>();

            foreach (UpgradeInfo upgrade in GetInstalledUpgrades())
            {
                if (upgrade.UpgradeName.Contains("Respray"))
                {
                    var words = upgrade.UpgradeName.Split(' ');

                    if (words.Length > 1 && words[0] == "Respray")
                    {
                        var type = words[1].Substring(0, 1);
                        resprayTypes.Add(type);
                    }
                }
                else if (upgrade.UpgradeName.Contains("Bumper"))
                {
                    var words = upgrade.UpgradeName.Split(' ');

                    if (words.Length > 1 && words[1] == "Bumper")
                    {
                        var type = words[0].Substring(0, 1);
                        bumperTypes.Add(type);
                    }
                }
                else if (upgrade.UpgradeName.Contains("Fender"))
                {
                    var words = upgrade.UpgradeName.Split(' ');

                    if (words.Length > 1 && words[1] == "Fender")
                    {
                        var type = words[0].Substring(0, 1);
                        fenderTypes.Add(type);
                    }
                }
                else if (upgrade.UpgradeName.Contains("Repair"))
                {
                    continue;
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

            var resprayOrder = new List<string> { "P", "S", "I", "D" };

            var sortedResprays = resprayOrder
                .Where(r => resprayTypes.Contains(r))
                .SelectMany(r => resprayTypes.Where(t => t == r))
                .ToList();

            for (int i = 0; i < sortedResprays.Count - 2; i++)
            {
                if (sortedResprays[i] == "P" && sortedResprays[i + 1] == "P" && sortedResprays[i + 2] == "S")
                {
                    sortedResprays[i + 1] = "S";
                    sortedResprays[i + 2] = "P";
                    break;
                }
            }

            string resprayFormatted = sortedResprays.Count > 0 ? $"{string.Join("/", sortedResprays)} Respray" : String.Empty;
            string bumperFormatted = bumperTypes.Count > 0 ? $"{string.Join ("/", bumperTypes)} Bumper" : String.Empty;
            string fenderFormatted = fenderTypes.Count > 0 ? $"{string.Join("/", fenderTypes)} Fender" : String.Empty;
            
            string[] formattedUpgrades = { resprayFormatted, bumperFormatted, fenderFormatted };
            List<string> allUpgrades = otherUpgrades.ToList();

            foreach(string upgrade in formattedUpgrades)
            {
                if (!string.IsNullOrEmpty(upgrade))
                {
                    allUpgrades.Add(upgrade);
                }
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
                Upgrades = GetInstalledUpgrades(),
                ShiftNumber = Properties.Settings.Default.CurrentShiftNumber
            };

            int logIndex = -1;
            if (selectedLogEntry != null)
            {
                logIndex = logs.FindIndex(log =>
                    log.CustomerName == selectedLogEntry.CustomerName &&
                    log.Vehicle == selectedLogEntry.Vehicle &&
                    log.Date.Date == selectedLogEntry.Date.Date &&
                    log.ShiftNumber == selectedLogEntry.ShiftNumber);
            }

            if (logIndex != -1)
            {
                logs[logIndex] = logEntry;
            }
            else
            {
                logs.Add(logEntry);
            }

            logManager.SaveLogs(logs);

            RefreshTreeView();
            ClearFormFields();
            selectedLogEntry = null;
        }

        
        private void ClearLogsButton_Click(object sender, EventArgs e)
        {
            logManager.ClearLogs();
            Properties.Settings.Default.CurrentShiftNumber = 1;
            Properties.Settings.Default.Save();
            ClearFormFields();
            RefreshTreeView();
            selectedLogEntry = null;
        }

        
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            RefreshTreeView();
            selectedLogEntry = null;
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
                    else if (option is UpgradeOptionUnlisted unlisted)
                    {
                        if (unlisted.UpgradeInput.Text == upgrade.UpgradeName)
                        {
                            unlisted.UpgradeInput.Enabled = false;
                            unlisted.UpgradePrice.Enabled = false;
                            unlisted.TypeInput.Enabled = false;
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
            if (selectedLogEntry != null)
            {
                logManager.DeleteLog(selectedLogEntry);
                ClearFormFields();
                RefreshTreeView();
            }

            selectedLogEntry = null;
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
                selectedLogEntry = e.Node.Tag as LogEntry;

                if (selectedLogEntry != null)
                {
                    ClearFormFields();

                    customerInput.Text = selectedLogEntry.CustomerName;
                    vehicleInput.Text = selectedLogEntry.Vehicle;
                    plateInput.Text = selectedLogEntry.LicensePlate;
                    employeeCheckbox.Checked = selectedLogEntry.IsEmployee;

                    foreach (var upgrade in selectedLogEntry.Upgrades)
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
                    UpdateUnbilledPrice(GetInstalledUpgrades());
                }
            }
            else
            {
                selectedLogEntry = null;
            }
        }
    }
}
