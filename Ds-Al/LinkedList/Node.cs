namespace Ds_Al.LinkedList;

public class Node
{
    public int data;
    public Node next;
}

public class LinkedList
{
    private Node node;

    public LinkedList()
    {
        node = null;
    }
    
    public void InsertHeadNode( int data)
    {
        Node newNode = new Node();
        newNode.data = data;
        newNode.next = node;
        node = newNode;
    }

    public void InsertEndNode(int data)
    {
        Node newNode = new Node();
        newNode.data = data;
        newNode.next = null;
        if (node == null)
        {
            node = newNode;
        }
        else
        {
            Node temp = new Node();
            temp = node;
            while(temp.next != null)
                temp = temp.next;
            temp.next = newNode;
        }
    }

    public void InsertKthNode( int data, int k)
    {
        Node newNode = new Node();
        newNode.data = data;
        newNode.next = null;
        
        int count = 0;
        Node temp = node;
        while (temp != null)
        {
            count++;
            if (count == k)
            {
                newNode.next = temp.next;
                temp.next = newNode;
            }

            temp = temp.next;
        }
    }

    public void DeleteHeadNode()
    {
        if (node != null)
        {
            Node dummyNode = node;
            node = node.next;
            dummyNode = null;
        }
    }

    public void DeleteKthNode()
    {
        
    }

    public void PrintNodeValue()
    {
        int count = 0;
        while (node != null)
        {
            count++;
            Console.WriteLine(node.data);
            node = node.next;
        }
        
        Console.WriteLine("Length: " + count);
    }
}
