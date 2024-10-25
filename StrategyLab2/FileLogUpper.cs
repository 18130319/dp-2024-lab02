namespace StrategyLab2
{
    public class FileLogUpper : IStrategy
    {
        private string _filePath;

        public FileLogUpper(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            try
            {
                using (var writer = new StreamWriter(_filePath, true))
                {
                    writer.WriteLine(message.ToUpper());
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