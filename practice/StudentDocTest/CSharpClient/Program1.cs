using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

class Program   
{
    static async Task Main(string[] args)
    {
        var studentData = new
        {
            name = "Kishan Chauhan",
            roll = "7",
            course = "B.Tech Computer Engineering",
            year = "2nd",
            reason = "visa application"
        };

        string json = JsonSerializer.Serialize(studentData);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        using var client = new HttpClient();
        var response = await client.PostAsync("http://localhost:5000/generate-doc", content);

        string result = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Response: {result}");
    }
}
