using System.Collections.Generic;

using NLog.DemoApp;

using NUnit.Framework;

namespace NLog.Tests
{
	[TestFixture]
	[Parallelizable(ParallelScope.All)]
	public class DemoTestFixture
	{
		private static readonly ClassWithLoggingInside ClassWithLoggingInside = new();

		private static readonly TestHelper TestHelper = new();

		private readonly Logger logger = LogManager.GetCurrentClassLogger();

		[Test]
		[TestCaseSource(nameof(GetTestData))]
		public void LoggingFromTestDataSourceIsIgnored(int i)
		{
			Assert.DoesNotThrow(() => ClassWithLoggingInside.Log());
			logger.Debug("Message from test fixture {i}", i);
		}

		[Test]
		public void LoggingIsShown()
		{
			Assert.DoesNotThrow(() => TestHelper.GetTestData());
		}

		private static IEnumerable<int> GetTestData()
		{
			IEnumerable<int> testData = TestHelper.GetTestData();

			foreach (int i in testData) yield return i;
		}
	}
}