namespace BinaryTree;

class Program
{

    static void Main(string[] args)
    {
        BinaryTree<int> instanse = new BinaryTree<int>();

        instanse.Add(8);            //      8
        instanse.Add(5);            //    /   \
        instanse.Add(12);           //   5     12 
        instanse.Add(3);            //  / \   /   \
        instanse.Add(7);            // 3   7 10    15
        instanse.Add(10);           //
        instanse.Add(15);           //


        System.Console.WriteLine(instanse.Contains(7));//true
        System.Console.WriteLine(instanse.Contains(100));//false

        //instanse.InOrderTraversal(); //3 5 7 8 12 10 15
        //instanse.PostOrderTraversal(); //3 7 5 10 15 12 8
        //instanse.PreOrderTraversal(); //8 5 3 7 12 10 15



        System.Console.ReadKey();
    }

}