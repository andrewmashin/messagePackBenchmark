using MemoryPack;

namespace messagePackBenchmark;

[MemoryPackable]
public partial class MemoryPackDto : IDto
{
    public ulong LegacyLinkId { get; set; }
    public int BusinessType { get; set; }
    public bool DisableDraftProduct { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public bool EnableCall { get; set; }
    public bool HideStockLabel { get; set; }
    public bool UseBiggerCards { get; set; }
    public string HeaderImage { get; set; } = string.Empty;
    public string LogoImage { get; set; } = string.Empty;
    public List<string> TagIds { get; set; } = [];
    public List<string> Keywords { get; set; } = [];
    public string PartnerId { get; set; } = string.Empty;
    public int Coverage { get; set; }
    public int AveragePreparationTime { get; set; }
    public double AveragePrice { get; set; }
    public double Discount { get; set; }
    public bool HasInventory { get; set; }
    public int PromoRanking { get; set; }
    public bool HasBuyOneGetOne { get; set; }
    public bool HasBundle { get; set; } = false;
    public bool HasExclusiveOffers { get; set; }
    public bool IsLocalMerchant { get; set; }
    public int OrderDeliveryMode { get; set; }
    public bool IsOwnDelivery { get; set; }
    public bool OwnRiderTracking { get; set; }
    public bool IsFeatured { get; set; }
    public bool IsFavoriteGrocery { get; set; }
}