using System.Collections.Generic;

namespace NLog.Tests
{
	public class TestHelper
	{
		private readonly Logger logger;

		public TestHelper()
		{
			logger = LogManager.GetCurrentClassLogger();
		}

		public IEnumerable<int> GetTestData()
		{
			List<int> testData = new();

			for (var i = 0; i < 10; i++)
			{
				logger.Info("This message is ignored when is called from NUnit test data provider {i}", i);
				testData.Add(i);
			}

			return testData;
		}
	}
}