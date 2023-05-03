using System.Numerics;

var list = new List<int> { 3, 5, 4, 7, 2, 1 };

Node<int>? root = null;
foreach (var item in list)
{
    root = Node<int>.Insert(root, item);
}

var levelOrder = Node<int>.LevelOrder(root);
foreach (var item in levelOrder)
{
    Console.Write($"{item} ");
}


class Node<T> where T : INumber<T>
{
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }
    public T Data { get; }
    public Node(T data)
    {
        Data = data;
    }


    public static Node<T> Insert(Node<T>? root, T data)
    {
        if (root == null)
        {
            return new Node<T>(data);
        }

        Node<T> cur;
        if (data <= root.Data)
        {
            cur = Insert(root.Left, data);
            root.Left = cur;
        }
        else
        {
            cur = Insert(root.Right, data);
            root.Right = cur;
        }
        return root;
    }

    public static T[] LevelOrder(Node<T>? root)
    {
        if (root == null)
        {
            return Array.Empty<T>();
        }

        var list = new List<T>();
        var queue = new Queue<Node<T>>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            var node = queue.Dequeue();
            list.Add(node.Data);

            if (node.Left is not null)
            {
                queue.Enqueue(node.Left);
            }
            if (node.Right is not null)
            {
                queue.Enqueue(node.Right);
            }
        }
        return list.ToArray();
    }
}
