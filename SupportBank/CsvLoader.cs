namespace SupportBank
{
    public class CsvLoader : IFileLoader
    {
        public string[] FileLoader(String fileName)
        // {
        //    string[] lines = File.ReadAllLines(fileName);

        //    return lines;
        // }
        {
           string[] lines = new string[] {};
           using (StreamReader sr = new StreamReader(fileName))
            {
                // Discard header row
                sr.ReadLine();            
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines = lines.Concat(new string[] { line }).ToArray();
                }
            }
            return lines;

        }

    }
}