using BenchmarkDotNet.Running;
using messagePackBenchmark;

if (false)
{
    var benchmark = new Benchmark();
    benchmark.Setup();
    var intBytes = benchmark.SerializeInt();
    var strBytes = benchmark.SerializeString();
    var strMemPack = benchmark.SerializeMemoryPack();
    Console.WriteLine($"{nameof(intBytes)}={intBytes.Length:N0}");
    Console.WriteLine($"{nameof(strBytes)}={strBytes.Length:N0}");
    Console.WriteLine($"{nameof(strMemPack)}={strMemPack.Length:N0}");
    return;
}

BenchmarkRunner.Run<Benchmark>();