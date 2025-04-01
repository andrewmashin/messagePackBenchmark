using messagePackBenchmark.Dtos;
using Riok.Mapperly.Abstractions;

namespace messagePackBenchmark;

[Mapper]
public static partial class Mapper
{
    public static partial DtoWithStringKeys Map(DtoWithIntKeys source);
    public static partial MemoryPackDto Map2(DtoWithIntKeys source);
}