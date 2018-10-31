using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Log
{
    public class LogWriter
    {
        StreamWriter log;
        FileStream fileStream = null;
        DirectoryInfo logDirInfo = null;
        FileInfo logFileInfo;
        private string logFilePath = "C:\\Logs\\";
                
        /// <summary>
        /// Default ctor
        /// </summary>
        public LogWriter() { }

        /// <summary>
        /// A method to write to the log file
        /// </summary>
        /// <param name="logMessage">the message that will be written in the log</param>
        public void LogWrite(string logMessage)
        {
            try
            {
                logFilePath = logFilePath + "Log-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt";
                logFileInfo = new FileInfo(logFilePath);
                logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
                if (!logDirInfo.Exists) logDirInfo.Create();
                if (!logFileInfo.Exists)
                {
                    fileStream = logFileInfo.Create();
                }
                else
                {
                    fileStream = new FileStream(logFilePath, FileMode.Append);
                }
                log = new StreamWriter(fileStream);
                log.WriteLine("{0} {1} Exception", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                log.WriteLine("{0}", logMessage);
                log.WriteLine("-------------------------------");
                log.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
