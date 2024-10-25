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
            string testMessageToConsole = "Тестовое сообщение для консоли";
            string testMessageToCompare = "Тестовое сообщение для консоли";

            var consoleLogger = new Logger(new ConsoleLog());

            Assert.AreEqual(testMessageToConsole, testMessageToCompare);

            //consoleLogger.Log(testMessageToConsole);
        }

        [Test]
        public void TestForLogFile()
        {
            string testMessageToFile = "Тестовое сообщение для файла";
            string testMessageToCompare = "Тестовое сообщение для файла";

            var fileLogger = new Logger(new FileLog(@"C:\\Файлообмен\\log.txt"));

            Assert.AreEqual(testMessageToFile, testMessageToCompare);

            //fileLogger.Log(testMessageToFile);
        }

        [Test]
        public void TestForLogFileUpper()
        {
            string testMessageToFileUpper = "Тестовое сообщение для файла в верхнем регистре";
            string testMessageToCompare = "Тестовое сообщение для файла в верхнем регистре";

            var fileLoggerUpper = new Logger(new FileLogUpper(@"C:\\Файлообмен\\logUpper.txt"));

            Assert.AreEqual(testMessageToFileUpper, testMessageToCompare);

            //fileLoggerUpper.Log(testMessageToFileUpper.ToUpper());
        }
    }
}