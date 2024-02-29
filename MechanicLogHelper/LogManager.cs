using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicLogHelper
{
    public class LogEntry
    {
        public string CustomerName { get; set; }
        public string Vehicle { get; set; }
        public string LicensePlate { get; set; }
        public bool IsEmployee { get; set; }
        public Dictionary<string, int> Upgrades { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
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
            return JsonConvert.DeserializeObject<List<LogEntry>>(json);
        }

        public void SaveLogs(List<LogEntry> logs)
        {
            string json = JsonConvert.SerializeObject(logs);
            File.WriteAllText(logFilePath, json);
        }

        public void ClearLogs()
        {
            File.WriteAllText(logFilePath, String.Empty);
        }

        public void DeleteLog(LogEntry logEntryToDelete)
        {
            var logs = LoadLogs();
            logs.RemoveAll(logEntry => logEntry.CustomerName == logEntryToDelete.CustomerName && logEntry.Date == logEntryToDelete.Date);
            SaveLogs(logs);
        }
    }

    public class UpgradeOption
    {
        public CheckBox Checkbox { get; set; }
        public TextBox InputField { get; set; }
        public string UpgradeName { get; set; }
    }
}
