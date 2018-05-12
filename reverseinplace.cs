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
		myList.Reverse();
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
		current = head;
		while(current != null){
			Console.WriteLine(current.data);
			current = current.next;
		}
		
	}
	
	public void Reverse() {
		
		Stack s = new Stack();
		Node temp;
		
		current = head;
		while (current != null) {
			//Console.WriteLine("Going into pop " + current.data);
			s.Push(current);
			//Console.WriteLine("The stack contains " + s.Count);
			current = current.next;			
		}
		
		head = (Node)s.Pop();
		//Console.WriteLine("head is " + head.data);
		head.next = null;
		current = head;
		
		while (s.Count > 0) {
			temp = (Node)s.Pop();
			//Console.WriteLine("temp is " + temp.data);
			current.next = temp;
			temp.next = null;
			current = temp;
		}
	}
	
	public Node getHead() { Node newNode = new Node(); newNode = head; return newNode; }

}
