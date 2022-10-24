using System.Numerics;

namespace TreeReusables;

public interface INode<T>
{
    public T Data { get; }
    public INode<T>? Left { get; }
    public INode<T>? Right { get; }
}

public record Node<T>(T Data, INode<T>? Left = null, INode<T>? Right = null) : INode<T>;

public static class NodeExtensions
{
    public static INode<int> GetInMemoryBinaryTree()
        => new Node<int>(Data: 7,
            Left: new Node<int>(Data: 6,
                Left: new Node<int>(Data: 5),
                Right: new Node<int>(Data: 7)),
            Right: new Node<int>(Data: 8,
                Left: new Node<int>(Data: 9),
                Right: new Node<int>(Data: 10)));

    public static T Sum<T>(this INode<T>? node)
        where T : INumber<T>
    {
        T result = T.AdditiveIdentity;

        if (node is null)
            return result;

        InOrder(node);
        return result;

        void InOrder(INode<T>? node)
        {
            if (node is null)
                return;

            InOrder(node.Left);
            result += node.Data;
            InOrder(node.Right);
        }
    }
    
    public static T Multiply<T>(this INode<T>? node)
        where T : INumber<T>
    {
        T result = T.MultiplicativeIdentity;

        if (node is null)
            return result;

        InOrder(node);
        return result;

        void InOrder(INode<T>? node)
        {
            if (node is null)
                return;

            InOrder(node.Left);
            result *= node.Data;
            InOrder(node.Right);
        }
    }

    public static IEnumerable<T> ToInOrderList<T>(this INode<T>? node)
    {
        if (node is null)
            return Enumerable.Empty<T>();

        var list = new List<T>();
        InOrder(node);
        return list;

        void InOrder(INode<T>? node)
        {
            if (node is null)
                return;

            InOrder(node.Left);
            list.Add(node.Data);
            InOrder(node.Right);
        }
    }

    public static IEnumerable<T> ToPreOrderList<T>(this INode<T>? node)
    {
        if (node is null)
            return Enumerable.Empty<T>();

        var list = new List<T>();
        PreOrder(node);
        return list;

        void PreOrder(INode<T>? node)
        {
            if (node is null)
                return;

            list.Add(node.Data);
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
    }

    public static IEnumerable<T> ToPostOrderList<T>(this INode<T>? node)
    {
        if (node is null)
            return Enumerable.Empty<T>();

        var list = new List<T>();
        PostOrder(node);
        return list;

        void PostOrder(INode<T>? node)
        {
            if (node is null)
                return;

            PostOrder(node.Left);
            PostOrder(node.Right);
            list.Add(node.Data);
        }
    }

    public static bool HasAtleastOneChild<T>(this INode<T>? node)
        => node.HasLeftChild() || node.HasRightChild();

    public static bool HasLeftChild<T>(this INode<T>? node)
        => node?.Left is not null;

    public static bool HasRightChild<T>(this INode<T>? node)
        => node?.Right is not null;



}