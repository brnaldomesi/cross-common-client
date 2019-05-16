using System;
using System.IO;
using System.Text;

using Snappy.Common.Helpers;

namespace Snappy.Common.Client.Helpers
{
    public class ClientExceptionHelper
    {
        private void AppendException(Exception ex, StringBuilder sb, int pad = 13)
        {
            sb.Append("Exception Message > " + ex.Message);
            sb.Append(Environment.NewLine);

            if (ex.StackTrace.IsNotEmpty())
            {
                sb.Append("StackTrace > ");
                sb.Append(ex.StackTrace);
                sb.Append(Environment.NewLine);
            }

            sb.Append(string.Empty.PadLeft(pad, '*'));
            sb.Append(Environment.NewLine);
        }

        public void LogException(Exception exception, string rootPath)
        {
            var logText = new StringBuilder(Environment.NewLine);

            logText.Append(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
            logText.Append(Environment.NewLine);

            AppendException(exception, logText);

            while (exception.InnerException != null)
            {
                AppendException(exception.InnerException, logText, 8);

                exception = exception.InnerException;
            }

            logText.Append(string.Empty.PadLeft(34, '*'));
            logText.Append(Environment.NewLine);

            File.AppendAllText(Path.Combine(rootPath, "logs", "log_" + DateTime.Today.ToString("yyyy-MM-dd-HH") + ".log"), logText.ToString());
        }
    }
}