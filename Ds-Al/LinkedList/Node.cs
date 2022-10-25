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

    public void InsertHeadNode(Node node, int data)
    {
        Node newNode = new Node(data);
        newNode.next = node;
        node = newNode;
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

    public void InsertKthNode(Node node, int data, int k)
    {
        Node newNode = new Node(data);
        int count = 0;
        while (node != null)
        {
            count++;
            if (count == k)
            {
                Console.WriteLine("helasd");
                newNode.next = node.next;
                node.next = newNode;
            }

            node = node.next;
        }
    }
    

    public void PrintNodeValue(Node node)
    {
        int count = 0;
        while (node != null)
        {
            count++;
            Console.WriteLine( + node.data);
            node = node.next;
        }
        Console.WriteLine("Length: " + count);

    }
}