namespace FileLoggerDisposableApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use FileLogger and dispose of it properly
            using (var logger = new FileLogger("log.txt"))
            {
                logger.Log("Log entry 1");
                logger.Log("Log entry 2");
                logger.Log("Log entry 3");
               
            } 

            Console.WriteLine("Log entries written. FileLogger instance disposed.");
        }
    }

    class FileLogger : IDisposable
    {
        private StreamWriter writer;   
        private bool disposed = false;

        public FileLogger(string filePath)
        {
            // Initialize StreamWriter instance
            writer = new StreamWriter(filePath, true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources
                    writer.Dispose();
                }

                // Dispose unmanaged resources
                // (none in this example)

                disposed = true;
            }
        }
        ~FileLogger()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            // Implement IDisposable pattern
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Log(string message)
        {
            // Write message to the file
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}