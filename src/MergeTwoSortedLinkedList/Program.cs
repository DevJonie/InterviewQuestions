
/*
    Given pointers to the heads of two sorted linked lists, merge them into a single, sorted linked list.
    Either head pointer may be null meaning that the corresponding list is empty.
*/



using System.Numerics;

static SinglyLinkedListNode<T>? MergeList<T>(
    SinglyLinkedListNode<T>? head1,
    SinglyLinkedListNode<T>? head2)
    where T : INumber<T>
{
    var head3 = new SinglyLinkedListNode<T>(T.AdditiveIdentity);
    var node = head3;

    while (head1 is not null && head2 is not null)
    {
        if (head1.Data < head2.Data)
        {
            node.Next = head1;
            head1 = head1.Next;
        }
        else
        {
            node.Next = head2;
            head2 = head2.Next;
        }
        node = node.Next;
    }

    if (head1 is not null)
    {
        node.Next = head1;
    }
    
    if (head2 is not null)
    {
        node.Next = head2;
    }

    return head3.Next;

}


record SinglyLinkedListNode<T>
{
    public SinglyLinkedListNode(T data)
    {
        Data = data;
    }

    public T Data { get; set; }
    public SinglyLinkedListNode<T>? Next { get; set; }
}