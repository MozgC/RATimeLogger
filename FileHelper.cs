using System.IO;
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
				StreamWriter logFileWriter = File.CreateText(Settings.Default.LogFilePath);
				logFileWriter.Dispose();
			}
		}
	}
}
