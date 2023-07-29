namespace LinkedList;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Linked List Implementation");
        LinkedList<int> myList = new LinkedList<int>();
        myList.AddLast(56);
        myList.AddLast(30);
        myList.AddLast(70);
        //myList.Append(56);
        //myList.Append(30);
        //myList.Append(70);

        foreach(var ele in myList)
        {
            Console.Write(ele+" ");
        }

        Console.ReadLine();
    }
}

