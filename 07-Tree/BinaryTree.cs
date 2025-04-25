
public class BinaryTree<T>
{
    public BinaryTreeNode<T>? Root { get; set; }
    public int Count { get; set; }

    private void TraversePreOrder(BinaryTreeNode<T>? node, List<BinaryTreeNode<T>> visited)
    {
        if (node == null) { return; } // end recursion
        visited.Add(node); // add current
        TraversePreOrder(node.Left, visited); // add left
        TraversePreOrder(node.Right, visited); // add right
    }

    private void TraverseInOrder(BinaryTreeNode<T>? node, List<BinaryTreeNode<T>> visited)
    {
        if (node == null) { return; } // end recursion
        TraverseInOrder(node.Left, visited); // add left
        visited.Add(node); // add current
        TraverseInOrder(node.Right, visited); // add right
    }

    private void TraversePostOrder(BinaryTreeNode<T>? node, List<BinaryTreeNode<T>> visited)
    {
        if (node == null) { return; } // end recursion
        TraversePostOrder(node.Left, visited); // add left
        TraversePostOrder(node.Right, visited); // add right
        visited.Add(node); // add current
    }

    public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
    {
        List<BinaryTreeNode<T>> nodes = [];
        if (Root == null) { return nodes; }
        switch (mode)
        {
            case TraversalEnum.PreOrder:
                TraversePreOrder(Root, nodes);
                break;
            case TraversalEnum.InOrder:
                TraverseInOrder(Root, nodes);
                break;
            case TraversalEnum.PostOrder:
                TraversePostOrder(Root, nodes);
                break;
        }
        return nodes;
    }

    public int GetHeight() => Root != null
        ? Traverse(TraversalEnum.PreOrder)
            .Max(n => n.GetHeight())
        : 0;
}

