using eraa.Data;

namespace EFCoreCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using BikeStores532Context db = new BikeStores532Context();

            Console.WriteLine("Database Ready");
        }
    }
}