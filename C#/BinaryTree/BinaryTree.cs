namespace BinaryTree;

class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
{
    private BinaryTreeNode<T> root;

    private int count;

    public void Add(T value)
    {
        // First case: tree is empty

        if(root is null)
        {
            root = new BinaryTreeNode<T>(value);
        }

        // Second case: tree in not empty, we use recursive algorithms, searching place for adding node

        else
        {
            AddTo(root, value);
        }

        count++;
    }

    // Recursive algorithm

    private void AddTo(BinaryTreeNode<T> node, T value)
    {
        // First case: value of node less than curent value

        if(value.CompareTo(node.Value) < 0)
        {
            if(node.Left is null)
            {
                node.Left = new BinaryTreeNode<T>(value);
            }
            else
            {
                //repeat
                AddTo(node.Left, value);
            }
        }
        // Second case: value of adding node equals or more than current value
        else
        {
            // If right child absent - add him.

            if(node.Right is null)
            {
                node.Right = new BinaryTreeNode<T>(value);
            }
            else
            {
                AddTo(node.Right, value);
            }

        }
    }

    public bool Contains(T value)
    {
        BinaryTreeNode<T> parent;
        return FindWithParent(value, out parent) is not null;
    }

    private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
    {
        BinaryTreeNode<T> current = root;
        parent = null;

        while(current != null)
        {
            int result = current.CompareTo(value);

            if(result > 0)
            {
                parent = current;
                current = current.Left;
            }
            else if(result < 0)
            {
                parent = current;
                current = current.Right;
            }
            else
            {
                break;
            }

        }

        return current;
    }

    public void InOrderTraversal()
    {
        InOrderTraversal(root);
    }

    private void InOrderTraversal(BinaryTreeNode<T> node)
    {
        if(node.Left != null)
        {
            InOrderTraversal(node.Left);
        }

        System.Console.WriteLine(node.Value);

        if(node.Right != null)
        {
            InOrderTraversal(node.Right);
        }
    }
    public void PostOrderTraversal()
    {
        PostOrderTraversal(root);
    }

    private void PostOrderTraversal(BinaryTreeNode<T> node)
    {
        if(node.Left != null)
        {
            PostOrderTraversal(node.Left);
        }

        if(node.Right != null)
        {
            PostOrderTraversal(node.Right);
        }

        System.Console.WriteLine(node.Value);
    }

    public void PreOrderTraversal()
    {
        PreOrderTraversal(root);
    }

    private void PreOrderTraversal(BinaryTreeNode<T> node)
    {
        System.Console.WriteLine(node.Value);

        if(node.Left != null)
        {
            PreOrderTraversal(node.Left);
        }

        if(node.Right != null)
        {
            PreOrderTraversal(node.Right);
        }
    }

    public bool Remove(T value)
    {
        BinaryTreeNode<T> current;
        BinaryTreeNode<T> parent;

        current = FindWithParent(value, out parent);

        if(current is null)
        {
            return false;
        }

        count --;

        // node has not right child
        if(current.Right is null)
        {
            //remove root
            if(parent is null)
            {
                root = current.Left;
            }
            else
            {
                int result = parent.CompareTo(current.Value);

                if(result > 0)
                {
                    parent.Right = current.Left;
                }
                else if(result < 0)
                {
                    parent.Right = current.Left;
                }

            }

        }
        else if(current.Right.Left is null)
        {
            current.Right.Left = current.Left;

            if(parent is null)
            {
                root = current.Right;
            }
            else
            {
                int result = parent.CompareTo(current.Value);

                if(result > 0)
                {
                    parent.Left = current.Right;
                }
                else if(result < 0)
                {
                    parent.Right = current.Right;
                }
            }
        }
        else
        {
            BinaryTreeNode<T> leftmost = current.Right.Left;
            BinaryTreeNode<T> leftmostParent = current.Right;

            while(leftmost.Left is not null)
            {
                leftmostParent = leftmost;
                leftmost = leftmost.Left;
            }

            leftmostParent.Left = leftmost.Right;

            leftmost.Left = current.Left;
            leftmost.Right = current.Right;

            if(parent is null)
            {
                root = leftmost;
            }
            else
            {
                int result = parent.CompareTo(current.Value);

                if(result > 0)
                {
                    parent.Left = leftmost;
                }
                else if(result < 0)
                {
                    parent.Right = leftmost;
                }
            }
        }
        
        return true;
    }


    public int Count {get{return count;}}

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}