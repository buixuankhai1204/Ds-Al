namespace Ds_Al.LinkedList;

public class NodeDouble
{
    public int data;
    public NodeDouble next;
    public NodeDouble prev;

    public NodeDouble(int data)
    {
        prev = null;
        this.data = data;
        next = null;
    }
}

public class DoubleLinkedList
{
    private NodeDouble node;
    private int length;

    public DoubleLinkedList()
    {
        node = null;
    }
    public void InsertHeadNode(int data)
    {
        NodeDouble newNode = new NodeDouble(data);
        newNode.next = node;
        node = newNode;
    }

    public void InsertEndNode(int data)
    {
        NodeDouble newNode = new NodeDouble(data);
        NodeDouble tmp = node;

        while (tmp.next != null)
        {
            tmp = tmp.next;
        }

        tmp.next = newNode;
        newNode.prev = tmp;
    }

    public void InsertKthNode(int data, int index)
    {
        NodeDouble newNode = new NodeDouble(data);
        int count = 0;
        NodeDouble tmp = node;

        while (count < index)
        {
            tmp = tmp.next;
            count++;
        }
        newNode.next = tmp.next;
        tmp.next = newNode;
        newNode.prev = tmp;
    }
    
    public void PrintNodeValue()
    {
        int count = 0;
        NodeDouble tmp = node;
        while (tmp != null)
        {
            count++;
            Console.WriteLine(tmp.data);
            tmp = tmp.next;
        }

        length = count;
        Console.WriteLine("Length: " + count);
    }
}