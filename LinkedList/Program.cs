namespace LinkedList;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Linked List Implementation");
        LinkedList myList = new LinkedList();
        myList.Append(56);
        myList.Append(70);
        myList.DisplayList();
        myList.InsertAtPosition(2, 30);
        Console.Write("\n");
        myList.DisplayList();
        Console.ReadLine();
    }
}

