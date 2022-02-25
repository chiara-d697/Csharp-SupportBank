namespace SupportBank
{
    public class JsonLoader : IFileLoader
    {
        public string[] FileLoader(String fileName)
        {

            var list = JsonConvert.DeserializeObject<List<JsonTransaction>>(File.ReadAllText(fileName));
           
            string[] lines = Array.ConvertAll(list, x => x.ToString());

            Console.WriteLine(lines[0]);

            return lines;
        }





    }
}