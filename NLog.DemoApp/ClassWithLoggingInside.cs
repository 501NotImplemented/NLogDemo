namespace NLog.DemoApp
{
	public class ClassWithLoggingInside
	{
		private readonly Logger logger;

		public ClassWithLoggingInside()
		{
			logger = LogManager.GetCurrentClassLogger();
		}

		public void Log()
		{
			logger.Info("Hello from ClassWithLoggingInside");
		}
	}
}