using System;
using System.IO;

public void log_message(string logFile, string message, string level)
{
    // Get the current timestamp
    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

    // Create the log entry
    string logEntry = $"[{timestamp}] [{level}] {message}";

    // Write the log entry to the file
    using (StreamWriter writer = new StreamWriter(logFile, true))
    {
        writer.WriteLine(logEntry);
    }
}