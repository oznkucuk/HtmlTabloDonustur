using System.Text.Json;

var jsoncevir = File.OpenText("movies.json");
var movies = JsonSerializer.Deserialize<List<Movie>>(jsoncevir.ReadToEnd(), new JsonSerializerOptions
{ PropertyNameCaseInsensitive = true });

foreach (var item in movies)
{
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Title);
    Console.WriteLine(item.Rating);
    Console.WriteLine(item.Genre);
    Console.WriteLine(item.Duration);
}
