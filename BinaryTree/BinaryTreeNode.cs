namespace BinaryTree;

class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
{
    public BinaryTreeNode(TNode value)
    {
        Value = value;
    }

    public BinaryTreeNode<TNode> Left { get; set; }

    public BinaryTreeNode<TNode> Right { get; set; }

    public TNode Value{ get; private set; }

    /* Method compare value two nodes (Value and other), if Value less, we return less value
        if they equals, return 0
        if Value is more, return more
    */


    public int CompareTo(TNode other)
    {
        return Value.CompareTo(other);
    }

    public int CompareNode(BinaryTreeNode<TNode> other)
    {
        return Value.CompareTo(other.Value);
    }
}