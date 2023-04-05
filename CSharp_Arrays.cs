// C# program to implement basic stack
// operations
using System;

namespace ImplementStack {
class Stack {
	private int[] ele;
	private int top;
	private int max;
	public Stack(int size)
	{
		ele = new int[size]; // Maximum size of Stack
		top = -1;
		max = size;
	}

	public void push(int item)
	{
		if (top == max - 1) {
			Console.WriteLine("Stack Overflow");
			return;
		}
		else {
			ele[++top] = item;
		}
	}

	public int pop()
	{
		if (top == -1) {
			Console.WriteLine("Stack is Empty");
			return -1;
		}
		else {
			Console.WriteLine("{0} popped from stack ", ele[top]);
			return ele[top--];
		}
	}

	public int peek()
	{
		if (top == -1) {
			Console.WriteLine("Stack is Empty");
			return -1;
		}
		else {
			Console.WriteLine("{0} popped from stack ", ele[top]);
			return ele[top];
		}
	}

	public void printStack()
	{
		if (top == -1) {
			Console.WriteLine("Stack is Empty");
			return;
		}
		else {
			for (int i = 0; i <= top; i++) {
				Console.WriteLine("{0} pushed into stack", ele[i]);
			}
		}
	}
}

// Driver program to test above functions
class Program {
	static void Main()
	{
		Stack p = new Stack(5);

		p.push(10);
		p.push(20);
		p.push(30);
		p.printStack();
		p.pop();
	}
}
}
