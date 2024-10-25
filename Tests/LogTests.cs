using NUnit.Framework.Internal;
using StrategyLab2;
using Logger = StrategyLab2.Logger;

namespace Tests
{
    public class LogTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestForLogConsole()
        {
            string testMessageToConsole = "�������� ��������� ��� �������";
            string testMessageToCompare = "�������� ��������� ��� �������";

            var consoleLogger = new Logger(new ConsoleLog());

            Assert.AreEqual(testMessageToConsole, testMessageToCompare);

            //consoleLogger.Log(testMessageToConsole);
        }

        [Test]
        public void TestForLogFile()
        {
            string testMessageToFile = "�������� ��������� ��� �����";
            string testMessageToCompare = "�������� ��������� ��� �����";

            var fileLogger = new Logger(new FileLog(@"C:\\����������\\log.txt"));

            Assert.AreEqual(testMessageToFile, testMessageToCompare);

            //fileLogger.Log(testMessageToFile);
        }

        [Test]
        public void TestForLogFileUpper()
        {
            string testMessageToFileUpper = "�������� ��������� ��� ����� � ������� ��������";
            string testMessageToCompare = "�������� ��������� ��� ����� � ������� ��������";

            var fileLoggerUpper = new Logger(new FileLogUpper(@"C:\\����������\\logUpper.txt"));

            Assert.AreEqual(testMessageToFileUpper, testMessageToCompare);

            //fileLoggerUpper.Log(testMessageToFileUpper.ToUpper());
        }
    }
}