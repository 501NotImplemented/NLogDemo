using NLog.DemoApp;

namespace NLog.Console
{
	internal class Program
	{
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		private static void Main(string[] args)
		{
			Logger.Debug("Hello from logger!");

			System.Console.WriteLine("Hello from console!");

			var superClass = new SuperClass();
			superClass.Log();

			superClass.FailExecution();
		}
	}
}