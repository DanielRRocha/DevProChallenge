Feature: Log Message

@logTest
@TC_0001
Scenario: Write log message with level "INFO"_0001
    Given a log file named "application.log"
    When I call the log_message function with the log file, message "User logged in", and level "INFO"
    Then the log file should contain a log entry with the timestamp, level "INFO", and message "User logged in"

@logTest
@TC_0002
Scenario: Write log message with level "WARNING"_0002
    Given a log file named "application.log"
    When I call the log_message function with the log file, message "Failed login attempt", and level "WARNING"
    Then the log file should contain a log entry with the timestamp, level "WARNING", and message "Failed login attempt"

@logTest
@TC_0003
Scenario: Write log message with level "ERROR"_0003
    Given a log file named "application.log"
    When I call the log_message function with the log file, message "Server side error", and level "ERROR"
    Then the log file should contain a log entry with the timestamp, level "ERROR", and message "Server side error"

@logTest
@TC_0004
Scenario: Append log entries to existing log file_0004
    Given a log file named "application.log" with existing log entries
    When I call the log_message function with the log file, message "This is a new log entry", and level "INFO"
    Then the log file should contain the new log entry