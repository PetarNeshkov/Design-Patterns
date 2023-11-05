using PrototypeLibrary.WebPageScraper.Common;

namespace PrototypeLibrary.WebPageScraper;

public class WebPageScraper : ICustomCloneable
{
    private string title = string.Empty;
    private int numberOfHeaders;
    private int numberOfPictures;
    
    public WebPageScraper(string url)
    {
        // var client = new WebClient();
        // var page = client.DownloadString(url);
        Scrape("Fake page");
    }

    public void PrintPageContent()
    {
        Console.WriteLine(
            $"Title: {title}, " +
            $"Number of headers: {numberOfHeaders}, " +
            $"Number of pictures: {numberOfPictures} ");
    }
    
    public WebPageScraper Clone()
    {
        // If we have complex data type MemberwiseClone call wouldn't be enough.
        // MemberwiseClone creates a shallow copy of the current object (it goes just one level in the depth).
       return (MemberwiseClone() as WebPageScraper)!;
    }
    
    private void Scrape(string page)
    {
        title = "Fake title";
        numberOfHeaders = 3;
        numberOfPictures = 1;
    }
}