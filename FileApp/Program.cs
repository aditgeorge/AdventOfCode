using System.Text.Json;

namespace FileApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"../../../Assets/README.md";
            //string filePath = @"../../../Assets/Sample.txt";
            string text = File.ReadAllText(Directory.GetCurrentDirectory()+"//"+filePath);
            Console.WriteLine(text);
            ApiBody apiBody = new ApiBody() { text = text, mode = "markdown" };
            string jsonString = JsonSerializer.Serialize(apiBody);
            string fileName = "Output.json";
            File.WriteAllText(fileName, jsonString);
        }
    }
    public class ApiBody
    {
        public string text { get; set; }
        public string mode { get; set; }
    }
}