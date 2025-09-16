namespace TaskManagment1;

using System.Threading.Tasks;

class Program
{
    public static void Main(string[] args)
    {
        Task task = Task.Run(() => Console.WriteLine("Foo"));
        task.Wait();

       
        
    }
}
