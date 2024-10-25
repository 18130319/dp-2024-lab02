namespace StrategyLab2
{
    public class FileLog : IStrategy
    {
        private string _filePath;

        public FileLog(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            try
            {
                using (var writer = new StreamWriter(_filePath, true))
                {
                    writer.WriteLine(message);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Отказано в доступе к файлу: {ex.Message}");
                Environment.Exit(1);

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Не удалось найти указанный путь: {ex.Message}");
                Environment.Exit(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в работе программы: {ex.Message}");
                Environment.Exit(1);
            }
        }
    }
}