using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // init upgrade options
            upgradeOptions.Add(new UpgradeOption { Checkbox = armorCheckbox, InputField = armorAmountInput, UpgradeName = "Armor" });
            upgradeOptions.Add(new UpgradeOption { Checkbox = brakeCheckbox, InputField = brakeAmountInput, UpgradeName = "Brake" });

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
                        RefreshTreeView();
                    }
                }
            }
        }

        private bool IsInputValid()
        {
            List<string> errorMessages = new List<string>();

            if (string.IsNullOrWhiteSpace(customerNameInput.Text))
            {
                errorMessages.Add("Customer name is required.");
            }

            if (string.IsNullOrWhiteSpace(vehicleInput.Text))
            {
                errorMessages.Add("Vehicle is required.");
            }

            if (string.IsNullOrWhiteSpace(licenseInput.Text))
            {
                errorMessages.Add("License plate is required.");
            }

            if (!IsAtleastOneUpgradeSelected())
            {
                errorMessages.Add("At least one upgrade is required.");
            }

            if (!IsUpgradeInputValid())
            {
                errorMessages.Add("Installed upgrades must have a price value");
            }

            if (errorMessages.Any())
            {
                string errorMessage = string.Join("\n", errorMessages);
                MessageBox.Show(errorMessage);
                return false;
            }

            return true;
        }

        private void ClearFormFields()
        {
            customerNameInput.Text = string.Empty;
            vehicleInput.Text = string.Empty;
            licenseInput.Text = string.Empty;
            employeeCheckbox.Checked = false;
            // add upgrade field clearing
            foreach (UpgradeOption option in upgradeOptions)
            {
                option.Checkbox.Checked = false;
                option.InputField.Text = "";
            }
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
                    // add upgrade info later

                    foreach (UpgradeOption upgrade in upgradeOptions)
                    {
                        if (selectedLog.Upgrades.TryGetValue(upgrade.UpgradeName, out int value))
                        {
                            upgrade.Checkbox.Checked = true;
                            upgrade.InputField.Text = value.ToString();
                        }
                    }
                }
            }
        }

        private void ClearAllLogs_Click(object sender, EventArgs e)
        {
            logManager.ClearLogs();
        }

        private Dictionary<string, int> GetInstalledUpgrades()
        {
            Dictionary<string, int> installedParts = new Dictionary<string, int>();

            foreach (UpgradeOption upgrade in upgradeOptions)
            {
                if (upgrade.Checkbox.Checked)
                {
                    installedParts.Add(upgrade.UpgradeName, int.Parse(upgrade.InputField.Text));
                }
            }

            return installedParts;
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
