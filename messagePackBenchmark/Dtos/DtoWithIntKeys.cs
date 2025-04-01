using MessagePack;

namespace messagePackBenchmark.Dtos;

[MessagePackObject]
public class DtoWithIntKeys : IDto
{
    [Key(0)]
    public ulong LegacyLinkId { get; set; }
    [Key(1)]
    public int BusinessType { get; set; }
    [Key(2)]
    public bool DisableDraftProduct { get; set; }
    [Key(3)]
    public string Email { get; set; } = string.Empty;
    [Key(4)]
    public string Website { get; set; } = string.Empty;
    [Key(5)]
    public bool EnableCall { get; set; }
    [Key(6)]
    public bool HideStockLabel { get; set; }
    [Key(7)]
    public bool UseBiggerCards { get; set; }
    [Key(8)]
    public string HeaderImage { get; set; } = string.Empty;
    [Key(9)]
    public string LogoImage { get; set; } = string.Empty;
    [Key(10)]
    public List<string> TagIds { get; set; } = [];
    [Key(11)]
    public List<string> Keywords { get; set; } = [];
    [Key(12)]
    public string PartnerId { get; set; } = string.Empty;
    [Key(13)]
    public int Coverage { get; set; }
    [Key(14)]
    public int AveragePreparationTime { get; set; }
    [Key(15)]
    public double AveragePrice { get; set; }
    [Key(16)]
    public double Discount { get; set; }
    [Key(17)]
    public bool HasInventory { get; set; }
    [Key(18)]
    public int PromoRanking { get; set; }
    [Key(19)]
    public bool HasBuyOneGetOne { get; set; }
    [Key(20)]
    public bool HasBundle { get; set; } = false;
    [Key(21)]
    public bool HasExclusiveOffers { get; set; }
    [Key(22)]
    public bool IsLocalMerchant { get; set; }
    [Key(23)]
    public int OrderDeliveryMode { get; set; }
    [Key(24)]
    public bool IsOwnDelivery { get; set; }
    [Key(25)]
    public bool OwnRiderTracking { get; set; }
    [Key(26)]
    public bool IsFeatured { get; set; }
    [Key(27)]
    public bool IsFavoriteGrocery { get; set; }
}