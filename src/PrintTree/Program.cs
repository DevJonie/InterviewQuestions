

using TreeReusables;


Console.WriteLine($"Sum : {NodeExtensions.GetInMemoryBinaryTree().Sum()}");
Console.WriteLine($"Mul : {NodeExtensions.GetInMemoryBinaryTree().Multiply()}");
Console.WriteLine($"Mul : {new Node<int>(6).Multiply()}");


Console.Write("InOrder : ");
foreach (var item in NodeExtensions.GetInMemoryBinaryTree().ToInOrderList())
{
    Console.Write($"{item}, ");
}

Console.WriteLine();

Console.Write("PreOrder : ");
foreach (var item in NodeExtensions.GetInMemoryBinaryTree().ToPreOrderList())
{
    Console.Write($"{item}, ");
}

Console.WriteLine();

Console.Write("PostOrder : ");
foreach (var item in NodeExtensions.GetInMemoryBinaryTree().ToPostOrderList())
{
    Console.Write($"{item}, ");
}



 