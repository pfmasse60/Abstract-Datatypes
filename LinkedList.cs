using System;
					
public class Program
{
	public static void Main()
	{
		
		LinkedList myList = new LinkedList();
		
		myList.addNode(2);
		myList.addNode(1);
		myList.addNode(8);
		myList.addNode(5);
		myList.addNode(3);
		myList.printNode();
	
	}
	

}


public class Node
{
	public Node next;
	public Object data;
	
	public Node()
	{
		next = null;	
	}
		
	
}

public class LinkedList
{
	private Node head;
	private Node current;
	
	
	public LinkedList()
	{
		Node head = new Node();		
		head = null;
		Node current = head;
	}
	
	
	public void addNode(Object data)
	{
		Node newNode = new Node();
		
		newNode.data = data;
		newNode.next = current;
		current = newNode;
		
		
	}
	
	public void printNode()
	{
		while (current != null) {
			Console.WriteLine(current.data);
			current = current.next;
		}
	}
	
	public void addNode(Node n)
	{
		Node newNode = new Node();
		current.next = newNode;
		
	}
}
