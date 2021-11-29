namespace NLog.Console
{
	internal class Program
	{
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();

		private static void Main(string[] args)
		{
			logger.Debug("Hello from logger!");

			System.Console.WriteLine("Hello from console!");
		}
	}
}