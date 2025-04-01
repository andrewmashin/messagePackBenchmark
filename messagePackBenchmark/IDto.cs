
namespace messagePackBenchmark;

public interface IDto
{
    int AveragePreparationTime { get; set; }
    double AveragePrice { get; set; }
    int BusinessType { get; set; }
    int Coverage { get; set; }
    bool DisableDraftProduct { get; set; }
    double Discount { get; set; }
    string Email { get; set; }
    bool EnableCall { get; set; }
    bool HasBundle { get; set; }
    bool HasBuyOneGetOne { get; set; }
    bool HasExclusiveOffers { get; set; }
    bool HasInventory { get; set; }
    string HeaderImage { get; set; }
    bool HideStockLabel { get; set; }
    bool IsFavoriteGrocery { get; set; }
    bool IsFeatured { get; set; }
    bool IsLocalMerchant { get; set; }
    bool IsOwnDelivery { get; set; }
    List<string> Keywords { get; set; }
    ulong LegacyLinkId { get; set; }
    string LogoImage { get; set; }
    int OrderDeliveryMode { get; set; }
    bool OwnRiderTracking { get; set; }
    string PartnerId { get; set; }
    int PromoRanking { get; set; }
    List<string> TagIds { get; set; }
    bool UseBiggerCards { get; set; }
    string Website { get; set; }
}