namespace Stack;

public class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(10);

        int res = stack.Pop();
        res = stack.Pop();
        res = stack.Peek();
        res = stack.Peek();
    }
}

