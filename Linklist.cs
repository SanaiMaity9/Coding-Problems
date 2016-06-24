using System;

namespace Problems
{
	 class Node{
	    public object Data;
		public Node Next;
		public Node(object data, Node next){
			Data = data;
			Next = next;
		}
	}
	public class Linklist{
		private Node head;
		public Linklist(object data){
			head = new Node (data, null);
		}
		public void Add(object data){
			Node node = head;
			while(node.Next != null)
			{
				node = node.Next;
			}
			node.Next = new Node (data, null);
		}
		public void Display(){
			Node node = head;
			while(node.Next != null){
				Console.WriteLine (node.Data);
				node = node.Next;
			}
		}
		public void Delete(object data){
			var oldNode = head.Next;
			var current = head;
			while(oldNode != null){
				if(oldNode.Data == data){
					oldNode = current.Next;
				}
			}
			current = oldNode.Next;
			oldNode.Next = current;
			Console.WriteLine("Deleted");	
		}
	}

	public class Demo{
		public  void Main(string[] arg )
		{
			Linklist linklist = new Linklist (1);
			linklist.Add (2);
			linklist.Add (3);
			linklist.Add (4);
			linklist.Add (5);
			linklist.Display();
			linklist.Delete(2);
		}
	}
}
		                               