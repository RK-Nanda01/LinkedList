﻿namespace LinkedList;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Linked List Implementation");
        LinkedList myList = new LinkedList();
        myList.Append(56);
        myList.Append(30);
        myList.Append(70);
        myList.DisplayList();
        Console.ReadLine();
    }
}

