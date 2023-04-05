<script>
// javascript Code for Linked List Implementation

var root;

	class StackNode {

		constructor(data) {
			this.data = data;
			this.next = null;
		}
	}

	function isEmpty() {
		if (root == null) {
			return true;
		} else
			return false;
	}

	function push(data) {
		var newNode = new StackNode(data);

		if (root == null) {
			root = newNode;
		} else {
			var temp = root;
			root = newNode;
			newNode.next = temp;
		}
		document.write(data + " pushed to stack<br/>");
	}

	function pop() {
		var popped = Number.MIN_VALUE;
		if (root == null) {
			document.write("Stack is Empty");
		} else {
			popped = root.data;
			root = root.next;
		}
		return popped;
	}

	function peek() {
		if (root == null) {
			document.write("Stack is empty");
			return Number.MIN_VALUE;
		} else {
			return root.data;
		}
	}

	// Driver code
		push(10);
		push(20);
		push(30);

		document.write(pop() + " popped from stack<br/>");

		document.write("Top element is " + peek());

// This code is contributed by Rajput-Ji
</script>
