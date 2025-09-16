using System.Threading.Tasks;

namespace Await1;

class Program
{
    static async Task Main()
    {
        int result = await GetNumberAsync();
        Console.WriteLine(result);
    }
    static async Task<int> GetNumberAsync()
    {
        await Task.Delay(5000); // simulate async work (returns Task)
        return 42;
    }
}
