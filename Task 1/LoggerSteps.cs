using System;
using System.IO;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger;

namespace LogMessageSteps
{
    [Binding]
    public class LogMessageSteps
    {
        private string logFile;
        private string message;
        private string level;
        private string logEntry;

        public LogMessageSteps()
        {
            Logger log = new Logger();
        }

        [Given(@"a log file named '(.*)'")]
        public void GivenALogFileNamed(string fileName)
        {
            logFile = fileName;
        }

        [When(@"I call the log_message function with the log file, message '(.*)', and level '(.*)'")]
        public void WhenICallTheLogMessageFunctionWithTheLogFileMessageAndLevel(string logMessage, string logLevel)
        {
            message = logMessage;
            level = logLevel;
            logEntry = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] [{level}] {message}";

            log.log_message(logFile, message, level);
        }

        [Then(@"the log file should contain a log entry with the timestamp, level '(.*)', and message '(.*)'")]
        public void ThenTheLogFileShouldContainALogEntryWithTheTimestampLevelAndMessage(string expectedLevel, string expectedMessage)
        {
            string lastLogEntry = GetLastLogEntry(logFile);

            // Assert that the last log entry matches the expected level and message
            Assert.AreEqual($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] [{expectedLevel}] {expectedMessage}", lastLogEntry);
        }

        [Then(@"the log file should contain the new log entry")]
        public void ThenTheLogFileShouldContainTheNewLogEntry()
        {
            string logEntries = GetAllLogEntries(logFile);

            // Assert that the log entries contain the new log entry
            Assert.IsTrue(logEntries.Contains(logEntry));
        }

        // Helper method to read the last log entry from the file
        private string GetLastLogEntry(string logFile)
        {
            string[] logEntries = File.ReadAllLines(logFile);
            return logEntries[logEntries.Length - 1];
        }

        // Helper method to read all log entries from the file
        private string GetAllLogEntries(string logFile)
        {
            return File.ReadAllText(logFile);
        }
    }
}