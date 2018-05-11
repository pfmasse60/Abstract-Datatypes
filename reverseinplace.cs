using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		LinkedList myList = new LinkedList();
		
		myList.addNode(1);
		myList.addNode(3);
		myList.addNode(5);
		
		myList.printNodeList(myList.getHead());
		//myList.printNode(myList.getHead());
		
		//Stack<Node> s = new Stack<Node>();
		//s.Push(myList.getHead());
		//Console.WriteLine(s.Count);
	}
}


public class Node
{
	public Node next;
	public int data;
	
	public Node() { next = null; data = 0; }	
	
}

public class LinkedList
{
	public Node head;
	public Node current;
	
	public LinkedList() {
		head = new Node();
		current = head;			
	}

	public void addNode(int n) {
		Node newNode = new Node();
		
		newNode.data = n;
		current.next = newNode;
		current = newNode;
		newNode.next = null;		
	}
	
	public void printNodeList(Node n) {
		//current = head.next;
		while(n != null){
			Console.WriteLine(n.data);
			//current = current.next;
			n = n.next;
		}
		
	}
	
	public void printNodeReverse(Node n) {
		if (n == null)
			Console.WriteLine(n.data);
		
		printNodeReverse(n.next);
		Console.WriteLine(n.data);
		
	}
	
	public Node getHead() { Node newNode = new Node(); newNode = head; return newNode; }
	
	public void printNode(Node n) { Console.WriteLine(n.data); }

}
