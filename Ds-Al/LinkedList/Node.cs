namespace Ds_Al.LinkedList;

public class Node
{
    public int data;
    public Node next = null;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }

    public void InsertEndNode(Node node, int data)
    {
        while (node.next != null)
        {
            node = node.next;
        }
        Node newNode = new Node(data);
        node.next = newNode;
    }

    public void InsertHeadNode(Node node, int data)
    {
        Node newNode = new Node(data);
        newNode.next = node;
        node = newNode;
    }

    public void PrintNodeValue(Node node)
    {
        int count = 0;
        while (node != null)
        {
            Console.WriteLine(node.data);
            count++;
            node = node.next;
        }
        Console.WriteLine("Length: " + count);

    }
}