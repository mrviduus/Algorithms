namespace Queue;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Hello");
        queue.Enqueue("world");

        System.Console.WriteLine(queue.Peek());
        System.Console.WriteLine(queue.Dequeue());
        System.Console.WriteLine(queue.Dequeue());

        System.Console.ReadKey();

    }
}
