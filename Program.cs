using System.Text;
using System.Text.Json;

var jsoncevir = File.OpenText("movies.json");
var movies = JsonSerializer.Deserialize<List<Movie>>(jsoncevir.ReadToEnd(), new JsonSerializerOptions
{ PropertyNameCaseInsensitive = true });

// foreach (var item in movies)
// {
//     Console.WriteLine(item.Id);
//     Console.WriteLine(item.Title);
//     Console.WriteLine(item.Rating);
//     Console.WriteLine(item.Genre);
//     Console.WriteLine(item.Duration);
// }

var oz = new StringBuilder();

oz.Append("<Table>\n");
oz.Append("\t<th>\n");
oz.Append("\t\t<tr>\n");
oz.Append("\t\t\t<td>id<td>\n");
oz.Append("\t\t\t<td>title<td>\n");
oz.Append("\t\t\t<td>rating<td>\n");
oz.Append("\t\t\t<td>genre<td>\n");
oz.Append("\t\t\t<td>duration<td>\n");
oz.Append("\t\t<tr>\n");
oz.Append("\t<th>\n");
oz.Append("\t<tbody>\n");

foreach (var item in movies)
{
    oz.Append("\t\t<tr>\n");
    oz.Append($"\t\t\t<td>{item.Id}</td>\n");
    oz.Append($"\t\t\t<td>{item.Title}</td>\n");
    oz.Append($"\t\t\t<td>{item.Rating}</td>\n");
    oz.Append($"\t\t\t<td>{item.Genre}</td>\n");
    oz.Append($"\t\t\t<td>{item.Duration}</td>\n");
    oz.Append("\t\t</tr>\n");
}
oz.Append("</tbody>\n");
oz.Append("</Table>\n");

var yazim = Path.Combine(Environment.CurrentDirectory, "output.html");
File.WriteAllText(yazim, oz.ToString());
