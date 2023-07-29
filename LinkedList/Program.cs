namespace LinkedList;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Linked List Implementation");
        LinkedList myList = new LinkedList();
        myList.Add(56);
        myList.Add(30);
        myList.Add(70);
        myList.DisplayList();
        Console.ReadLine();
    }
}

