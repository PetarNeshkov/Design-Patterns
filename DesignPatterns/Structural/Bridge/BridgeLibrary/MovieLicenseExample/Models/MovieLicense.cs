using BridgeLibrary.MovieLicenseExample.Models.Enums;

namespace BridgeLibrary.MovieLicenseExample.Models;

/// <summary>
/// We can use enums for alternative implementation of the Bridge design pattern.
/// For more details see Vladimir Khorikov's course:
/// https://app.pluralsight.com/library/courses/design-patterns-c-sharp-bridge
/// </summary>
public class MovieLicense
{
    private readonly Discount discount;
    private readonly LicenseType  licenseType;
    private readonly SpecialOffer specialOffer;
    
    public MovieLicense(
        string movie,
        DateTime purchaseTime,
        Discount discount,
        LicenseType licenseType,
        SpecialOffer specialOffer = SpecialOffer.None)
    {
        Movie = movie;
        PurchaseTime = purchaseTime;

        this.discount = discount;
        this.licenseType = licenseType;
        this.specialOffer = specialOffer;
    }
    
    public string Movie { get; }
    public DateTime PurchaseTime { get; }
    
    public void Print()
    {
        Console.WriteLine($"Movie: {Movie}");
        Console.WriteLine($"Price: ${GetPrice():0.00}");
        Console.WriteLine($"Valid for: {GetValidFor()}");

        Console.WriteLine();
    }
    
    public DateTime? GetExpirationDate()
    {
        var expirationDate = GetBaseExpirationDate();
        var extensionPeriod = GetSpecialOfferExtension();

        return expirationDate?.Add(extensionPeriod);
    }
    
    private decimal GetPrice()
    {
        var discountPercentage = GetDiscountPercentage();
        var multiplier = 1 - (discountPercentage / 100m);

        return GetBasePrice() * multiplier;
    }

    private int GetDiscountPercentage() 
        => discount switch
        {
            Discount.None => 0,
            Discount.EarlyPayment => 10,
            Discount.Senior => 20,
            _ => throw new ArgumentOutOfRangeException(),
        };
    
    private decimal GetBasePrice()
        => licenseType switch
        {
            LicenseType.OneDay => 10,
            LicenseType.SevenDays => 60,
            LicenseType.LifeLong => 150,
            _ => throw new ArgumentOutOfRangeException(),
        };

    private string GetValidFor()
    {
        var expirationDate = GetExpirationDate();
        if (expirationDate == null)
        {
            return "Forever";
        }

        var timeSpan = expirationDate.Value - DateTime.Now;
        return $"{timeSpan.Days}d {timeSpan.Hours}h {timeSpan.Minutes}m";
    }
    
    private DateTime? GetBaseExpirationDate()
        => licenseType switch
        {
            LicenseType.OneDay => PurchaseTime.AddDays(1),
            LicenseType.SevenDays => PurchaseTime.AddDays(7),
            LicenseType.LifeLong => null,
            _ => throw new ArgumentOutOfRangeException(),
        };

    private TimeSpan GetSpecialOfferExtension() 
        => specialOffer switch
        {
            SpecialOffer.None => TimeSpan.Zero,
            SpecialOffer.OneDayExtension => TimeSpan.FromDays(1),
            SpecialOffer.SevenDaysExtension => TimeSpan.FromDays(7),
            _ => throw new ArgumentOutOfRangeException(),
        };
}