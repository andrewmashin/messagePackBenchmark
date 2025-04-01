using BenchmarkDotNet.Attributes;
using Bogus;
using MemoryPack;
using MessagePack;
using messagePackBenchmark.Dtos;

namespace messagePackBenchmark;

[MemoryDiagnoser]
public class Benchmark
{
    private DtoWithIntKeys _dtoWithIntKeys = new DtoWithIntKeys();
    private DtoWithStringKeys _dtoWithStringKeys = new DtoWithStringKeys();
    private MemoryPackDto _dtoMemPack = new MemoryPackDto();

    private byte[] _dtoWithIntKeysBytes = [];
    private byte[] _dtoWithStringKeysBytes = [];
    private byte[] _dtoMemPackBytes = [];

    [GlobalSetup]
    public void Setup()
    {
        var faker = new Faker<IDto>()
            .StrictMode(true)
            .UseSeed(1234567890)
            .RuleForType(typeof(ulong), f => f.Random.ULong())
            .RuleForType(typeof(bool), f => f.Random.Bool())
            .RuleForType(typeof(string), f => f.Random.Utf16String())
            .RuleForType(typeof(int), f => f.Random.Int())
            .RuleForType(typeof(double), f => f.Random.Double())
            .RuleForType(typeof(List<string>), f => f.Make(f.Random.Number(10), () => f.Random.Utf16String()).ToList());

        faker.Populate(_dtoWithIntKeys);

        _dtoWithStringKeys = Mapper.Map(_dtoWithIntKeys);
        _dtoMemPack = Mapper.Map2(_dtoWithIntKeys);

        _dtoWithIntKeysBytes = MessagePackSerializer.Serialize(_dtoWithIntKeys);
        _dtoWithStringKeysBytes = MessagePackSerializer.Serialize(_dtoWithStringKeys);
        _dtoMemPackBytes = MemoryPackSerializer.Serialize(_dtoMemPack);
    }

    [Benchmark]
    public byte[] SerializeInt()
    {
        return MessagePackSerializer.Serialize(_dtoWithIntKeys);
    }

    [Benchmark]
    public byte[] SerializeString()
    {
        return MessagePackSerializer.Serialize(_dtoWithStringKeys);
    }

    [Benchmark]
    public byte[] SerializeMemoryPack()
    {
        return MemoryPackSerializer.Serialize(_dtoMemPack);
    }

    [Benchmark]
    public DtoWithIntKeys DeSerializeInt()
    {
        return MessagePackSerializer.Deserialize<DtoWithIntKeys>(_dtoWithIntKeysBytes);
    }

    [Benchmark]
    public DtoWithStringKeys DeSerializeString()
    {
        return MessagePackSerializer.Deserialize<DtoWithStringKeys>(_dtoWithStringKeysBytes);
    }

    [Benchmark]
    public MemoryPackDto? DeSerializeMemPack()
    {
        return MemoryPackSerializer.Deserialize<MemoryPackDto>(_dtoMemPackBytes);
    }
}