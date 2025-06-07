
using System;
using System.Collections.Generic;
using System.IO;

public class ActivityLog
{
    private string _logFile = "activity_log.txt";

    public void LogActivity(string activityName)
    {
        if (!File.Exists(_logFile))
        {
            File.Create(_logFile).Close();
        }

        string logEntry = $"{DateTime.Now} - {activityName} activity performed.{Environment.NewLine}";
        File.AppendAllText(_logFile, logEntry);
    }

    public void ViewLog()
    {
        if (File.Exists(_logFile))
        {
            string logContent = File.ReadAllText(_logFile);
            Console.WriteLine(logContent);
        }
        else
        {
            Console.WriteLine("No log entries yet.");
        }
    }

    public Dictionary<string, int> GetActivityCounts()
    {
        Dictionary<string, int> activityCounts = new Dictionary<string, int>();

        if (File.Exists(_logFile))
        {
            string[] logEntries = File.ReadAllLines(_logFile);

            foreach (string entry in logEntries)
            {
                string activityName = entry.Split('-')[1].Trim().Split(' ')[0];

                if (activityCounts.ContainsKey(activityName))
                {
                    activityCounts[activityName]++;
                }
                else
                {
                    activityCounts.Add(activityName, 1);
                }
            }
        }

        return activityCounts;
    }
}
