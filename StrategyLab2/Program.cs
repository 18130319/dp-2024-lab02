using System.Text;

namespace StrategyLab2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Меню:\n1.Вывод лога в консоль\n2.Вывод лога в файл\n3.Вывод лога в файл капсом");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var consoleLogger = new Logger(new ConsoleLog());

                    string messageLevel = "";
                    string messageDescription = "";
                    Random random = new Random();

                    for (int i = 0; i < 21; i++)
                    {
                        int randomNumber = random.Next(0, 5);
                        DateTime now = DateTime.Now;

                        if (randomNumber == 0) { messageLevel = "TRACE"; messageDescription = "Детальная информация"; }
                        if (randomNumber == 1) { messageLevel = "INFO"; messageDescription = "Программа работает нормально"; }
                        if (randomNumber == 2) { messageLevel = "WARN"; messageDescription = "Предупреждение!"; }
                        if (randomNumber == 3) { messageLevel = "ERROR"; messageDescription = "Ошибка!!"; }
                        if (randomNumber == 4) { messageLevel = "FATAL"; messageDescription = "Разрушительная ошибка!!!"; }

                        StringBuilder sb = new StringBuilder();
                        sb = sb.Append(now.ToString("yyyy-MM-dd HH-mm-ss")).Append(" [" + messageLevel + "] ").Append(messageDescription);
                        string messageToLog = sb.ToString();

                        consoleLogger.Log(messageToLog);
                        //Thread.Sleep(1000);
                    }
                    break;
                case 2:
                    Console.WriteLine("Укажите путь для сохранения файла:");
                    string pathToLog = Console.ReadLine();

                    var fileLogger = new Logger(new FileLog(pathToLog));

                    string messageLevel2 = "";
                    string messageDescription2 = "";
                    Random random2 = new Random();

                    for (int i = 0; i < 21; i++)
                    {
                        int randomNumber2 = random2.Next(0, 5);
                        DateTime now2 = DateTime.Now;

                        if (randomNumber2 == 0) { messageLevel2 = "TRACE"; messageDescription2 = "Детальная информация"; }
                        if (randomNumber2 == 1) { messageLevel2 = "INFO"; messageDescription2 = "Программа работает нормально"; }
                        if (randomNumber2 == 2) { messageLevel2 = "WARN"; messageDescription2 = "Предупреждение!"; }
                        if (randomNumber2 == 3) { messageLevel2 = "ERROR"; messageDescription2 = "Ошибка!!"; }
                        if (randomNumber2 == 4) { messageLevel2 = "FATAL"; messageDescription2 = "Разрушительная ошибка!!!"; }

                        StringBuilder sb2 = new StringBuilder();
                        sb2 = sb2.Append(now2.ToString("yyyy-MM-dd HH-mm-ss")).Append(" [" + messageLevel2 + "] ").Append(messageDescription2);
                        string messageToLog2 = sb2.ToString();

                        fileLogger.Log(messageToLog2);
                        //Thread.Sleep(1000);
                    }

                    break;
                case 3:
                    Console.WriteLine("Укажите путь для сохранения файла:");
                    string pathToLog2 = Console.ReadLine();

                    var fileLoggerUp = new Logger(new FileLogUpper(pathToLog2));

                    string messageLevel3 = "";
                    string messageDescription3 = "";
                    Random random3 = new Random();

                    for (int i = 0; i < 21; i++)
                    {
                        int randomNumber3 = random3.Next(0, 5);
                        DateTime now3 = DateTime.Now;

                        if (randomNumber3 == 0) { messageLevel3 = "TRACE"; messageDescription3 = "Детальная информация"; }
                        if (randomNumber3 == 1) { messageLevel3 = "INFO"; messageDescription3 = "Программа работает нормально"; }
                        if (randomNumber3 == 2) { messageLevel3 = "WARN"; messageDescription3 = "Предупреждение!"; }
                        if (randomNumber3 == 3) { messageLevel3 = "ERROR"; messageDescription3 = "Ошибка!!"; }
                        if (randomNumber3 == 4) { messageLevel3 = "FATAL"; messageDescription3 = "Разрушительная ошибка!!!"; }

                        StringBuilder sb3 = new StringBuilder();
                        sb3 = sb3.Append(now3.ToString("yyyy-MM-dd HH-mm-ss")).Append(" [" + messageLevel3 + "] ").Append(messageDescription3);
                        string messageToLog2 = sb3.ToString();

                        fileLoggerUp.Log(messageToLog2);
                        //Thread.Sleep(1000);
                    }

                    break;
                default:
                    Console.WriteLine("Нельзя такое вводить");
                    break;
            }
        }
    }
}