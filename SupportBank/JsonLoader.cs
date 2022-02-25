using Newtonsoft.Json;

namespace SupportBank
{
    public class JsonLoader : IFileLoader
    {
        public string[] FileLoader(String fileName)
        {
            var list = JsonConvert.DeserializeObject<List<JsonTransaction>>(File.ReadAllText(fileName));

            string[] lines = new string[] {};
            foreach (JsonTransaction li in list) {
                String line = $"{li.Date},{li.FromAccount},{li.ToAccount},{li.Narrative},{li.Amount}";
                lines = lines.Concat(new string[] { line }).ToArray();
            }

            return lines;
        }
    }
}
