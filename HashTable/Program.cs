namespace HashTable;

class Program
{
    static void Main(string[] args)
    {
        HashTable<string, string> table = new HashTable<string, string>(10);

        table.Add("testKey", "testValue");
        table.Add("greetings", "Hello world !!!");
        table.Add("phone", "0000000");
        table.Add("testKey", "testValue");
        table.Add("greetings", "Hello world !!!");
        table.Add("phone", "0000000");
        table.Add("testKey", "testValue");
        table.Add("greetings", "Hello world !!!");
        table.Add("phone", "0000000");
        table.Add("testKey", "testValue");
        table.Add("greetings", "Hello world !!!");
        table.Add("phone", "0000000");

        var test = table.GetValue("testKey");
        System.Console.WriteLine($"before remove: {test}");

        table.Remove("testKey");

        var test2 = table.GetValue("testKey");
        System.Console.WriteLine($"after remove: {test2}");
        table.Clear();

        System.Console.ReadKey();

    }
}


