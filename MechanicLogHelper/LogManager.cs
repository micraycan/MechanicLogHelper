using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MechanicLogHelper
{
    public class UpgradeInfo
    {
        public string UpgradeName { get; set; }
        public int UpgradeAmount { get; set; }
        public string UpgradeType { get; set; }
        public bool UpgradePaid { get; set; }
        public string UpgradeOption { get; set; }
    }

    public class LogEntry
    {
        public string CustomerName { get; set; }
        public string Vehicle { get; set; }
        public string LicensePlate { get; set; }
        public bool IsEmployee { get; set; }
        public List<UpgradeInfo> Upgrades { get; set; }
        public int TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public string Shop { get; set; }
        public int ShiftNumber { get; set; }
    }

    public class LogManager
    {
        private string logFilePath;

        public LogManager()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            logFilePath = Path.Combine(currentDirectory, "customerLog.json");
        }

        public List<LogEntry> LoadLogs()
        {
            if (!File.Exists(logFilePath)) return new List<LogEntry>();

            string json = File.ReadAllText(logFilePath);
            var log = JsonConvert.DeserializeObject<List<LogEntry>>(json);
            return log ?? new List<LogEntry>();
        }

        public void SaveLogs(List<LogEntry> logs)
        {
            string json = JsonConvert.SerializeObject(logs);
            File.WriteAllText(logFilePath, json);
        }

        public void ClearLogs()
        {
            File.WriteAllText(logFilePath, "[]");
        }

        public void DeleteLog(LogEntry logEntryToDelete)
        {
            var logs = LoadLogs();
            logs.RemoveAll(logEntry => logEntry.CustomerName == logEntryToDelete.CustomerName && logEntry.Date == logEntryToDelete.Date);
            SaveLogs(logs);
        }
    }

    public abstract class UpgradeOption
    {
        public string UpgradeName { get; set; }
        public string UpgradeType { get; set; }
    }

    public class UpgradeOptionDropdown : UpgradeOption
    {
        public MaterialComboBox UpgradeInput { get; set; }
        public Dictionary<int, int> Price { get; set; }

        public UpgradeOptionDropdown()
        {
            Price = new Dictionary<int, int>()
            {
                { 2, 3250 },
                { 3, 5500 },
                { 4, 9450 },
                { 5, 13250 },
                { 6, 18500 }
            };
        }
    }

    public class UpgradeOptionCheckbox : UpgradeOption
    {
        public MaterialCheckbox UpgradeInput { get; set; }
        public int Price { get; set; }
    }

    public class UpgradeOptionUnlisted : UpgradeOption
    {
        public MaterialTextBox UpgradeInput { get; set; }
        public MaterialTextBox UpgradePrice { get; set; }
        public MaterialComboBox TypeInput { get; set; }
    }
}
