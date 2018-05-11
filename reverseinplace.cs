using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		LinkedList myList = new LinkedList();
		
		myList.addNode(1);
		myList.addNode(3);
		myList.addNode(5);
		
		myList.printNode();
		//myList.printNodeReverse(myList.getHead());
		
		Stack s = new Stack();
		
		myList.current = myList.head;
		while (myList.current != null) {
			s.Push(myList.current);
			myList.current = myList.current.next;
			
		}
	
		//Node temp = (Node)s.Pop();
		Node temp;
		//myList.head = temp;
		//myList.current = temp;
		
		while (s.Count > 0) {
			
			temp = (Node)s.Pop();
			//Console.WriteLine(temp.data);
			temp.next = myList.current;
			myList.current = temp;
			
	
			
		}
		
	myList.printNode();
	
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
	
	public void printNode() {
		current = head.next;
		while(current != null){
			Console.WriteLine(current.data);
			current = current.next;
		}
		
	}
	
	public void printNodeReverse(Node n) {
		if (n == null)
			Console.WriteLine(n.data);
		
		printNodeReverse(n.next);
		Console.WriteLine(n.data);
		
	}
	
	public Node getHead() { Node newNode = new Node(); newNode = head; return newNode; }

}
