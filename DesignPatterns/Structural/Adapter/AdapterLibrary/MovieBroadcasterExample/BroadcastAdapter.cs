using System.Xml.Linq;
using Newtonsoft.Json;

namespace AdapterLibrary.MovieBroadcasterExample;

/// <summary>
/// There is no way to pass an xDocument from the registry to the third party broadcaster,
/// so we need to create the adapter, which will make these two parties work together.
/// </summary>
public class BroadcastAdapter : IBroadcaster
{
    private readonly MovieRegistry movieRegistry;
    private readonly ThirdPartyBroadcaster thirdPartyBroadcaster;
    public BroadcastAdapter(MovieRegistry movieRegistry)
    {
        this.movieRegistry = movieRegistry;
        thirdPartyBroadcaster = new ThirdPartyBroadcaster();
    }
    
    public void BroadcastToExternalPartners()
    {
        var jsonMovies = ConvertRegistryMoviesToJson();
        thirdPartyBroadcaster.Broadcast(jsonMovies);
    }

    private string ConvertRegistryMoviesToJson()
    {
        XDocument xmlMovies = movieRegistry.GetAll();
        Console.WriteLine("Movies from the internal registry...");
        Console.WriteLine(xmlMovies);

        IEnumerable<Movie> modelMovies = xmlMovies
            .Element("Movies")!
            .Elements("Movie")
            .Select(movie =>
            {
                string name = movie.Attribute(nameof(Movie.Name))?.Value ?? "";
                DateTime releaseDate = DateTime.TryParse(movie.Attribute(nameof(Movie.ReleaseDate))?.Value, out var date) ? date : DateTime.MinValue;
                double rating = double.TryParse(movie.Attribute(nameof(Movie.Rating))?.Value, out var parsedRating) ? parsedRating : 0.0;

                return new Movie
                {
                    Name = name,
                    ReleaseDate = releaseDate,
                    Rating = rating,
                };
            });

        string jsonMovies = JsonConvert.SerializeObject(modelMovies, Formatting.Indented);
        Console.WriteLine("\nMovies from the internal registry are converted to JSON format");
        Console.WriteLine(jsonMovies);

        return jsonMovies;
    }
}