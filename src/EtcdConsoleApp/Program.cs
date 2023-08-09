using dotnet_etcd;

namespace EtcdConsoleApp;

internal class Program
{
    public static async Task Main(string[] args)
    {
        var etcdClient = new EtcdClient("http://localhost:2379");

        Console.WriteLine("Putting key into ETCD...");

        await etcdClient.PutAsync("test/key1", "myValue 01");
        await etcdClient.PutAsync("test/key2", "myValue 02");
        
        var keys = await etcdClient.GetRangeAsync("test");

        foreach (var kv in keys.Kvs)
        {
            var kvKey = kv.Key.ToStringUtf8();
            var kvValue = kv.Value.ToStringUtf8();

            Console.WriteLine($"Key={kvKey} Value={kvValue}");
        }
    }
}
