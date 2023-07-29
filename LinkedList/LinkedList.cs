using System;
namespace LinkedList
{
	public class LinkedList
	{
		internal Node head;

        public void Add(int data)
		{
			Node node = new Node(data);
			if(this.head == null)	// No Elements in Linked List
			{
				this.head = node;

			}
			else
			{
				Node temp = head;
				while(temp.next!=null)
				{
					temp = temp.next;
				}

				temp.next = node;
				
			}
			Console.WriteLine($"New Node Added At the end of the list {data}");

		}

		public void DisplayList()
		{
			Node temp = this.head;
			while(temp!=null)
			{
				Console.Write($"{temp.data} ");
				temp = temp.next;
			}	
		}
	}
}

