namespace LinkedList;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Linked List Implementation");
        LinkedList myList = new LinkedList();
        myList.AddFirst(70);
        myList.AddFirst(30);
        myList.AddFirst(56);
        myList.DisplayList();
        Console.ReadLine();
    }
}

