using NLog;

namespace SupportBank
{
    public class Configuration
    {
        public void SetLogFile (String fileName) 
        {
            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = fileName };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
                        
            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
                        
            // Apply config           
            NLog.LogManager.Configuration = config;
        }
    }
        
}