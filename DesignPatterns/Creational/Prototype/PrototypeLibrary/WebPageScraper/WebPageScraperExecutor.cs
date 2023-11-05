namespace PrototypeLibrary.WebPageScraper;

public class WebPageScraperExecutor
{
    public static void Execute()
    {
        Console.WriteLine("Web page scraper example");
        
        var scraper = new WebPageScraper("https://www.facebook.com/");
        scraper.PrintPageContent();
        
        var scraper2 = scraper.Clone();
        scraper2.PrintPageContent();
    }
}