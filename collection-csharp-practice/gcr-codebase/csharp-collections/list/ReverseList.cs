

class ReverseList
{
    static LinkedList<int> ReverseLinkedList(LinkedList<int> linkedList)
    {
        LinkedList<int> current = new LinkedList<int>();

        foreach(var item in linkedList)
        {
            current.AddFirst(item);
        }
        return current;
    }
    
    static void Main()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        list.Reverse();

        foreach (var item in list)
        {
            Console.Write(item+" ");
        }

        Console.WriteLine();

        LinkedList<int> linkedList = new LinkedList<int>();

        for (int i = 1; i <= 10; i++)
        {
            linkedList.AddLast(i);
        }

        linkedList= ReverseLinkedList(linkedList);

        foreach (var item in linkedList)
        {
            Console.Write(item+" ");
        }

    }

}