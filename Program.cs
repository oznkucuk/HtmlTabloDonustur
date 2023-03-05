using System.Text.Json;

var jsoncevir = File.OpenText("movies.json");
var movies = JsonSerializer.Deserialize<List<Movie>>(jsoncevir.ReadToEnd(), new JsonSerializerOptions
{ PropertyNameCaseInsensitive = true });


