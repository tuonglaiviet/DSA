// C# Code for Linked List Implementation
using System;

public class StackAsLinkedList {

	StackNode root;

	public class StackNode {
		public int data;
		public StackNode next;

		public StackNode(int data) { this.data = data; }
	}

	public bool isEmpty()
	{
		if (root == null) {
			return true;
		}
		else
			return false;
	}

	public void push(int data)
	{
		StackNode newNode = new StackNode(data);

		if (root == null) {
			root = newNode;
		}
		else {
			StackNode temp = root;
			root = newNode;
			newNode.next = temp;
		}
		Console.WriteLine(data + " pushed to stack");
	}

	public int pop()
	{
		int popped = int.MinValue;
		if (root == null) {
			Console.WriteLine("Stack is Empty");
		}
		else {
			popped = root.data;
			root = root.next;
		}
		return popped;
	}

	public int peek()
	{
		if (root == null) {
			Console.WriteLine("Stack is empty");
			return int.MinValue;
		}
		else {
			return root.data;
		}
	}

	// Driver code
	public static void Main(String[] args)
	{

		StackAsLinkedList sll = new StackAsLinkedList();

		sll.push(10);
		sll.push(20);
		sll.push(30);

		Console.WriteLine(sll.pop() + " popped from stack");

		Console.WriteLine("Top element is " + sll.peek());
	}
}

/* This code contributed by PrinciRaj1992 */
