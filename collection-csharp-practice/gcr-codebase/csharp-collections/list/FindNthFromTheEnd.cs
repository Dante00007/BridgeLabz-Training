class FindNthFromTheEnd
{
    static int NthFromTheEnd(LinkedList<int> linkedList, int n)
    {
        
        LinkedListNode<int> next = linkedList.First;
        LinkedListNode<int> current = linkedList.First;
        for (int i = 0; i < n; i++)
        {
            next = next.Next;
        }   
        while (next != null)
        {
            next = next.Next;
            current = current.Next;
        }
        return current.Value;
    } 
    static void Main(string[] args)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        for (int i = 1; i <= 10; i++)
        {
            linkedList.AddLast(i);
        }

        Console.WriteLine("{0} from the end in linked list is {1}",3,NthFromTheEnd(linkedList,3));
    }
}