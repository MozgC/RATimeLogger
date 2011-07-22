using System.IO;
using System.Text;
using TimeLogger.Properties;

namespace TimeLogger
{
	class FileHelper
	{
		public static void CreateLogFileIfNotExists()
		{
			string dir = Path.GetDirectoryName(Settings.Default.LogFilePath);
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);

			if (!File.Exists(Settings.Default.LogFilePath))
			{
				var logFileWriter = new StreamWriter(Settings.Default.LogFilePath, false, new UTF8Encoding(true));
				logFileWriter.Dispose();
			}
		}
	}
}
