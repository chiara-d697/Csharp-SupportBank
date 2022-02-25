namespace SupportBank
{
    public class CsvLoader : IFileLoader
    {
        public string[] FileLoader(String fileName)
        {
           string[] lines = File.ReadAllLines(fileName);

           return lines;
        }

    }
}