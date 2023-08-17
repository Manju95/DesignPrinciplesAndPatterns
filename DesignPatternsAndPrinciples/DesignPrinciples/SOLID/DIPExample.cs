using System;
using DotnetTraining.DesignPrinciples.SOLID.Interfaces;

namespace DotnetTraining.SOLID
{
	public class DataExport_DIPExample
	{
        // can use either of one loggers without changing code, by sending different instance
        ExceptionLoger logger = new ExceptionLoger(new FileLogger());

		public void ExportDataToFiles()
        {
            try
            {
                // Some data transfer going on
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
            }
        }
	}

    public class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {
            // Code to log the message in file
        }
    }

    public class DBLogger : ILogger
    {
        public void LogMessage(string message)
        {
            // Code to log the message in DB
        }
    }

    public class ExceptionLoger
    {
        private readonly ILogger _logger;

        public ExceptionLoger(ILogger logger)
        {
            _logger = logger;
        }

        public void LogException(Exception ex)
        {
            string message = GetUserReadbleMessage(ex);
            _logger.LogMessage(message);
        }

        private string GetUserReadbleMessage(Exception ex)
        {
            string message = ex.Message;
            return message;
        }
    }
}